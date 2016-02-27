using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public interface IAgencyRepository : IReadOnlyRepository<Agency>, IPersistRepository<Agency>
    {
    }
}
