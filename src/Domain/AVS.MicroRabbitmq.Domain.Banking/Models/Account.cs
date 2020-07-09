using System;

namespace AVS.MicroRabbitmq.Domain.Banking.Models
{
    public class Account : TEntity<Guid>
    {
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}