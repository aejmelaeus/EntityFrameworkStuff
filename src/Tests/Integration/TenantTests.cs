using System;
using System.Linq;
using System.Threading.Tasks;
using Database;
using Domain.Interfaces;
using Domain.Models;
using Xunit;

namespace Tests.Integration
{
    public class TenantTests
    {
        private readonly IAggregateRepository<Tenant> _tenantRepository;
        private readonly IAggregateRepository<User> _userRepository;

        public TenantTests()
        {
            var databaseContext = new DatabaseContext();

            _tenantRepository = new AggregateRepository<Tenant>(databaseContext);
            _userRepository = new AggregateRepository<User>(databaseContext);
        }

        [Fact]
        public async Task Create_WhenCalled_TenantIsCreated()
        {
            // Arrange
            var emailAddress = new EmailAddress($"weikko.{Guid.NewGuid()}@test.com");
            var user = new User("Weikko Testar", emailAddress);

            await _userRepository.Add(user);
            await _userRepository.Commit();

            var tenantName = "Weikko Testar tenant";
            var tenant = new Tenant(tenantName, user.Id);
            
            // Act
            await _tenantRepository.Add(tenant);
            await _tenantRepository.Commit();

            // Assert
            var tenantFromDb = await _tenantRepository.FindByExternalId(tenant.ExternalId);
            Assert.Equal(tenantName, tenantFromDb.Name);

            var tenantUser = tenantFromDb.TenantUsers.Single();
            Assert.Equal(user.Id, tenantUser.UserId);
        }
    }
}
