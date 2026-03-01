// <copyright file="RoleCache.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters
{
    using System.Collections.Generic;
    using Meta;

    public class RoleCache : IRoleCache
    {
        private Dictionary<IRoleType, Dictionary<long, CachedUnitRole>> cachedUnitRoleByAssociationByRoleType;

        private Dictionary<IRoleType, Dictionary<long, CachedCompositeRole>> cachedCompositeRoleByAssociationByRoleType;

        private Dictionary<IRoleType, Dictionary<long, CachedCompositesRole>> cachedCompositesRoleByAssociationByRoleType;

        public RoleCache()
        {
            this.cachedUnitRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedUnitRole>>();
            this.cachedCompositeRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedCompositeRole>>();
            this.cachedCompositesRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedCompositesRole>>();
        }

        public bool TryGetUnit(long associationId, object cacheId, IRoleType roleType, out object role)
        {
            if (this.cachedUnitRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation) && entryByAssociation.TryGetValue(associationId, out var cachedUnitRole) && cachedUnitRole.CacheId.Equals(cacheId))
            {
                role = cachedUnitRole.Role;
                return true;
            }

            role = null;
            return false;
        }

        public void SetUnit(long associationId, object cacheId, IRoleType roleType, object role)
        {
            if (!this.cachedUnitRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation))
            {
                entryByAssociation = new Dictionary<long, CachedUnitRole>();
                this.cachedUnitRoleByAssociationByRoleType[roleType] = entryByAssociation;
            }

            entryByAssociation[associationId] = new CachedUnitRole(cacheId, role);
        }

        public bool TryGetComposite(long associationId, object cacheId, IRoleType roleType, out long? roleId)
        {
            if (this.cachedCompositeRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation) && entryByAssociation.TryGetValue(associationId, out var cachedCompositeRole) && cachedCompositeRole.CacheId.Equals(cacheId))
            {
                roleId = cachedCompositeRole.Role;
                return true;
            }

            roleId = null;
            return false;
        }

        public void SetComposite(long associationId, object cacheId, IRoleType roleType, long? roleId)
        {
            if (!this.cachedCompositeRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation))
            {
                entryByAssociation = new Dictionary<long, CachedCompositeRole>();
                this.cachedCompositeRoleByAssociationByRoleType[roleType] = entryByAssociation;
            }

            entryByAssociation[associationId] = new CachedCompositeRole(cacheId, roleId);
        }

        public bool TryGetComposites(long associationId, object cacheId, IRoleType roleType, out long[] roleIds)
        {
            if (this.cachedCompositesRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation) && entryByAssociation.TryGetValue(associationId, out var cachedCompositesRole) && cachedCompositesRole.CacheId.Equals(cacheId))
            {
                roleIds = cachedCompositesRole.Role;
                return true;
            }

            roleIds = null;
            return false;
        }

        public void SetComposites(long associationId, object cacheId, IRoleType roleType, long[] roleIds)
        {
            if (!this.cachedCompositesRoleByAssociationByRoleType.TryGetValue(roleType, out var entryByAssociation))
            {
                entryByAssociation = new Dictionary<long, CachedCompositesRole>();
                this.cachedCompositesRoleByAssociationByRoleType[roleType] = entryByAssociation;
            }

            entryByAssociation[associationId] = new CachedCompositesRole(cacheId, roleIds);
        }

        public void Invalidate()
        {
            this.cachedUnitRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedUnitRole>>();
            this.cachedCompositeRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedCompositeRole>>();
            this.cachedCompositesRoleByAssociationByRoleType = new Dictionary<IRoleType, Dictionary<long, CachedCompositesRole>>();
        }

        public void Invalidate(long[] objectsToInvalidate)
        {
            foreach (var roleByAssociationEntry in this.cachedCompositeRoleByAssociationByRoleType)
            {
                var roleByAssociation = roleByAssociationEntry.Value;
                foreach (var objectToInvalidate in objectsToInvalidate)
                {
                    roleByAssociation.Remove(objectToInvalidate);
                }
            }

            foreach (var roleByAssociationEntry in this.cachedCompositeRoleByAssociationByRoleType)
            {
                var roleByAssociation = roleByAssociationEntry.Value;
                foreach (var objectToInvalidate in objectsToInvalidate)
                {
                    roleByAssociation.Remove(objectToInvalidate);
                }
            }

            foreach (var roleByAssociationEntry in this.cachedCompositesRoleByAssociationByRoleType)
            {
                var roleByAssociation = roleByAssociationEntry.Value;
                foreach (var objectToInvalidate in objectsToInvalidate)
                {
                    roleByAssociation.Remove(objectToInvalidate);
                }
            }
        }

        private sealed class CachedUnitRole
        {
            internal CachedUnitRole(object cacheId, object role)
            {
                this.CacheId = cacheId;
                this.Role = role;
            }

            public object CacheId { get; }

            public object Role { get; }
        }

        private sealed class CachedCompositeRole
        {
            internal CachedCompositeRole(object cacheId, long? role)
            {
                this.CacheId = cacheId;
                this.Role = role;
            }

            public object CacheId { get; }

            public long? Role { get; }
        }

        private sealed class CachedCompositesRole
        {
            internal CachedCompositesRole(object cacheId, long[] role)
            {
                this.CacheId = cacheId;
                this.Role = role;
            }

            public object CacheId { get; }

            public long[] Role { get; }
        }
    }
}
