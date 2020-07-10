using System;
using System.Text;
using System.Collections.Generic;

namespace AVS.MicroRabbitmq.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
