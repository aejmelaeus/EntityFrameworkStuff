using System;

namespace Contracts.Messages.Events.Group
{
    public class GroupCreated : Event
    {
        public Guid TenantId { get; set; }
        public Guid GroupdId { get; set; }
    }
}
