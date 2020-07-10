using System.Runtime.InteropServices;
namespace AVS.MicroRabbitmq.Domain.Banking.Models
{
    public abstract class TEntity<TId>
    {
        public TId Id { get; set; }
    }
}