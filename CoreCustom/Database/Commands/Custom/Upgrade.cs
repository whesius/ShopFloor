// <copyright file="Upgrade.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using Allors.Database.Domain;
    using Allors.Database.Services;

    public static class Upgrade
    {
        private static readonly HashSet<Guid> ExcludedObjectTypes = new HashSet<Guid>
        {
        };

        private static readonly HashSet<Guid> ExcludedRelationTypes = new HashSet<Guid>
        {
        };

        private static readonly HashSet<Guid> MovedRelationTypes = new HashSet<Guid>
        {
        };

        public static int Execute(ProgramContext context, string fileName)
        {
            var fileInfo = new FileInfo(fileName);

            var notLoadedObjectTypeIds = new HashSet<Guid>();
            var notLoadedRelationTypeIds = new HashSet<Guid>();

            var notLoadedObjects = new HashSet<long>();

            using (var reader = XmlReader.Create(fileInfo.FullName))
            {
                context.Database.ObjectNotLoaded += (sender, args) =>
                {
                    if (!ExcludedObjectTypes.Contains(args.ObjectTypeId))
                    {
                        notLoadedObjectTypeIds.Add(args.ObjectTypeId);
                    }
                    else
                    {
                        var id = args.ObjectId;
                        notLoadedObjects.Add(id);
                    }
                };

                context.Database.RelationNotLoaded += (sender, args) =>
                {
                    if (!ExcludedRelationTypes.Contains(args.RelationTypeId) && !notLoadedObjects.Contains(args.AssociationId))
                    {
                        notLoadedRelationTypeIds.Add(args.RelationTypeId);
                    }
                };

                context.Database.Load(reader);
            }

            if (notLoadedObjectTypeIds.Count > 0)
            {
                var notLoaded = notLoadedObjectTypeIds
                    .Aggregate("Could not load following ObjectTypeIds: ", (current, objectTypeId) => current + "- " + objectTypeId);

                return 1;
            }

            if (notLoadedRelationTypeIds.Count > 0)
            {
                var notLoaded = notLoadedRelationTypeIds
                    .Aggregate("Could not load following RelationTypeIds: ", (current, relationTypeId) => current + "- " + relationTypeId);

                return 1;
            }

            using (var transaction = context.Database.CreateTransaction())
            {
                context.Database.Services.Get<IPermissions>().Sync(transaction);

                new Allors.Database.Domain.Upgrade(transaction, context.DataPath).Execute();
                transaction.Commit();

                new Security(transaction).Apply();

                transaction.Commit();
            }

            return ExitCode.Success;
        }
    }
}
