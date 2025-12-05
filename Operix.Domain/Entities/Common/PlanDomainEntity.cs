using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class PlanDomainEntity:BaseDomainEntity
    {
        public string Name { get; set; } // Free, Standard, Premium

        public string Description { get; set; }

        public decimal PriceMonthly { get; set; }
        public decimal PriceYearly { get; set; }

        // JSON describing feature limits, e.g. {"maxProjects":10,"aiCredits":100}
        public string FeaturesJson { get; set; }
    }
}