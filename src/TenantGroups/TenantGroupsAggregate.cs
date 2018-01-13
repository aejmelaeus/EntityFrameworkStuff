using Common;
using Contracts.Messages.Events;
using System;
using System.Collections.Generic;

namespace TenantGroups
{
    public class TenantGroupsAggregate : IAggregateRoot
    {
        public void CreateGroup(Guid loggedInUserId, string name)
        {

        }

        public void UpdateGroupName(Guid loggedInUserId, string newName)
        {

        }

        public void AddUserToGroup(Guid loggedInUserId, Guid groupId, Guid userId)
        {

        }

        public void RemoveUserFromGroup(Guid loggedInUserId, Guid groupId, Guid userId)
        {

        }

        public IEnumerable<Event> ListEvents()
        {
            throw new NotImplementedException();
        }
    }

    public class TenantGroup
    {

    }

    public class TenantUser
    {

    }
}
