using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public interface IUserProfileRepository : IReadOnlyRepository<UserProfile>, IPersistRepository<UserProfile>
    {
    }
}
