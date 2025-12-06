using Operix.Domain.Entities.Common;

namespace Operix.Domain.Entities
{
    public class TaskItemDomainEntity:BaseDomainEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Todo;

        public int Priority { get; set; } = 3; // 1-high to 5-low

        public Guid? AssigneeId { get; set; }
        public UserDomainEntity Assignee { get; set; }

        public DateTime? DueDate { get; set; }

        // time tracking in minutes
        public int TimeSpentMinutes { get; set; } = 0;

        public ICollection<SubTaskDomainEntity> SubTasks { get; set; } = new List<SubTaskDomainEntity>();
        public ICollection<ActivityDomainEntity> Activities { get; set; } = new List<ActivityDomainEntity>();
        public ICollection<FileMetaDomainEntity> Files { get; set; } = new List<FileMetaDomainEntity>();
    }
}