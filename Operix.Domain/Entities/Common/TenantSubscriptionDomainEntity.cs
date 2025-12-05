using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class TenantSubscriptionDomainEntity:BaseDomainEntity
    {
        public Guid TenantIdRef { get; set; } // duplicate tenant link for quick queries
        public Guid? PlanId { get; set; }
        public Plan Plan { get; set; }
        public string StripeSubscriptionId { get; set; }
        public string StripeCustomerId { get; set; }

        public DateTime? CurrentPeriodStart { get; set; }
        public DateTime? CurrentPeriodEnd { get; set; }

        public bool IsActive { get; set; } = false;
    }
}