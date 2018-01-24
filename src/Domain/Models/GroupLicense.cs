using System;

namespace Domain.Models
{
    public class GroupLicense : Aggretate
    {
        static GroupLicense Create(User loggedInUser, Product product, int tenantId, int numberOfUsers, int days)
        {
            return new GroupLicense();
        }

        static GroupLicense CreateBeta(User loggedInUser, Product product, int tenantId)
        {
            return new GroupLicense();
        }

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
