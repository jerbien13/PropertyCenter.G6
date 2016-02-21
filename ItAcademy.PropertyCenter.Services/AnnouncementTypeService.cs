using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public class AnnouncementTypeService : ServiceBase, IAnnouncementTypeService
    {
        public ICollection<AnnouncementType> GetAll()
        {
            return UnitOfWork.AnnouncementTypes.GetAll();
        }
    }
}
