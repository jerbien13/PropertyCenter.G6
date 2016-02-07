using System;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Services.Contracts
{
    public interface IServiceBase : IDisposable
    {
        IUnitOfWork UnitOfWork { set; }
    }
}
