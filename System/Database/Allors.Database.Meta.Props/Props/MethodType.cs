// <copyright file="MethodInterface.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Meta.Configuration
{
    using System;
    using System.Linq;
    using Text;

    public sealed partial class MethodType : IMethodTypeBase, IComparable
    {
        private readonly IMetaPopulationBase metaPopulation;

        private string schemaName;

        private string[] assignedWorkspaceNames;
        private string[] derivedWorkspaceNames;

        private string name;

        public MethodType(ICompositeBase objectType, Guid id, string tag = null)
        {
            this.metaPopulation = objectType.MetaPopulation;
            this.ObjectType = objectType;
            this.Id = id;
            this.Tag = tag ?? id.ToBase58();

            this.metaPopulation.OnMethodTypeCreated(this);
        }

        IMetaPopulationBase IMetaObjectBase.MetaPopulation => this.metaPopulation;
        IMetaPopulation IMetaObject.MetaPopulation => this.metaPopulation;
        Origin IMetaObject.Origin => Origin.Database;

        IComposite IMethodType.ObjectType => this.ObjectType;

        public string SchemaName
        {
            get => !string.IsNullOrEmpty(this.schemaName) ? this.schemaName : Schemalizer.Schemalize(this.Name);

            set
            {
                this.metaPopulation.AssertUnlocked();
                this.schemaName = value;
                this.metaPopulation.Stale();
            }
        }

        public bool ExistAssignedSchemaName => !string.IsNullOrEmpty(this.SchemaName) && !this.SchemaName.Equals(Schemalizer.Schemalize(this.Name), StringComparison.Ordinal);


        public string DisplayName => this.Name;

        /// <summary>
        /// Gets the validation name.
        /// </summary>
        /// <value>The validation name.</value>
        public string ValidationName
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Name))
                {
                    return "method type " + this.Name;
                }

                return "unknown method type";
            }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString() => this.Name;

        /// <summary>
        /// Validates the state.
        /// </summary>
        /// <param name="validationLog">The validation.</param>
        void IMethodTypeBase.Validate(ValidationLog validationLog)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                var message = this.ValidationName + " has no name";
                validationLog.AddError(message, this, ValidationKind.Required, "MethodType.Name");
            }
        }

        public override bool Equals(object obj) => this.Id.Equals((obj as IMethodTypeBase)?.Id);

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
        public int CompareTo(object obj) => this.Id.CompareTo((obj as IMethodTypeBase)?.Id);

        public Guid Id { get; }

        public string Tag { get; }

        public ICompositeBase ObjectType { get; }

        public string[] AssignedWorkspaceNames
        {
            get => this.assignedWorkspaceNames ?? Array.Empty<string>();

            set
            {
                this.metaPopulation.AssertUnlocked();
                this.assignedWorkspaceNames = value;
                this.metaPopulation.Stale();
            }
        }

        public string[] WorkspaceNames
        {
            get
            {
                this.metaPopulation.Derive();
                return this.derivedWorkspaceNames;
            }
        }

        public string Name
        {
            get => this.name;

            set
            {
                this.metaPopulation.AssertUnlocked();
                this.name = value;
                this.metaPopulation.Stale();
            }
        }

        public string FullName => $"{this.ObjectType.Name}{this.Name}";

        public void DeriveWorkspaceNames() =>
            this.derivedWorkspaceNames = this.assignedWorkspaceNames != null
                ? this.assignedWorkspaceNames.Intersect(this.ObjectType.Classes.SelectMany(v => v.WorkspaceNames)).ToArray()
                : Array.Empty<string>();
    }
}
