using System;
using System.Collections.Generic;

namespace Database.Entitites
{
    public class Tenant
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public List<TenantUser> TenantUsers { get; set; }
        public List<Group> Groups { get; set; }
        public List<SingleLicense> Licenses { get; set; }
        public List<GroupLicense> GroupLicenses { get; set; }
    }
}
