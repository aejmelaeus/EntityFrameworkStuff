namespace Domain.Models
{
    public class TenantUser
    {
        private TenantUser()
        {
            // For EF :)
        }

        public TenantUser(TenantRole role, int userId)
        {
            Role = role;
            UserId = userId;
        }

        public int Id { get; private set; }

        public TenantRole Role { get; private set; }
        
        public int TenantId { get; private set; }
        public int UserId { get; private set; }
    }
}
