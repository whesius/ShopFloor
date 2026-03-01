// <copyright file="Command.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql.Npgsql
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Meta;
    using global::Npgsql;
    using NpgsqlTypes;
    using Sql;

    public class Command : ICommand
    {
        private readonly Mapping mapping;

        private readonly NpgsqlCommand command;

        public Command(Mapping mapping, NpgsqlCommand command)
        {
            this.mapping = mapping;
            this.command = command;
        }

        public CommandType CommandType
        {
            get => this.command.CommandType;
            set => this.command.CommandType = value;
        }

        public string CommandText
        {
            get => this.command.CommandText;
            set => this.command.CommandText = value;
        }

        public void Dispose()
        {
            this.command.Dispose();
            GC.SuppressFinalize(this);
        }

        public void AddInParameter(string parameterName, object value)
        {
            var parameter = this.command.Parameters.Contains(parameterName) ? this.command.Parameters[parameterName] : null;
            if (parameter == null)
            {
                parameter = this.command.CreateParameter();
                parameter.ParameterName = parameterName;
                if (value is DateTime)
                {
                    parameter.NpgsqlDbType = NpgsqlDbType.TimestampTz;
                }

                // TODO: Use TVP for IN
                //if (value is UnitList list)
                //{
                //    var sqlDbType = this.mapping.GetNpgsqlDbType(list.RoleType);
                //    parameter.NpgsqlDbType = NpgsqlDbType.Array | sqlDbType;
                //}

                this.command.Parameters.Add(parameter);
            }

            if (value == null || value == DBNull.Value)
            {
                parameter.Value = DBNull.Value;
            }
            //else if (value is UnitList list)
            //{
            //    parameter.Value = list.Values.ToArray();
            //}
            else
            {
                parameter.Value = value;
            }
        }

        public void ObjectParameter(long objectId) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameForObject, Mapping.NpgsqlDbTypeForObject).Value = objectId;

        public void AddTypeParameter(IClass @class) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameForClass, Mapping.NpgsqlDbTypeForClass).Value = @class.Id;

        public void AddCountParameter(int count) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameForCount, Mapping.NpgsqlDbTypeForCount).Value = count;

        public void AddUnitRoleParameter(IRoleType roleType, object unit) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameByRoleType[roleType], this.mapping.GetNpgsqlDbType(roleType)).Value = unit ?? DBNull.Value;

        public void AddCompositeRoleParameter(long objectId) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameForCompositeRole, Mapping.NpgsqlDbTypeForObject).Value = objectId;

        public void AddAssociationParameter(long objectId) => this.GetOrCreateParameter(this.mapping.ParamInvocationNameForAssociation, Mapping.NpgsqlDbTypeForObject).Value = objectId;

        public void ObjectTableParameter(IEnumerable<long> objectIds) => this.GetOrCreateTableParameter(this.mapping.ObjectArrayParam.InvocationName, Mapping.NpgsqlDbTypeForObject).Value = objectIds.ToArray();

        public void UnitTableParameter(IRoleType roleType, IEnumerable<UnitRelation> relations)
        {
            var objectParameter = this.GetOrCreateTableParameter(this.mapping.ObjectArrayParam.InvocationName, Mapping.NpgsqlDbTypeForObject);
            var roleParameter = this.GetOrCreateTableParameter(this.mapping.StringRoleArrayParam.InvocationName, this.mapping.GetNpgsqlDbType(roleType));

            var unitRelations = relations as ICollection<UnitRelation> ?? relations.ToArray();
            objectParameter.Value = unitRelations.Select(v => v.Association).ToArray();
            roleParameter.Value = unitRelations.Select(v => v.Role).ToArray();
        }

        public void AddCompositeRoleTableParameter(IEnumerable<CompositeRelation> relations)
        {
            var objectParameter = this.GetOrCreateTableParameter(this.mapping.ObjectArrayParam.InvocationName, Mapping.NpgsqlDbTypeForObject);
            var roleParameter = this.GetOrCreateTableParameter(this.mapping.StringRoleArrayParam.InvocationName, Mapping.NpgsqlDbTypeForObject);

            var compositeRelations = relations as ICollection<CompositeRelation> ?? relations.ToArray();
            objectParameter.Value = compositeRelations.Select(v => v.Association).ToArray();
            roleParameter.Value = compositeRelations.Select(v => v.Role).ToArray();
        }

        public object ExecuteScalar() => this.command.ExecuteScalar();

        public void ExecuteNonQuery() => this.command.ExecuteNonQuery();

        public object GetValue(Reader reader, string tag, int i) =>
            tag switch
            {
                UnitTags.String => reader.GetString(i),
                UnitTags.Integer => reader.GetInt32(i),
                UnitTags.Float => reader.GetDouble(i),
                UnitTags.Decimal => reader.GetDecimal(i),
                UnitTags.Boolean => reader.GetBoolean(i),
                UnitTags.DateTime => reader.GetDateTime(i),
                UnitTags.Unique => reader.GetGuid(i),
                UnitTags.Binary => reader.GetValue(i),
                _ => throw new ArgumentException("Unknown Unit Tag: " + tag),
            };

        public Reader ExecuteReader() => new Reader(this.command.ExecuteReader());

        IReader ICommand.ExecuteReader() => this.ExecuteReader();

        object ICommand.GetValue(IReader reader, string tag, int i) => this.GetValue((Reader)reader, tag, i);

        public void SetupCommand(string procedureName, params string[] parameterInvocations)
        {
            this.SetFunctionCall(procedureName, parameterInvocations);
            this.CommandType = CommandType.Text;
        }

        public void SetupCommandForTableResult(string procedureName, params string[] parameterInvocations)
        {
            this.SetTableFunction(procedureName, parameterInvocations);
            this.CommandType = CommandType.Text;
        }

        internal void SetFunctionCall(string functionName, params string[] parameters)
        {
            if (parameters.Length == 0)
            {
                this.CommandText = $"SELECT {functionName}()";
            }
            else
            {
                this.CommandText = $"SELECT {functionName}({string.Join(", ", parameters)})";
            }
        }

        internal void SetTableFunction(string functionName, params string[] parameters)
        {
            if (parameters.Length == 0)
            {
                this.CommandText = $"SELECT * FROM {functionName}()";
            }
            else
            {
                this.CommandText = $"SELECT * FROM {functionName}({string.Join(", ", parameters)})";
            }
        }

        private NpgsqlParameter GetOrCreateParameter(string parameterName, NpgsqlDbType dbType)
        {
            var parameter = this.command.Parameters.Contains(parameterName) ? this.command.Parameters[parameterName] : null;
            if (parameter != null)
            {
                return parameter;
            }

            parameter = this.command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.NpgsqlDbType = dbType;
            this.command.Parameters.Add(parameter);

            return parameter;
        }

        private NpgsqlParameter GetOrCreateTableParameter(string parameterName, NpgsqlDbType sqlDbType)
        {
            var parameter = this.command.Parameters.Contains(parameterName) ? this.command.Parameters[parameterName] : null;
            if (parameter != null)
            {
                return parameter;
            }

            parameter = this.command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.NpgsqlDbType = NpgsqlDbType.Array | sqlDbType;
            this.command.Parameters.Add(parameter);

            return parameter;
        }

        // TODO: Review
        public void AddCompositesRoleTableParameter(IEnumerable<long> objectIds) => this.ObjectTableParameter(objectIds);
    }
}
