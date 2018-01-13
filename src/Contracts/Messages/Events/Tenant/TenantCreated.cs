using System;

namespace Contracts.Messages.Events.Tenant
{
    public class TenantCreated
    {
        public Guid TenantId { get; set; }
    }
}
