using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public class AgencyRepository : GenericRepository<Agency>, IAgencyRepository
    {
        public AgencyRepository(DbContext context) : base(context)
        {
        }
    }
}
