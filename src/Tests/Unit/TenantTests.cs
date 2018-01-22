using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Xunit;

namespace Tests.Unit
{
    public class TenantTests
    {
        [Fact]
        public async Task Ctor_WhenCalled_LoggedInUserAddedAsAdminAndExternalIdSet()
        {
            // Arrange
            var loggedInUserId = 123;
            var name = "En fin tenant!";
            
            // Act
            var tenant = new Tenant(name, loggedInUserId);

            // Assert
            Assert.Equal(name, tenant.Name);
            var tenantUser = tenant.TenantUsers.Single();
            Assert.Equal(loggedInUserId, tenantUser.UserId);
            Assert.Equal(TenantRole.Administrator, tenantUser.Role);
            Assert.NotEqual(Guid.Empty, tenant.ExternalId);
        }
    }
}
