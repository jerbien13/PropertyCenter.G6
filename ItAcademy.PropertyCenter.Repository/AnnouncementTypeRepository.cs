
using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public class AnnouncementTypeRepository : GenericRepository<AnnouncementType>, IAnnouncementTypeRepository
    {
        public AnnouncementTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
