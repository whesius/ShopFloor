// <copyright file="Database.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.SqlClient
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Xml;
    using Allors.Database.Tracing;
    using Sql;
    using Sql.Caching;
    using Meta;
    using Microsoft.Data.SqlClient;
    using Ranges;
    using SqlClient;

    public class Database : IDatabase, Sql.ISqlDatabase
    {
        public static readonly IsolationLevel DefaultIsolationLevel = System.Data.IsolationLevel.Snapshot;

        private readonly Dictionary<IObjectType, HashSet<IObjectType>> concreteClassesByObjectType;

        private readonly Dictionary<IObjectType, IRoleType[]> sortedUnitRolesByObjectType;

        private ICacheFactory cacheFactory;

        public Database(IDatabaseServices state, Configuration configuration)
        {
            this.Services = state;
            if (this.Services == null)
            {
                throw new Exception("Services is missing");
            }

            this.ObjectFactory = configuration.ObjectFactory;
            if (!this.ObjectFactory.MetaPopulation.IsValid)
            {
                throw new ArgumentException("Domain is invalid");
            }

            this.MetaPopulation = this.ObjectFactory.MetaPopulation;

            this.ConnectionString = configuration.ConnectionString;

            this.concreteClassesByObjectType = new Dictionary<IObjectType, HashSet<IObjectType>>();

            this.CommandTimeout = configuration.CommandTimeout;
            this.IsolationLevel = configuration.IsolationLevel;

            this.sortedUnitRolesByObjectType = new Dictionary<IObjectType, IRoleType[]>();

            this.CacheFactory = configuration.CacheFactory;
            this.Cache = this.CacheFactory.CreateCache();

            this.SchemaName = (configuration.SchemaName ?? "allors").ToLowerInvariant();

            this.connectionFactory = configuration.ConnectionFactory;
            this.managementConnectionFactory = configuration.ManagementConnectionFactory;

            var connectionStringBuilder = new SqlConnectionStringBuilder(this.ConnectionString);
            var applicationName = connectionStringBuilder.ApplicationName.Trim();
            if (!string.IsNullOrWhiteSpace(applicationName))
            {
                this.Id = applicationName;
            }
            else if (!string.IsNullOrWhiteSpace(connectionStringBuilder.InitialCatalog))
            {
                this.Id = connectionStringBuilder.InitialCatalog.ToLowerInvariant();
            }
            else
            {
                using var connection = new SqlConnection(this.ConnectionString);
                connection.Open();
                this.Id = connection.Database.ToLowerInvariant();
            }

            this.Services.OnInit(this);
        }


        public IDatabaseServices Services { get; }

        public ICacheFactory CacheFactory
        {
            get => this.cacheFactory;

            set => this.cacheFactory = value ?? (this.cacheFactory = new CacheFactory());
        }


        public string SchemaName { get; }

        public IObjectFactory ObjectFactory { get; }

        public IMetaPopulation MetaPopulation { get; }

        public bool IsShared => true;


        public string ConnectionString { get; set; }

        public ICache Cache { get; }

        public int? CommandTimeout { get; }

        public IsolationLevel? IsolationLevel { get; }


        public IRanges<long> Ranges { get; } = new DefaultStructRanges<long>();

        public ITransaction CreateTransaction()
        {
            var connection = this.ConnectionFactory.Create();
            return this.CreateTransaction(connection);
        }

        public ITransaction CreateTransaction(IConnection connection)
        {
            if (!this.IsValid)
            {
                throw new Exception(this.ValidationMessage);
            }

            return new Transaction(this, connection, this.Services.CreateTransactionServices());
        }

        public ISink Sink { get; set; }

        public override string ToString() => "Population[driver=Sql, type=Connected, id=" + this.GetHashCode() + "]";

        ITransaction IDatabase.CreateTransaction() => this.CreateTransaction();

        public bool ContainsClass(IObjectType container, IObjectType containee)
        {
            if (container.IsClass)
            {
                return container.Equals(containee);
            }

            if (!this.concreteClassesByObjectType.TryGetValue(container, out var concreteClasses))
            {
                concreteClasses = new HashSet<IObjectType>(((IInterface)container).DatabaseClasses);
                this.concreteClassesByObjectType[container] = concreteClasses;
            }

            return concreteClasses.Contains(containee);
        }


        public Type GetDomainType(IObjectType objectType) => this.ObjectFactory.GetType(objectType);

        public IRoleType[] GetSortedUnitRolesByObjectType(IObjectType objectType)
        {
            if (!this.sortedUnitRolesByObjectType.TryGetValue(objectType, out var sortedUnitRoles))
            {
                var sortedUnitRoleList = new List<IRoleType>(((IComposite)objectType).DatabaseRoleTypes.Where(r => r.ObjectType.IsUnit));
                sortedUnitRoleList.Sort();
                sortedUnitRoles = sortedUnitRoleList.ToArray();
                this.sortedUnitRolesByObjectType[objectType] = sortedUnitRoles;
            }

            return sortedUnitRoles;
        }

        private IConnectionFactory connectionFactory;

        private IConnectionFactory managementConnectionFactory;

        private Mapping mapping;

        private bool? isValid;

        private string validationMessage;

        private readonly object lockObject = new object();


        public event ObjectNotLoadedEventHandler ObjectNotLoaded;

        public event RelationNotLoadedEventHandler RelationNotLoaded;

        public IConnectionFactory ConnectionFactory
        {
            get => this.connectionFactory ??= new ConnectionFactory(this);

            set => this.connectionFactory = value;
        }

        public IConnectionFactory ManagementConnectionFactory
        {
            get => this.managementConnectionFactory ??= new ConnectionFactory(this);

            set => this.managementConnectionFactory = value;
        }

        public string Id { get; }

        public bool IsValid
        {
            get
            {
                if (!this.isValid.HasValue)
                {
                    lock (this.lockObject)
                    {
                        if (!this.isValid.HasValue)
                        {
                            var validateResult = new Validation(this);
                            this.isValid = validateResult.IsValid;
                            this.validationMessage = validateResult.Message;
                        }
                    }
                }

                return this.isValid.Value;
            }
        }

        public Mapping Mapping
        {
            get
            {
                if (this.ObjectFactory.MetaPopulation != null && this.mapping == null)
                {
                    this.mapping = new Mapping(this);
                }

                return this.mapping;
            }
        }

        Sql.Schema.IMapping Sql.ISqlDatabase.Mapping => this.Mapping;

        public string ValidationMessage => this.validationMessage;

        public void Init()
        {
            try
            {
                new Initialization(this).Execute();
            }
            finally
            {
                this.mapping = null;
                this.Cache.Invalidate();
                this.Services.OnInit(this);
            }
        }

        public void Load(XmlReader reader)
        {
            lock (this)
            {
                this.Init();

                using (var connection = new SqlConnection(this.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        var load = new Load(this, connection, this.ObjectNotLoaded, this.RelationNotLoaded);
                        load.Execute(reader);

                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            connection.Close();
                        }
                        finally
                        {
                            this.Init();
                            throw e;
                        }
                    }
                }
            }
        }

        public void Save(XmlWriter writer)
        {
            lock (this.lockObject)
            {
                var transaction = new ManagementTransaction(this, this.ManagementConnectionFactory);
                try
                {
                    var save = new Save(this, writer);
                    save.Execute(transaction);
                }
                finally
                {
                    transaction.Rollback();
                }
            }
        }

    }
}
