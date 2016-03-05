
namespace ItAcademy.PropertyCenter.Services
{
    public interface IAuthenticationService
    {
        bool Login(string userName, string password, bool rememberMe);

        void LogOut();

        string CreateUserAndAccount(string userName, string password, string firstName, string lastName);
    }
}
