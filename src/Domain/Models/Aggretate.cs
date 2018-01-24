using System;
using System.Collections.Generic;
using Contracts.Messages.Events;

namespace Domain.Models
{
    public abstract class Aggretate : Entity
    {
        private readonly List<Event> _events = new List<Event>();

        protected Aggretate()
        {
            // For EF :)
        }

        protected Aggretate(Guid extenrnalId)
        {
            ExternalId = extenrnalId;
        }

        protected void AddEvent(Event @event)
        {
            _events.Add(@event);
        }

        public IReadOnlyCollection<Event> GetEvents()
        {
            return _events;
        }

        public Guid ExternalId { get; private set; }
    }
}
