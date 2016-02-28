using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public interface IAnnouncementService : IServiceBase
    {
        ICollection<Announcement> GetAnnouncements();

        Announcement GetAnnouncementById(int id);

        void AddAnnouncement(Announcement announcement);
        void UpdateAnnouncement(Announcement announcement);

        void DeleteAnnouncement(int id);
    }
}
