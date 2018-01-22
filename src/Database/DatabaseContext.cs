﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    internal class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Tenants;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ConfigureGroup(builder);
            ConfigureGroupLicense(builder);
            ConfigureProduct(builder);
            ConfigureTenant(builder);
            ConfigureTenantUser(builder);
            ConfigureUser(builder);
        }

        private static void ConfigureUser(ModelBuilder builder)
        {
            var userEntity = builder.Entity<User>();

            userEntity.Property(_ => _.Email)
                .IsRequired()
                .HasMaxLength(128);

            userEntity.Property(_ => _.DisplayName)
                .IsRequired()
                .HasMaxLength(128);

            userEntity.Property(_ => _.ExternalId)
                .IsRequired();

            userEntity.HasIndex(u => u.Email)
                .IsUnique();

            userEntity.HasIndex(u => u.ExternalId)
                .IsUnique();

            userEntity.Metadata.FindNavigation(nameof(User.TenantUsers))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private static void ConfigureTenantUser(ModelBuilder builder)
        {
            var tenantUserEntity = builder.Entity<TenantUser>();

            tenantUserEntity.Property(_ => _.Role)
                .IsRequired();
        }

        private static void ConfigureTenant(ModelBuilder builder)
        {
            var tenantEntity = builder.Entity<Tenant>();

            tenantEntity.Property(_ => _.ExternalId)
                .IsRequired();

            tenantEntity.Property(_ => _.Name)
                .IsRequired()
                .HasMaxLength(128);

            tenantEntity.HasIndex(_ => _.ExternalId)
                .IsUnique();

            tenantEntity.Metadata.FindNavigation(nameof(Tenant.GroupLicenses))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            tenantEntity.Metadata.FindNavigation(nameof(Tenant.Groups))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            tenantEntity.Metadata.FindNavigation(nameof(Tenant.TenantUsers))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private static void ConfigureProduct(ModelBuilder builder)
        {
            var productEntity = builder.Entity<Product>();

            productEntity.Property(_ => _.ExternalId)
                .IsRequired();

            productEntity.Property(_ => _.Name)
                .HasMaxLength(128)
                .IsRequired();

            productEntity.Property(_ => _.Url)
                .HasMaxLength(512)
                .IsRequired();
            productEntity.HasIndex(_ => _.ExternalId)
                .IsUnique();
        }

        private static void ConfigureGroupLicense(ModelBuilder builder)
        {
            var groupLicenseEntity = builder.Entity<GroupLicense>();

            groupLicenseEntity.Property(_ => _.Days)
                .IsRequired();

            groupLicenseEntity.Property(_ => _.NumberOfUsers)
                .IsRequired();
        }

        private static void ConfigureGroup(ModelBuilder builder)
        {
            var groupEntity = builder.Entity<Group>();

            groupEntity.Property(_ => _.ExternalId)
                .IsRequired();

            groupEntity.Property(_ => _.Name)
                .IsRequired().HasMaxLength(128);

            groupEntity.Property(_ => _.CreatedUtc)
                .IsRequired();

            groupEntity.HasIndex(_ => _.ExternalId)
                .IsUnique();

            groupEntity.Metadata.FindNavigation(nameof(Group.Licenses))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            groupEntity.Metadata.FindNavigation(nameof(Group.Members))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        internal DbSet<Tenant> Tenants { get; set; }
        internal DbSet<User> Users { get; set; }
        internal DbSet<TenantUser> TenantUsers { get; set; }
        internal DbSet<Group> Groups { get; set; }
        internal DbSet<GroupLicense> GroupLicenses { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<GroupMember> GroupMembers { get; set; }
    }
}
