using System;

namespace Database.Entitites
{
    public class GroupLicense
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }

        public int Days { get; set; }
        public int NumberOfUsers { get; set; }

        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }

        public Group AssignedTo { get; set; }
        public Tenant Owner { get; set; }
        public Product Product { get; set; }
    }
}
