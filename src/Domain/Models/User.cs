using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User : Aggretate
    {
        private User()
        {
            // For EF :)
        }

        public User(string displayName, EmailAddress emailAddress) : base(Guid.NewGuid())
        {
            Email = emailAddress;
            DisplayName = displayName;
        }

        public string DisplayName { get; private set; }
        public EmailAddress Email { get; private set; }

        private readonly List<TenantUser> _tenantUsers = new List<TenantUser>();
        public IReadOnlyCollection<TenantUser> TenantUsers => _tenantUsers;
    }
}
