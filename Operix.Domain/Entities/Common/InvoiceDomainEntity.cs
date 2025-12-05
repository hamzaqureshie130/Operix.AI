using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class InvoiceDomainEntity
    {
        public string Number { get; set; } // Invoice number

        public Guid? CompanyId { get; set; } // billed to company/client
        public CompanyDomainEntity Company { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; }
        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }
        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;

        // Payment integration
        public string StripeInvoiceId { get; set; }

        public ICollection<InvoiceLineDomainEntity> Lines { get; set; } = new List<InvoiceLineDomainEntity>();
        public ICollection<ActivityDomainEntity> Activities { get; set; } = new List<ActivityDomainEntity>();
    }
}