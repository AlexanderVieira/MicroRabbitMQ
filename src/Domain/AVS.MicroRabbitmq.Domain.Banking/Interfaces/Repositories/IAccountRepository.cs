using System;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;

namespace AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories
{
    public interface IAccountRepository : IBaseRepository<int,Account>
    {
        
    }
}