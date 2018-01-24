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
        public int? GroupId { get; private set; }
        public int TenantId { get; private set; }
        public int ProductId { get; private set; }
    }
}
