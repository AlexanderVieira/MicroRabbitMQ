using System;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Repositories;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;

namespace AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Repositories
{
    public class AccountRepository : BaseRepository<int, Account>, IAccountRepository
    {
        public AccountRepository(RabbitMqDbContext ctx) : base(ctx)
        {
            
        }
        
    }
}
