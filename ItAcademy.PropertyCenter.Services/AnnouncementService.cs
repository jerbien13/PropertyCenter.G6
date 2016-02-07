using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public class AnnouncementService : ServiceBase, IAnnouncementService
    {
        public ICollection<Announcement> GetAnnouncements()
        {
            return UnitOfWork.Announcements.GetAll();
        }
    }
}
