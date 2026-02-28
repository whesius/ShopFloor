namespace Allors.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Database.Derivations;
    using Derivations.Rules;
    using Meta;

    public class PersonDisplayNameRule : Rule
    {
        public PersonDisplayNameRule(M m) : base(m, new Guid("c1000002-0001-4000-8000-000000000001")) =>
            this.Patterns = new Pattern[]
            {
                m.Person.RolePattern(v => v.FirstName),
                m.Person.RolePattern(v => v.LastName),
            };

        public override void Derive(ICycle cycle, IEnumerable<IObject> matches)
        {
            foreach (var @this in matches.Cast<Person>())
            {
                @this.DerivePersonDisplayName();
            }
        }
    }

    public static class PersonDisplayNameRuleExtensions
    {
        public static void DerivePersonDisplayName(this Person @this)
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(@this.FirstName))
            {
                parts.Add(@this.FirstName);
            }

            if (!string.IsNullOrWhiteSpace(@this.LastName))
            {
                parts.Add(@this.LastName);
            }

            @this.DisplayName = parts.Count > 0 ? string.Join(" ", parts) : "N/A";
        }
    }
}
