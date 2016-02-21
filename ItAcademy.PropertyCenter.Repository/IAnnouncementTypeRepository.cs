
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
   public interface IAnnouncementTypeRepository : IReadOnlyRepository<AnnouncementType>, IPersistRepository<AnnouncementType>
    {
    }
}
