using System;
using System.Collections.Generic;

namespace Contracts.Queries
{
    public class UserQueryItem
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }

        public IEnumerable<Tenant> Tenants { get; set; }

        public class Tenant
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
        }
    }
}
