namespace Domain.Models
{
    public class TenantUser
    {
        public int Id { get; private set; }

        public TenantRole Role { get; private set; }
        
        public int TenantId { get; private set; }
        public Tenant Tenant { get; private set; }

        public int UserId { get; private set; }
        public User User { get; private set; }
    }
}
