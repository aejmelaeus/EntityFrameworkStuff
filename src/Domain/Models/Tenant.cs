using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Tenant : Aggretate
    {
        private Tenant()
        {
            // For EF :)
        }

        public Tenant(string name, int loggedInUserId) : base(Guid.NewGuid())
        {
            Name = name;
            _tenantUsers.Add(new TenantUser(TenantRole.Administrator, loggedInUserId));
        }

        public string Name { get; private set; }

        private readonly List<TenantUser> _tenantUsers = new List<TenantUser>();
        public IReadOnlyCollection<TenantUser> TenantUsers => _tenantUsers;
    }
}
