using System;

namespace Contracts.Messages.Events.Group
{
    public class GroupMemberRemoved : Event
    {
        public Guid TenantId { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}
