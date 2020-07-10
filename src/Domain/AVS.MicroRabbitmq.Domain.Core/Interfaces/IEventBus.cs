using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using AVS.MicroRabbitmq.Domain.Core.Commands;
using AVS.MicroRabbitmq.Domain.Core.Events;

namespace AVS.MicroRabbitmq.Domain.Core.Interfaces
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
