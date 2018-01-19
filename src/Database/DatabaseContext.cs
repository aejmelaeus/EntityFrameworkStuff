using Database.Entitites;
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
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TenantUser> TenantUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SingleLicense> SingleLicenses { get; set; }
        public DbSet<GroupLicense> GroupLicenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
    }
}
