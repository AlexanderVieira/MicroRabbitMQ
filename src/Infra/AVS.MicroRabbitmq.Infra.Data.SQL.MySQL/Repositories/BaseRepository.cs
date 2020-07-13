using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;

namespace AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Repositories
{
    public abstract class BaseRepository<TId, T> : IBaseRepository<TId, T> where T : TEntity<TId>
    {
        protected RabbitMqDbContext _ctx; 

        public BaseRepository(RabbitMqDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Delete(TId id)
        {
            var entity = _ctx.Set<T>().Find(id);
            _ctx.Set<T>().Remove(entity);
            _ctx.SaveChanges();
        }        

        public IEnumerable<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

        public T GetById(TId id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Save(T entity)
        {
            _ctx.Set<T>().Add(entity);
            _ctx.SaveChanges();
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
            _ctx.SaveChanges();
        }
           
    }
}