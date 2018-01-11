﻿using Database.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class Context : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TenantUser> TenantUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SingleLicense> SingleLicenses { get; set; }
        public DbSet<GroupLicense> GroupLicenses { get; set; }

    }
}