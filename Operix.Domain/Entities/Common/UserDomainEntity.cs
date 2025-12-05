namespace Operix.Domain.Entities.Common
{
    public class UserDomainEntity : BaseDomainEntity
    {
   
        public string Email { get; set; }

        public string FullName { get; set; }

        public string PasswordHash { get; set; } // if using Identity, map accordingly

        public bool EmailConfirmed { get; set; } = false;

        public UserRole Role { get; set; } = UserRole.Member;

        // Optional: external auth provider id (Google, etc)
        public string ExternalProvider { get; set; }

        public string ExternalProviderId { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation
        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
        public ICollection<FileMetaDomainEntity> Files { get; set; } = new List<FileMetaDomainEntity>();
    }
}