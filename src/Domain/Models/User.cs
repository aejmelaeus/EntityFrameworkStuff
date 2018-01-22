using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User
    {
        private User()
        {
            // For EF :)
        }

        public User(string displayName, EmailAddress emailAddress)
        {
            Email = emailAddress;
            DisplayName = displayName;
        }

        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string DisplayName { get; set; }
        public EmailAddress Email { get; set; }

        private readonly List<TenantUser> _tenantUsers = new List<TenantUser>();
        public IReadOnlyCollection<TenantUser> TenantUsers => _tenantUsers;
    }
}
