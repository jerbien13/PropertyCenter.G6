using System;
using System.Data.Entity;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;
        private IAnnouncementRepository announcements;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public IAnnouncementRepository Announcements
        {
            get
            {
                return announcements ?? (announcements = new AnnouncementRepository(context));
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
