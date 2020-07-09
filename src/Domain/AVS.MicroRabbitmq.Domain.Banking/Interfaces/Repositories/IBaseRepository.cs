using System;
using System.Collections.Generic;

namespace AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Save(T obj);
        void Update(T obj);
        void Delete(Guid id);
        void Dispose();
    }
}