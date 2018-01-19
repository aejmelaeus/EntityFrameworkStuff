using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class GroupLicense
    {
        public Guid Id { get; set; }

        [Required]
        public int Days { get; set; }

        [Required]
        public int NumberOfUsers { get; set; }

        public DateTime? StartDateUtc { get; set; }

        public DateTime? EndDateUtc { get; set; }

        public Guid? AssignedGroupId { get; set; }

        public Group AssignedGroup { get; set; }

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
