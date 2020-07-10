using System;
using System.Collections.Generic;

namespace AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories
{
    public interface IBaseRepository<TId, T>
    {
        IEnumerable<T> GetAll();
        T GetById(TId id);
        void Save(T entity);
        void Update(T entity);
        void Delete(TId entity);        
    }
}