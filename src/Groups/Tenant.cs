using System;
using System.Collections.Generic;

namespace Groups
{
    public class Tenant
    {
        public Guid Id { get; set; }
        public List<TenantUser> TenantUsers { get; set; }
    }
}