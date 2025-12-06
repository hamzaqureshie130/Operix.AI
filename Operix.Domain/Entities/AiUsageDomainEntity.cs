using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class AiUsageDomainEntity:BaseDomainEntity
    {
        public Guid? TenantIdRef { get; set; }
        public int TokensUsed { get; set; } = 0;
        public decimal EstimatedCost { get; set; } = 0m;
        public string DetailsJson { get; set; } 
    }
}