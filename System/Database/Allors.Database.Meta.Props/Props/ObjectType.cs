// <copyright file="ObjectType.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the IObjectType type.</summary>

namespace Allors.Database.Meta.Configuration
{
    using System;
    using System.Collections.Generic;
    using Text;

    public abstract partial class ObjectType : IObjectTypeBase
    {
        private string singularName;

        private string pluralName;

        private string schemaName;

        protected ObjectType(IMetaPopulationBase metaPopulation, Guid id, string tag = null)
        {
            this.MetaPopulation = metaPopulation;
            this.Id = id;
            this.Tag = tag ?? id.ToBase58();
        }

        public Guid Id { get; }

        public string Tag { get; }

        public string SingularName
        {
            get => this.singularName;

            set
            {
                this.MetaPopulation.AssertUnlocked();
                this.singularName = value;
                this.MetaPopulation.Stale();
            }
        }

        public string PluralName
        {
            get => !string.IsNullOrEmpty(this.pluralName) ? this.pluralName : Pluralizer.Pluralize(this.SingularName);

            set
            {
                this.MetaPopulation.AssertUnlocked();
                this.pluralName = value;
                this.MetaPopulation.Stale();
            }
        }

        public bool ExistAssignedPluralName => !string.IsNullOrEmpty(this.PluralName) && !this.PluralName.Equals(Pluralizer.Pluralize(this.SingularName), StringComparison.Ordinal);

        public string SchemaName
        {
            get => !string.IsNullOrEmpty(this.schemaName) ? this.schemaName : Schemalizer.Schemalize(this.SingularName);

            set
            {
                this.MetaPopulation.AssertUnlocked();
                this.schemaName = value;
                this.MetaPopulation.Stale();
            }
        }

        public bool ExistAssignedSchemaName => !string.IsNullOrEmpty(this.SchemaName) && !this.SchemaName.Equals(Schemalizer.Schemalize(this.SingularName), StringComparison.Ordinal);

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name .</value>
        public string Name => this.SingularName;

        public bool IsUnit => this is IUnit;

        public bool IsComposite => this is IComposite;

        public bool IsInterface => this is IInterface;

        public bool IsClass => this is IClass;

        public abstract Type ClrType { get; }

        public abstract IEnumerable<string> WorkspaceNames { get; }

        public IMetaPopulationBase MetaPopulation { get; }

        /// <summary>
        /// Gets the validation name.
        /// </summary>
        /// <value>The validation name.</value>
        public string ValidationName
        {
            get
            {
                if (!string.IsNullOrEmpty(this.SingularName))
                {
                    return "object type " + this.SingularName;
                }

                return "object type " + this.Id;
            }
        }

        public override bool Equals(object obj) => this.Id.Equals((obj as ObjectType)?.Id);

        public override int GetHashCode() => this.Id.GetHashCode();

        /// <summary>
        /// Compares the current state with another object of the same type.
        /// </summary>
        /// <param name="obj">An object to compare with this state.</param>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This state is less than <paramref name="obj"/>. Zero This state is equal to <paramref name="obj"/>. Greater than zero This state is greater than <paramref name="obj"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="obj"/> is not the same type as this state. </exception>
        public int CompareTo(object obj) => this.Id.CompareTo((obj as ObjectType)?.Id);

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.SingularName))
            {
                return this.SingularName;
            }

            return this.Tag.ToString();
        }

        /// <summary>
        /// Validates this state.
        /// </summary>
        /// <param name="log">The validation.</param>
        public void Validate(ValidationLog log)
        {
            this.ValidateIdentity(log);

            if (!string.IsNullOrEmpty(this.SingularName))
            {
                if (this.SingularName.Length < 2)
                {
                    var message = this.ValidationName + " should have a singular name with at least 2 characters";
                    log.AddError(message, this, ValidationKind.MinimumLength, "IObjectType.SingularName");
                }
                else
                {
                    if (!char.IsLetter(this.SingularName[0]))
                    {
                        var message = this.ValidationName + "'s singular name should start with an alfabetical character";
                        log.AddError(message, this, ValidationKind.Format, "IObjectType.SingularName");
                    }

                    for (var i = 1; i < this.SingularName.Length; i++)
                    {
                        if (!char.IsLetter(this.SingularName[i]) && !char.IsDigit(this.SingularName[i]))
                        {
                            var message = this.ValidationName + "'s singular name should only contain alfanumerical characters";
                            log.AddError(message, this, ValidationKind.Format, "IObjectType.SingularName");
                            break;
                        }
                    }
                }

                if (log.ExistObjectTypeName(this.SingularName))
                {
                    var message = "The singular name of " + this.ValidationName + " is already in use";
                    log.AddError(message, this, ValidationKind.Unique, "IObjectType.SingularName");
                }
                else
                {
                    log.AddObjectTypeName(this.SingularName);
                }
            }
            else
            {
                log.AddError(this.ValidationName + " has no singular name", this, ValidationKind.Required, "IObjectType.SingularName");
            }

            if (!string.IsNullOrEmpty(this.PluralName))
            {
                if (this.PluralName.Length < 2)
                {
                    var message = this.ValidationName + " should have a plural name with at least 2 characters";
                    log.AddError(message, this, ValidationKind.MinimumLength, "IObjectType.PluralName");
                }
                else
                {
                    if (!char.IsLetter(this.PluralName[0]))
                    {
                        var message = this.ValidationName + "'s plural name should start with an alfabetical character";
                        log.AddError(message, this, ValidationKind.Format, "IObjectType.PluralName");
                    }

                    for (var i = 1; i < this.PluralName.Length; i++)
                    {
                        if (!char.IsLetter(this.PluralName[i]) && !char.IsDigit(this.PluralName[i]))
                        {
                            var message = this.ValidationName + "'s plural name should only contain alfanumerical characters";
                            log.AddError(message, this, ValidationKind.Format, "IObjectType.PluralName");
                            break;
                        }
                    }
                }

                if (log.ExistObjectTypeName(this.PluralName))
                {
                    var message = "The plural name of " + this.ValidationName + " is already in use";
                    log.AddError(message, this, ValidationKind.Unique, "IObjectType.PluralName");
                }
                else
                {
                    log.AddObjectTypeName(this.PluralName);
                }
            }
        }

        IMetaPopulation IMetaObject.MetaPopulation => this.MetaPopulation;

        public abstract Origin Origin { get; }
        public int OriginAsInt => (int)this.Origin;

        public bool HasDatabaseOrigin => this.Origin == Origin.Database;

        public bool HasSessionOrigin => this.Origin == Origin.Session;
    }
}
