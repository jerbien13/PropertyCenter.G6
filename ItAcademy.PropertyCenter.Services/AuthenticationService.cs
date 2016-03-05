using System;
using System.Web.Security;
using WebMatrix.WebData;

namespace ItAcademy.PropertyCenter.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public string CreateUserAndAccount(string userName, string password, string firstName, string lastName)
        {
            var additionalInformation = new
            {
                FirstName = firstName,
                LastName = lastName
            };

            WebSecurity.CreateUserAndAccount(userName, password, additionalInformation);

            var roleManager = (SimpleRoleProvider)Roles.Provider;

            roleManager.AddUsersToRoles(new[] { userName }, new[] { "Guest" });

            return userName;
        }

        public bool Login(string userName, string password, bool rememberMe)
        {
            return WebSecurity.Login(userName, password, persistCookie: rememberMe);
        }

        public void LogOut()
        {
            WebSecurity.Logout();
        }
    }
}
