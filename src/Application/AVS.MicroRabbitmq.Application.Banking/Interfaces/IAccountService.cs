using System;
using System.Collections.Generic;
using AVS.MicroRabbitmq.Application.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Models;

namespace AVS.MicroRabbitmq.Application.Banking.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();
        void AddAccount(Account account);        
        Account GetAccountById(int id);
        void RemoveAccountById(int id);
        void UpdateAccount(Account account);
        void Transfer(AccountTransfer accountTransfer);
    }
}
