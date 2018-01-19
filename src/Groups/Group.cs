using System;
using System.Collections.Generic;
using Contracts.Messages.Events;

namespace Groups
{
    public class Group
    {
        private readonly string _name;
        private readonly string _createdBy;

        public Tenant Tenant { get; set; }

        public Group(Guid loggedInUserId, string loggedInUserDisplayName, string name)
        {
            
        }

        internal Group()
        {

        }

        public void UpdateName(Guid loggedInUserId, string newName)
        {

        }

        public void AddMember(Guid loggedInUserId, Guid groupId, Guid userId)
        { 

        }

        public void RemoveMember(Guid loggedInUserId, Guid groupId, Guid userId)
        {

        }

        public void AssignLicense(Guid loggedInUserId, Guid groupLicenseId)
        {

        }

        public void UnassignLicense(Guid loggedInUserId, Guid groupLicenseId)
        {

        }

        public IEnumerable<Event> ListEvents()
        {
            throw new NotImplementedException();
        }
    }
}