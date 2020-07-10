using System;
using System.Collections.Generic;
using AVS.MicroRabbitmq.Application.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Models;

namespace AVS.MicroRabbitmq.Application.Banking.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
