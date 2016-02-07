
using System;

namespace ItAcademy.PropertyCenter.Repository.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementRepository Announcements { get; }

        void Commit();
    }
}
