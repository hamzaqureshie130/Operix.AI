using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
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