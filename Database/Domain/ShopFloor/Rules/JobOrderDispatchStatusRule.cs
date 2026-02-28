namespace Allors.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Database.Derivations;
    using Derivations.Rules;
    using Meta;

    public class JobOrderDispatchStatusRule : Rule
    {
        public JobOrderDispatchStatusRule(M m) : base(m, new Guid("c1000003-0001-4000-8000-000000000001")) =>
            this.Patterns = new Pattern[]
            {
                m.JobResponse.RolePattern(v => v.EndTime, v => v.JobOrder),
            };

        public override void Derive(ICycle cycle, IEnumerable<IObject> matches)
        {
            foreach (var @this in matches.Cast<JobOrder>())
            {
                @this.DeriveJobOrderDispatchStatus();
            }
        }
    }

    public static class JobOrderDispatchStatusRuleExtensions
    {
        public static void DeriveJobOrderDispatchStatus(this JobOrder @this)
        {
            if (@this.Response?.EndTime != null)
            {
                var m = @this.Strategy.Transaction.Database.Services.Get<M>();
                var completedStatus = new DispatchStatuses(@this.Transaction()).FindBy(
                    m.DispatchStatus.UniqueId, new Guid("b0000003-0001-4000-8000-000000000007"));

                if (completedStatus != null)
                {
                    @this.DispatchStatus = completedStatus;
                }
            }
        }
    }
}
