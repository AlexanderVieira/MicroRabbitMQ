using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using AVS.MicroRabbitmq.Domain.Core.Events;

namespace AVS.MicroRabbitmq.Domain.Core.Interfaces
{
    public interface IEventHandler
    {
        
    }

    public interface IEventHandler<in TEvent>
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }
}
