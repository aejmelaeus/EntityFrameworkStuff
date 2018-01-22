using System;

namespace Domain.Models
{
    public class GroupLicense : Aggretate
    {
        public GroupLicense() : base(Guid.Empty)
        {
            // TODO!
        }

        public int Days { get; private set; }
        public int NumberOfUsers { get; private set; }
        public DateTime? StartDateUtc { get; private set; }
        public DateTime? EndDateUtc { get; private set; }

        public int? AssignedGroupId { get; private set; }
        public Group AssignedGroup { get; private set; }

        public int OwnerId { get; private set; }
        public Tenant Owner { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }
    }
}
