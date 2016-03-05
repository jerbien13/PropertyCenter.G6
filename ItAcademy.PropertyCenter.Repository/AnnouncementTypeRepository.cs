
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Caching;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public class AnnouncementTypeRepository : GenericCacheRepository<AnnouncementType>, IAnnouncementTypeRepository
    {
        public AnnouncementTypeRepository(DbContext context, ICacheProvider cacheProvider)
            : base(context, cacheProvider)
        {
        }

        public override ICollection<AnnouncementType> GetAll()
        {
            var key = "AnnouncementType_GetAll";
            var result = CacheProvider.Get(key) as ICollection<AnnouncementType>;

            if (result == null)
            {
                result = base.GetAll();
                CacheProvider.Set(key, result, int.Parse(ConfigurationManager.AppSettings["DataCacheTime"]));
            }

            return result;
        }
    }
}
