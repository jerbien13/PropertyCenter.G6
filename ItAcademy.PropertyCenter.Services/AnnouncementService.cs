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
        public Announcement GetAnnouncementById(int id)
        {
            return UnitOfWork.Announcements.GetById(id);
        }

        public void AddAnnouncement(Announcement announcement)
        {
            UnitOfWork.Announcements.Insert(announcement);

            UnitOfWork.Commit();
        }

        public void UpdateAnnouncement(Announcement announcement)
        {
            UnitOfWork.Announcements.Update(announcement);

            UnitOfWork.Commit();
        }
    }
}
