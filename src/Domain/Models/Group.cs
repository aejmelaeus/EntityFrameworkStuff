using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class Group : Aggretate
    {
        private Group()
        {
            // For EF :)
        }

        public Group(User loggedInUser, int tenantId, string name) : base(Guid.NewGuid())
        {
            if (!CanCreateGroup(loggedInUser, tenantId))
            {
                throw new Exception();
            }

            Name = name;
            CreatedByUserId = loggedInUser.Id;
            CreatedUtc = DateTime.UtcNow;
        }

        private bool CanCreateGroup(User loggedInUser, int tenantId)
        {
            var tenant = loggedInUser.TenantMemberships.SingleOrDefault(_ => _.TenantId == tenantId);

            if (tenant?.Role >= TenantRole.Teacher)
            {
                return true;
            }

            return false;
        }

        public string Name { get; private set; }
        public DateTime CreatedUtc { get; private set; }

        public int CreatedByUserId { get; private set; }

        public int TenantId { get; private set; }

        private readonly List<GroupMembership> _groupMemberships = new List<GroupMembership>();
        public IReadOnlyCollection<GroupMembership> GroupMemberships => _groupMemberships;

        private readonly List<GroupLicense> _groupLicenses = new List<GroupLicense>();
        public IReadOnlyCollection<GroupLicense> GroupLicenses => _groupLicenses;

        public void AddMember(int loggedInUserId, int userId)
        {
            _groupMemberships.Add(new GroupMembership());
        }
    }
}
