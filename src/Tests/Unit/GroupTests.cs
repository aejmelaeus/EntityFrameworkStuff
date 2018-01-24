using System;
using System.Collections.Generic;
using Domain.Models;
using Xunit;

namespace Tests.Unit
{
    public class GroupTests
    {
        [Fact]
        public void Ctor_WhenCalled_LoggedInUserBecomesCreatorAndPropertiesInitialized()
        {
            // Arrange
            var tenantId = 123;
            var userId = 456;
      
            var groupName = "Weikkos Grupp";
            

            var tenants = new List<TenantMembership>
            {
                new TenantMembership(TenantRole.Teacher, userId, tenantId)
            };

            var loggedInUser = new User(userId, tenants, "Weikko testar", new EmailAddress("weikko@peikko.com"));
            
            // Act
            var group = new Group(loggedInUser, tenantId, groupName);

            // Assert
            Assert.Equal(groupName, group.Name);
            Assert.Equal(userId, group.CreatedByUserId);
            Assert.False(group.CreatedUtc == default(DateTime));
            Assert.False(group.ExternalId == default(Guid));
        }

        [Fact]
        public void Ctor_WhenLoggedInUserIsNotConnectedToTenant_ThrowsException()
        {
            // Arrange
            var tenantId = 123;
            var groupName = "En fejlande grupp";
            var loggedInUser = new User("Weikko Testar", new EmailAddress("weikko@peikko.com"));

            // Act & Assert
            Assert.Throws<Exception>(() => new Group(loggedInUser, tenantId, groupName));
        }
    }
}
