using System;

namespace Contracts.Messages.Events
{
    public class Event
    {
        public Guid LoggedInUserId { get; set; }
        public DateTime TimeStampUtc { get; set; }
    }
}
