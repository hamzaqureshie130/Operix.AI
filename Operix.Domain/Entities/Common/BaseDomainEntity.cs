namespace Operix.Domain.Entities.Common
{
    public abstract class BaseDomainEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }


    public enum UserRole
    {
        Owner,
        Admin,
        Member
    }

    public enum LeadStage
    {
        New,
        Contacted,
        Qualified,
        Lost,
        Converted
    }

    public enum ProjectStatus
    {
        Draft,
        Active,
        OnHold,
        Completed,
        Archived
    }

    public enum TaskStatus
    {
        Todo,
        InProgress,
        Review,
        Done,
        Blocked
    }

    public enum TicketStatus
    {
        Open,
        Pending,
        Resolved,
        Closed
    }

    public enum InvoiceStatus
    {
        Draft,
        Sent,
        Paid,
        Overdue,
        Cancelled
    }

}
