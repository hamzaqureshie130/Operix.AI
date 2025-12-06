using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class ContactDomainEntity:BaseDomainEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Guid? LeadId { get; set; }
        public LeadDomainEntity Lead { get; set; }

        public Guid? CompanyId { get; set; }
        public CompanyDomainEntity Company { get; set; }
    }
}