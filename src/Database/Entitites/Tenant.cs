using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class Tenant
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        public List<TenantUser> TenantUsers { get; set; } = new List<TenantUser>();
        public List<Group> Groups { get; set; } = new List<Group>();
        public List<SingleLicense> SingleLicenses { get; set; } = new List<SingleLicense>();
        public List<GroupLicense> GroupLicenses { get; set; } = new List<GroupLicense>();
    }
}
