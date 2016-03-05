using ItAcademy.PropertyCenter.Repository.Caching;
using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public class GenericCacheRepository<T> : GenericRepository<T>, ICacheRepository
        where T : class, IEntityWithKey
    {
        public GenericCacheRepository(DbContext context, ICacheProvider provider) 
            : base(context)
        {
        }

        public ICacheProvider CacheProvider
        {
            get; private set;
        }
    }
}
