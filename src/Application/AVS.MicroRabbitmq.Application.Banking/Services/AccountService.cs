using System.Collections;
using System;
using System.Collections.Generic;
using AVS.MicroRabbitmq.Application.Banking.Interfaces;
using AVS.MicroRabbitmq.Application.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Commands;
using AVS.MicroRabbitmq.Domain.Core.Interfaces;

namespace AVS.MicroRabbitmq.Application.Banking.Services
{
    public class AccountService : IAccountService
    {   
        private readonly IEventBus _bus;
        private readonly IAccountRepository _accountRepository;

        public AccountService(IEventBus bus, IAccountRepository accountRepository)
        {   
            _bus = bus;
            _accountRepository = accountRepository;
        }

        public void AddAccount(Account account)
        { 
            //_uow.BeginTransaction();  
            _accountRepository.Save(account); 
            //_uow.Commit();           
        }

        public Account GetAccountById(int id)
        {
            return _accountRepository.GetById(id);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountRepository.GetAll();
        }

        public void UpdateAccount(Account account)
        {
            //_uow.BeginTransaction();
            _accountRepository.Update(account);
            //_uow.Commit();
        }

        public void RemoveAccountById(int id)
        {
            var account = GetAccountById(id);           

            //_uow.BeginTransaction();
            _accountRepository.Delete(id);
            //_uow.Commit();
        }   

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand
            (
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
            );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
