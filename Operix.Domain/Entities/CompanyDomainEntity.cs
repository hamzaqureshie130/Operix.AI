using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class CompanyDomainEntity :BaseDomainEntity
    {
        public string Name { get; set; }

        public string Industry { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public ICollection<LeadDomainEntity> Leads { get; set; } = new List<LeadDomainEntity>();
        public ICollection<ContactDomainEntity> Contacts { get; set; } = new List<ContactDomainEntity>();
    }
}