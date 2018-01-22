using System;
using System.Collections.Generic;

//using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Group : Aggretate
    {
        public Group() : base(Guid.NewGuid())
        {
            
        }

        public string Name { get; private set; }
        public DateTime CreatedUtc { get; private set; }

        public int CreatedById { get; private set; }
        public User CreatedBy { get; private set; }

        public int TenantId { get; private set; }
        public Tenant Tenant { get; private set; }

        private readonly List<GroupMember> _members = new List<GroupMember>();
        public IReadOnlyCollection<GroupMember> Members => _members;

        private readonly List<GroupLicense> _licenses = new List<GroupLicense>();
        public IReadOnlyCollection<GroupLicense> Licenses => _licenses;
    }
}
