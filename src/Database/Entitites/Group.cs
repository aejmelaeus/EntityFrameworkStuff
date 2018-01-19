using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class Group
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedUtc { get; set; }

        [Required]
        public Guid CreatedByUserId { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string CreatedByUserDisplayName { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        [Required]
        public Tenant Tenant { get; set; }

        public List<GroupMember> Members { get; set; } = new List<GroupMember>();

        public List<GroupLicense> Licenses { get; set; } = new List<GroupLicense>();
    }
}
