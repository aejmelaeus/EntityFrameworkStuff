using System;

namespace Contracts.Messages.Events.Tenant
{
    public class TenantUpdated
    {
        public Guid TenantId { get; set; }
    }
}
