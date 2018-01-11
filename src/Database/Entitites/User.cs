using System;
using System.Collections.Generic;

namespace Database.Entitites
{
    public class User
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }

        public string DisplayName { get; set; }
        public string Email { get; set; }

        public List<TenantUser> TenantUsers { get; set; }
    }
}
