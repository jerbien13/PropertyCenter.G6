using ItAcademy.PropertyCenter.Services.Contracts;
using System;
using ItAcademy.PropertyCenter.Entities;
using WebMatrix.WebData;
using System.Linq;

namespace ItAcademy.PropertyCenter.Services
{
    public class UserService : ServiceBase, IUserService
    {
        public bool AddUser(UserProfile user)
        {
            try
            {
                UnitOfWork.UserProfiles.Insert(user);

                UnitOfWork.Commit();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UserExists(string userName)
        {
            return UnitOfWork.UserProfiles.Query(u => u.UserName == userName).Any();
        }
    }
}
