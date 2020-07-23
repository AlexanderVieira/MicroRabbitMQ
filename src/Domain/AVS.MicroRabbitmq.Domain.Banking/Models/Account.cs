using System;

namespace AVS.MicroRabbitmq.Domain.Banking.Models
{
    public class Account : TEntity<int>
    {
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }        
    }
}