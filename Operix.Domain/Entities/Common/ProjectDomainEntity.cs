using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class ProjectDomainEntity:BaseDomainEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ProjectStatus Status { get; set; } = ProjectStatus.Draft;

        public Guid? OwnerId { get; set; } // User who owns the project
        public UserDomainEntity Owner { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<TaskItemDomainEntity> Tasks { get; set; } = new List<TaskItemDomainEntity>();
        public ICollection<ActivityDomainEntity> Activities { get; set; } = new List<ActivityDomainEntity>();
        public ICollection<FileMetaDomainEntity> Files { get; set; } = new List<FileMetaDomainEntity>();
    }
}