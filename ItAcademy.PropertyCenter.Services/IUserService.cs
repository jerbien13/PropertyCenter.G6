using ItAcademy.PropertyCenter.Entities;

namespace ItAcademy.PropertyCenter.Services
{
    public interface IUserService
    {
        bool UserExists(string userName);

        bool AddUser(UserProfile user);
    }
}
