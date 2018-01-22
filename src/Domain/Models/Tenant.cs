using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Tenant
    {
        public int Id { get; private set; }

        public Guid ExternalId { get; private set; }

        public string Name { get; private set; }

        private readonly List<TenantUser> _tenantUsers = new List<TenantUser>();
        public IReadOnlyCollection<TenantUser> TenantUsers => _tenantUsers;

        private readonly List<Group> _groups = new List<Group>();
        public IReadOnlyCollection<Group> Groups => _groups;

        private readonly List<GroupLicense> _groupLicenses = new List<GroupLicense>();
        public IReadOnlyCollection<GroupLicense> GroupLicenses => _groupLicenses;
    }
}
