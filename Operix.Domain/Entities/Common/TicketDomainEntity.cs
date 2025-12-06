using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class TicketDomainEntity:BaseDomainEntity
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public TicketStatus Status { get; set; } = TicketStatus.Open;

        public int Priority { get; set; } = 3;

        public Guid? CreatedById { get; set; }
        public UserDomainEntity CreatedBy { get; set; }

        public Guid? AssignedToId { get; set; }
        public UserDomainEntity AssignedTo { get; set; }

        public ICollection<TicketReply> Replies { get; set; } = new List<TicketReply>();
        public ICollection<FileMetaDomainEntity> Files { get; set; } = new List<FileMetaDomainEntity>();
        public ICollection<ActivityDomainEntity> Activities { get; set; } = new List<ActivityDomainEntity>();
    }
}