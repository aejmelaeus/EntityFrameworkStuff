using Domain.Models;
using Microsoft.EntityFrameworkCore;

using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tests")]

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
            ConfigureGroupMember(builder);
            ConfigureGroupLicense(builder);
            ConfigureProduct(builder);
            ConfigureTenant(builder);
            ConfigureTenantUser(builder);
            ConfigureUser(builder);
        }

        private void ConfigureGroupMember(ModelBuilder builder)
        {
            var groupMemberEntity = builder.Entity<GroupMember>();

            groupMemberEntity.HasOne<User>()
                .WithMany()
                .HasForeignKey(_ => _.UserId);

            groupMemberEntity.HasIndex(gm => new
            {
                gm.GroupId,
                gm.UserId
            }).IsUnique();
        }

        private static void ConfigureUser(ModelBuilder builder)
        {
            var userEntity = builder.Entity<User>();

            userEntity.HasKey(_ => _.Id);

            userEntity.Property(_ => _.DisplayName)
                .IsRequired()
                .HasMaxLength(128);

            userEntity.Property(_ => _.ExternalId)
                .IsRequired();

            userEntity.HasIndex(u => u.ExternalId)
                .IsUnique();

            userEntity.Metadata.FindNavigation(nameof(User.TenantUsers))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            userEntity.OwnsOne(s => s.Email, email =>
            {
                email.Property(c => c.Value)
                    .IsRequired()
                    .HasMaxLength(128);

                email.HasIndex(_ => _.Value)
                    .IsUnique();
            });
        }

        private static void ConfigureTenantUser(ModelBuilder builder)
        {
            var tenantUserEntity = builder.Entity<TenantUser>();

            tenantUserEntity.Property(_ => _.Role)
                .IsRequired();

            tenantUserEntity.HasIndex(tu => new
            {
                tu.TenantId, tu.UserId

            }).IsUnique();
        }

        private static void ConfigureTenant(ModelBuilder builder)
        {
            var tenantEntity = builder.Entity<Tenant>();

            tenantEntity.HasKey(_ => _.Id);

            tenantEntity.Property(_ => _.ExternalId)
                .IsRequired();

            tenantEntity.Property(_ => _.Name)
                .IsRequired()
                .HasMaxLength(128);

            tenantEntity.HasIndex(_ => _.ExternalId)
                .IsUnique();

            tenantEntity.Metadata.FindNavigation(nameof(Tenant.TenantUsers))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private static void ConfigureProduct(ModelBuilder builder)
        {
            var productEntity = builder.Entity<Product>();

            productEntity.HasKey(_ => _.Id);

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

            groupLicenseEntity.HasKey(_ => _.Id);

            groupLicenseEntity.Property(_ => _.Days)
                .IsRequired();

            groupLicenseEntity.Property(_ => _.NumberOfUsers)
                .IsRequired();

            groupLicenseEntity.HasOne<Product>()
                .WithMany()
                .HasForeignKey(_ => _.ProductId);

            groupLicenseEntity.HasOne<Tenant>()
                .WithMany()
                .HasForeignKey(_ => _.TenantId);

        }

        private static void ConfigureGroup(ModelBuilder builder)
        {
            var groupEntity = builder.Entity<Group>();

            groupEntity.HasKey(_ => _.Id);

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

            groupEntity.Property(_ => _.CreatedByUserId)
                .IsRequired();

            groupEntity.HasOne<User>()
                .WithMany()
                .HasForeignKey(_ => _.CreatedByUserId);

            groupEntity.HasOne<Tenant>()
                .WithMany()
                .HasForeignKey(_ => _.TenantId);
        }

        internal DbSet<Tenant> Tenants { get; set; }
        internal DbSet<User> Users { get; set; }
        internal DbSet<Group> Groups { get; set; }
        internal DbSet<GroupLicense> GroupLicenses { get; set; }
        internal DbSet<Product> Products { get; set; }
    }
}
