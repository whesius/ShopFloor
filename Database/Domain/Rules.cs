namespace Allors.Database.Domain
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Derivations.Rules;
    using Meta;

    public static partial class Rules
    {
        public static Rule[] Create(M m)
        {
            var assembly = typeof(Rules).Assembly;

            var types = assembly.GetTypes()
                .Where(type => type.Namespace != null &&
                               type.GetTypeInfo().IsSubclassOf(typeof(Rule)))
                .ToArray();

            var rules = types.Select(v => Activator.CreateInstance(v, m)).Cast<Rule>().ToArray();

            var duplicates = rules.GroupBy(v => v.Id).Where(g => g.Skip(1).Any()).ToArray();

            if (duplicates.Any())
            {
                throw new InvalidOperationException("Duplicate rules detected: " + string.Join(", ", duplicates.Select(v => v.Key)));
            }

            return rules;
        }
    }
}
