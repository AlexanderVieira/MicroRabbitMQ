using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AVS.MicroRabbitmq.Application.Banking.Interfaces;
using AVS.MicroRabbitmq.Application.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Models;

namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {        
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {            
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAllAccounts());
        }

        [HttpGet("{id}")]
        public ActionResult<Account> Get(int id)
        {
            return Ok(_accountService.GetAccountById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        } 

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Account account)
        {
            account.Id = id;
            _accountService.UpdateAccount(account);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _accountService.RemoveAccountById(id);
        }
    }
}