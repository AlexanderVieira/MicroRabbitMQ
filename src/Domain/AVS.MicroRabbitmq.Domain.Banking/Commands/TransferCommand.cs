using System;
using AVS.MicroRabbitmq.Domain.Core.Commands;

namespace AVS.MicroRabbitmq.Domain.Banking.Commands
{
    public abstract class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
