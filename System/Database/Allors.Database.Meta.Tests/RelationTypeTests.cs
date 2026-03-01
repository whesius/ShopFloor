// <copyright file="RangesAddTests.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Meta.Tests
{
    using System;
    using Configuration;
    using Xunit;

    public class RelationTypeTests
    {
        [Fact]
        public void Validation()
        {
            var metaPopulation = new MetaPopulation();
            var domain =
                new Domain(metaPopulation, new Guid("8DABA92E-F41D-463B-8039-BDA66018BCB2")) { Name = "Domain" };

            var subledgerEntry = new SubledgerEntry(metaPopulation);
            var customerSubledgerEntry = new CustomerSubledgerEntry(metaPopulation);
            var subledgerEntryType = new SubledgerEntryType(metaPopulation);

            var inheritance =
                new Inheritance(metaPopulation) { Subtype = customerSubledgerEntry, Supertype = subledgerEntry };

            metaPopulation.StructuralDerive();
            ((IMetaPopulationBase)metaPopulation).Derive();

            Assert.True(true);
        }

        public class SubledgerEntry : Interface
        {
            public SubledgerEntry(MetaPopulation metaPopulation) : base(
                metaPopulation, new Guid("8B87A291-D04A-440D-840C-F70EBD9DEB92"), null)
            {
            }
        }

        public class CustomerSubledgerEntry : Class
        {
            public CustomerSubledgerEntry(MetaPopulation metaPopulation) : base(
                metaPopulation, new Guid("DBD0BF2B-84AD-4CBB-9BDF-79779C1BF64C"), null)
            {
            }
        }

        public class SubledgerEntryType : Class
        {
            public SubledgerEntryType(MetaPopulation metaPopulation) : base(
                metaPopulation, new Guid("2F1D9E4F-A431-4689-B7C8-3CA85517945E"), null)
            {
            }
        }
    }

    public class MetaPopulation : MetaPopulationBase
    {
    }
}
