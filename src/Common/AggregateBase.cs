using Contracts.Messages.Events;
using System.Collections.Generic;

namespace Common
{
    public interface IAggregateRoot
    {
        IEnumerable<Event> ListEvents();
    }
}