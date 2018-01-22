using System;
using Domain.Models;
using Xunit;

namespace Tests.Unit
{
    public class EmailTests
    {
        [Fact]
        public void Constructor_WhenCalledWithValidEmail_EmailIsCreated()
        {
            // Arrange
            var value = "weikko.aejmelaeus@nok.se";

            // Act
            var emailAddress = new EmailAddress(value);

            // Assert
            Assert.Equal(value, emailAddress.Value);
        }

        [Fact]
        public void Constructor_WhenCalledWithInvalidEmail_ThrowsException()
        {
            // Arrange
            var value = "weikko.aejmelaeus";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => new EmailAddress(value));

            // Assert: 
            Assert.Equal($"{value}\r\nParameter name: value", exception.Message);
        }
    }
}
