namespace Operix.Domain.Entities.Common
{
    public class TeantDomainEntity:BaseDomainEntity
    {
        
        public string Name { get; set; }
        public string Subdomain { get; set; } // e.g., acme.mysaas.com => "acme"
        public string StripeCustomerId { get; set; }
        public string MetadataJson { get; set; } // additional metadata

        public TenantStatus Status { get; set; } = TenantStatus.Active;

        public ICollection<UserDomainEntity> Users { get; set; } = new List<UserDomainEntity>();
        public ICollection<CompanyDomainEntity> Companies { get; set; } = new List<CompanyDomainEntity>();
    }

     public enum TenantStatus
    {
        Active,
        Suspended,
        Cancelled
    }
}