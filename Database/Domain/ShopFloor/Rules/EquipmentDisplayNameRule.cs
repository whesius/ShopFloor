namespace Allors.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Database.Derivations;
    using Derivations.Rules;
    using Meta;

    public class EquipmentDisplayNameRule : Rule
    {
        public EquipmentDisplayNameRule(M m) : base(m, new Guid("c1000001-0001-4000-8000-000000000001")) =>
            this.Patterns = new Pattern[]
            {
                m.Equipment.RolePattern(v => v.Name),
                m.Equipment.RolePattern(v => v.EquipmentParent),
            };

        public override void Derive(ICycle cycle, IEnumerable<IObject> matches)
        {
            foreach (var @this in matches.Cast<Equipment>())
            {
                @this.DeriveEquipmentDisplayName();
            }
        }
    }

    public static class EquipmentDisplayNameRuleExtensions
    {
        public static void DeriveEquipmentDisplayName(this Equipment @this)
        {
            var parts = new List<string>();

            var current = @this;
            while (current != null)
            {
                parts.Insert(0, current.Name);
                current = current.EquipmentParent;
            }

            @this.DisplayName = string.Join(" > ", parts);
        }
    }
}
