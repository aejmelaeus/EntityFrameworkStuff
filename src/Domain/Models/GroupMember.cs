namespace Domain.Models
{
    public class GroupMember
    {
        public int Id { get; private set; }

        public int GroupId { get; private set; }
        public Group Group { get; private set; }

        public int TenantUserId { get; private set; }
        public TenantUser TenantUser { get; private set; }
    }
}