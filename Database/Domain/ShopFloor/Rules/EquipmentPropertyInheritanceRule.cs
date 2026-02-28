namespace Allors.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Database.Derivations;
    using Derivations.Rules;
    using Meta;

    public class EquipmentPropertyInheritanceRule : Rule
    {
        public EquipmentPropertyInheritanceRule(M m) : base(m, new Guid("c1000004-0001-4000-8000-000000000001")) =>
            this.Patterns = new Pattern[]
            {
                m.Equipment.RolePattern(v => v.EquipmentClasses),
            };

        public override void Derive(ICycle cycle, IEnumerable<IObject> matches)
        {
            foreach (var @this in matches.Cast<Equipment>())
            {
                @this.DeriveEquipmentPropertyInheritance();
            }
        }
    }

    public static class EquipmentPropertyInheritanceRuleExtensions
    {
        public static void DeriveEquipmentPropertyInheritance(this Equipment @this)
        {
            if (@this.EquipmentClasses == null)
            {
                return;
            }

            var existingProperties = @this.EquipmentProperties?
                .Where(p => p.EquipmentClassProperty != null)
                .ToDictionary(p => p.EquipmentClassProperty) ?? new Dictionary<EquipmentClassProperty, EquipmentProperty>();

            foreach (var equipmentClass in @this.EquipmentClasses)
            {
                if (equipmentClass.EquipmentClassProperties == null)
                {
                    continue;
                }

                foreach (var classProperty in equipmentClass.EquipmentClassProperties)
                {
                    if (!existingProperties.ContainsKey(classProperty))
                    {
                        var property = @this.Transaction().Build<EquipmentProperty>();
                        property.Name = classProperty.Name;
                        property.Value = classProperty.DefaultValue;
                        property.EquipmentClassProperty = classProperty;
                        @this.AddEquipmentProperty(property);
                    }
                }
            }
        }
    }
}
