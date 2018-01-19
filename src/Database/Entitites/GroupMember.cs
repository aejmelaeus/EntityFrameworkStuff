using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class GroupMember
    {
        public int Id { get; set; }

        [Required]
        public Guid GroupId { get; set; }

        [Required]
        public Group Group { get; set; }

        [Required]
        public int TenantUserId { get; set; }

        [Required]
        public TenantUser TenantUser { get; set; }
    }
}