using System;

namespace Contracts.Queries
{
    public class TenantUserQueryItem
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}