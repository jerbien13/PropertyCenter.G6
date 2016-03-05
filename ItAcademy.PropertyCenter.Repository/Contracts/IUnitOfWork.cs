
using System;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementRepository Announcements { get; }

        IAgencyRepository Agencies { get; }

        IAnnouncementTypeRepository AnnouncementTypes { get; }

        IUserProfileRepository UserProfiles { get; }

        void Commit();
    }
}
