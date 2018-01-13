using System;

namespace Contracts.Messages.Events.TenantUser
{
    public class UserAddedToTenant : Event
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
    }
}
