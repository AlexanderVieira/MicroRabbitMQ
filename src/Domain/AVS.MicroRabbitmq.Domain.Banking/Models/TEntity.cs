using System.Runtime.InteropServices;
namespace AVS.MicroRabbitmq.Domain.Banking.Models
{
    public abstract class TEntity<TID>
    {
        public TID Id { get; set; }
    }
}