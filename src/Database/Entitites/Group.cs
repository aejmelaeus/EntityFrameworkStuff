using System;
using System.Collections.Generic;

namespace Database.Entitites
{
    public class Group
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public Tenant Tenant { get; set; }
        public List<TenantUser> Members { get; set; }
        public List<GroupLicense> Licenses { get; set; }
    }
}
