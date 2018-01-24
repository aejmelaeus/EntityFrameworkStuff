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

        public string Name { get; private set; }

        private readonly List<TenantMembership> _tenantMemberships = new List<TenantMembership>();
        public IReadOnlyCollection<TenantMembership> TenantMemberships => _tenantMemberships;
    }
}
