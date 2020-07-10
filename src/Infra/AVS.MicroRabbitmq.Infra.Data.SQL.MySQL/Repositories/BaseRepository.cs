using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;

namespace AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        protected RabbitMqDbContext _ctx;        

        public BaseRepository()
        {
            _ctx = new RabbitMqDbContext();
        }

        public void Delete(Guid id)
        {
            var obj = _ctx.Set<T>().Find(id);
            _ctx.Set<T>().Remove(obj);
            _ctx.SaveChanges();
        }        

        public IEnumerable<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Save(T obj)
        {
            _ctx.Set<T>().Add(obj);
            _ctx.SaveChanges();
        }

        public void Update(T obj)
        {
            _ctx.Update(obj); //Entry<T>(obj).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }        
    }
}