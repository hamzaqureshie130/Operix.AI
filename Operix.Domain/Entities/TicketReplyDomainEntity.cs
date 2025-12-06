using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class TicketReply:BaseDomainEntity
    {
        public Guid TicketId { get; set; }
        public TicketDomainEntity Ticket { get; set; }

        public Guid? RepliedById { get; set; }
        public UserDomainEntity RepliedBy { get; set; }

        public string Body { get; set; }

        // Indicates if reply was AI generated/suggested
        public bool IsAiSuggestion { get; set; } = false;
    }
}