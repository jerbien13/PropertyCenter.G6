using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public interface IAgencyService : IServiceBase
    {
        ICollection<Agency> GetAll();
    }
}
