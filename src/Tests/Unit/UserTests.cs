using System;
using Domain.Models;
using Xunit;

namespace Tests.Unit
{
    public class UserTests
    {
        [Fact]
        public void Ctor_WhenCalled_DisplayNameAndEmailAndExternalIdSet()
        {
            // Arrange
            var displayName = "Weikko Aejmelaeus";
            var emailAddress = new EmailAddress("weikko.aejmelaeus@nok.se");
            
            // Act
            var user = new User(displayName, emailAddress);

            // Assert
            Assert.Equal(displayName, user.DisplayName);
            Assert.Same(emailAddress, user.Email);
            Assert.NotEqual(Guid.Empty, user.ExternalId);
        }
    }
}