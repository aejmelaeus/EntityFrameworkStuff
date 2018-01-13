using System;

namespace Contracts.Messages.Events.Group
{
    public class GroupMemberAdded : Event
    {
        public Guid TenantId { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}
