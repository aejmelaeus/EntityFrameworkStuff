using System;
using System.Collections.Generic;
using Common;

namespace Contracts.Queries
{
    public class GroupQueryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatedByUserId { get; set; }
        public string CreatedByUserDisplayName { get; set; }
        public IEnumerable<Member> Members { get; set; }

        public class Member
        {
            public Guid UserId { get; set; }
            public string DisplayName { get; set; }
            public string Email { get; set; }
            public TenantRole Role { get; set; }
        }
    }
}