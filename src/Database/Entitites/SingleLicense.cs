using System;

namespace Database.Entitites
{
    public class SingleLicense
    {
        public Guid Id { get; set; }

        public int Days { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }

        public Guid AssignedToId { get; set; }
        public TenantUser AssignedTo { get; set; }

        public Guid OwnerId { get; set; }
        public Tenant Owner { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
