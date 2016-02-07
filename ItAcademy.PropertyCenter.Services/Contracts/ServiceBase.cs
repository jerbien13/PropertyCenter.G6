using System;
using ItAcademy.PropertyCenter.Repository.Contracts;
using Microsoft.Practices.Unity;

namespace ItAcademy.PropertyCenter.Services.Contracts
{
    public class ServiceBase : IServiceBase
    {
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    UnitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [Dependency]
        public IUnitOfWork UnitOfWork { protected get; set; }
    }
}
