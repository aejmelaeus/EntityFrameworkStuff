using System;
using System.Collections.Generic;
using Common;
using Database;
using Database.Entitites;
using Xunit;

namespace Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void Cascade()
        {
            var tenant = new Tenant
            {
                Name = "Weikko testar lite"
            };

            var product = new Product
            {
                Name = "En testprodukt"
            };

            var user = new User
            {
                DisplayName = "Weikko",
                Email = "weikko@peikko.com"
            };

            var tenantUser = new TenantUser
            {
                User = user,
                Tenant = tenant,
                Role = TenantRole.Administrator
            };

            var group = new Group
            {
                Tenant = tenant,
                Name = "En sann testgrupp",
                CreatedUtc = DateTime.UtcNow,
                CreatedByUserDisplayName = "Weikko Peikko",
                CreatedByUserId = Guid.NewGuid()
            };

            var groupMember = new GroupMember
            {
                Group = group,
                TenantUser = tenantUser
            };

            using (var database = new DatabaseContext())
            {
                database.Tenants.Add(tenant);
                database.Products.Add(product);
                database.Users.Add(user);
                database.TenantUsers.Add(tenantUser);
                database.Groups.Add(group);
                database.GroupMembers.Add(groupMember);

                database.SaveChanges();
            }

            Assert.True(true);
        }
    }
}
