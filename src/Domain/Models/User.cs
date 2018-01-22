using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }

        private readonly List<TenantUser> _tenantUsers = new List<TenantUser>();
        public IReadOnlyCollection<TenantUser> TenantUsers => _tenantUsers;
    }
}
