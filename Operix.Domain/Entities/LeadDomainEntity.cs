using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class LeadDomainEntity:BaseDomainEntity
    {
        public string Title { get; set; }

        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }

        public string Source { get; set; } // e.g. "Website", "Referral"

        public LeadStage Stage { get; set; } = LeadStage.New;
        public decimal? Score { get; set; }

        public string ScoreReason { get; set; } // optional explanation from AI

        public Guid? OwnerUserId { get; set; }
        public User OwnerUser { get; set; }

        public ICollection<ContactDomainEntity> Contacts { get; set; } = new List<ContactDomainEntity>();
        public ICollection<ActivityDomainEntity> Activities { get; set; } = new List<ActivityDomainEntity>();
        public ICollection<FileMeta> Files { get; set; } = new List<FileMeta>();
    }
}