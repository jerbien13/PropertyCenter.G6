using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public interface IReadOnlyRepository<T> : IDisposable
        where T : IEntityWithKey
    {
        T GetById(int id);

        ICollection<T> GetAll();

        ICollection<T> Query(Expression<Func<T, bool>> predicate);
    }
}
