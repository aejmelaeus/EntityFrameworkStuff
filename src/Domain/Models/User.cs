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

        internal User(int id, List<TenantMembership> tenantMemberships, string displayName, EmailAddress emailAddress) : 
            this(displayName, emailAddress)
        {
            Id = id;
            _tenantMemberships = tenantMemberships;
        }

        public User(string displayName, EmailAddress emailAddress) : base(Guid.NewGuid())
        {
            Email = emailAddress;
            DisplayName = displayName;
        }

        public string DisplayName { get; private set; }
        public EmailAddress Email { get; private set; }

        private readonly List<TenantMembership> _tenantMemberships = new List<TenantMembership>();
        public IReadOnlyCollection<TenantMembership> TenantMemberships => _tenantMemberships;
    }
}
