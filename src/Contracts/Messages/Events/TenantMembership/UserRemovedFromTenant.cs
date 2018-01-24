using System;

namespace Contracts.Messages.Events.TenantMembership
{
    public class UserRemovedFromTenant : Event
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
    }
}
