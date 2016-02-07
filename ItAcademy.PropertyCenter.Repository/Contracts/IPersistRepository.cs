using System;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public interface IPersistRepository<T> : IDisposable
        where T : IEntityWithKey
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);
    }
}
