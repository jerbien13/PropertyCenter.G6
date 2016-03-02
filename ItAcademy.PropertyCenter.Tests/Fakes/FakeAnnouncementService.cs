using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;
using ItAcademy.PropertyCenter.Services;

namespace ItAcademy.PropertyCenter.Tests.Fakes
{
    public class FakeAnnouncementService : IAnnouncementService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IUnitOfWork UnitOfWork { get; set; }
        public ICollection<Announcement> GetAnnouncements()
        {
            return new List<Announcement>()
            {
                new Announcement() {Title = "announcement1"},
                new Announcement() {Title = "announcement1"}
            };
        }

        public Announcement GetAnnouncementById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAnnouncement(Announcement announcement)
        {
            throw new NotImplementedException();
        }

        public void AddAnnouncement(Announcement announcement)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnnouncement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
