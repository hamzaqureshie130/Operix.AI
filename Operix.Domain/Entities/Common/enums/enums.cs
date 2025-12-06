using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common.enums
{
    public class enums
    {

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
}