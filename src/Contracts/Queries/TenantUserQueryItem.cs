using System;
using Common;

namespace Contracts.Queries
{
    public class TenantUserQueryItem
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public TenantRole Role { get; set; }
    }
}