using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class InvoiceLineDomainEntity:BaseDomainEntity
    {
        public Guid InvoiceId { get; set; }
        public InvoiceDomainEntity Invoice { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; } // Quantity * UnitPrice
    }
}