using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public interface IAnnouncementService : IServiceBase
    {
        ICollection<Announcement> GetAnnouncements();

        void AddAnnouncement(Announcement announcement);
    }
}
