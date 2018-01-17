using System;

namespace Database.Entitites
{
    public class TenantUser
    {
        public int Id { get; set; }

        public Guid TenantId { get; set; }
        public Tenant Tenant { get; set; }

        public Guid UserId { get; set; }  
        public User User { get; set; }

        public int Role { get; set; }
    }
}
