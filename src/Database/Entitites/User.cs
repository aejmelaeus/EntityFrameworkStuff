using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class User
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string DisplayName { get; set; }

        [Required]
        [MaxLength(128)]
        public string Email { get; set; }

        public List<TenantUser> TenantUsers { get; set; }
    }
}
