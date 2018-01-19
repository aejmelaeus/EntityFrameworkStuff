using System;
using System.ComponentModel.DataAnnotations;
using Common;

namespace Database.Entitites
{
    internal class TenantUser
    {
        public int Id { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        [Required]
        public Tenant Tenant { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public TenantRole Role { get; set; }
    }
}
