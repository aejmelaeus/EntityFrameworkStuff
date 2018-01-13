using System;

namespace Contracts.Messages.Events.Group
{
    public class GroupUpdated : Event
    {
        public Guid TenantId { get; set; }
        public Guid GroupdId { get; set; }
    }
}
