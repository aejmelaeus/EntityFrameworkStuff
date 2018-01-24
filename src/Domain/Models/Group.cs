using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Group : Aggretate
    {
        private Group()
        {
            // For EF :)
        }

        public Group(int loggedInUserId, string name) : base(Guid.NewGuid())
        {
            CreatedByUserId = loggedInUserId;
            CreatedUtc = DateTime.UtcNow;
            Name = name;
        }

        public string Name { get; private set; }
        public DateTime CreatedUtc { get; private set; }

        public int CreatedByUserId { get; private set; }

        public int TenantId { get; private set; }

        private readonly List<GroupMember> _members = new List<GroupMember>();
        public IReadOnlyCollection<GroupMember> Members => _members;

        private readonly List<GroupLicense> _licenses = new List<GroupLicense>();
        public IReadOnlyCollection<GroupLicense> Licenses => _licenses;

        public void AddMember(int loggedInUserId, int userId)
        {
            _members.Add(new GroupMember());
        }
    }
}
