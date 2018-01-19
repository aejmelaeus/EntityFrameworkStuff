using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class SingleLicense
    {
        public Guid Id { get; set; }

        [Required]
        public int Days { get; set; }

        public DateTime? StartDateUtc { get; set; }

        public DateTime? EndDateUtc { get; set; }

        public int? AssignedUserId { get; set; }

        public TenantUser AssignedUser { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public Tenant Owner { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Product Product { get; set; }
    }
}
