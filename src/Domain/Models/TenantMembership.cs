namespace Domain.Models
{
    public class TenantMembership : Entity
    {
        private TenantMembership()
        {
            // For EF :)
        }

        public TenantMembership(TenantRole role, int userId, int tenantId)
        {
            Role = role;
            UserId = userId;
            TenantId = tenantId;
        }

        public TenantRole Role { get; private set; }
        
        public int TenantId { get; private set; }
        public int UserId { get; private set; }
    }
}
