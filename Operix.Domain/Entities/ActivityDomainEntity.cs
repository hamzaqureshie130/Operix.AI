using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities
{
    public class ActivityDomainEntity:BaseDomainEntity
    {
        public string EntityType { get; set; } // e.g., "Lead"

        public Guid? EntityId { get; set; }
        public string Action { get; set; } // e.g., "Created", "Updated", "Commented"

        public Guid? PerformedBy { get; set; } // user id

        public string DataJson { get; set; } // details of change, optional
    }
}