using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services.Contracts;

namespace ItAcademy.PropertyCenter.Services
{
    public class AgencyService : ServiceBase, IAgencyService
    {
        public ICollection<Agency> GetAll()
        {
            return UnitOfWork.Agencies.GetAll();
        }
    }
}
