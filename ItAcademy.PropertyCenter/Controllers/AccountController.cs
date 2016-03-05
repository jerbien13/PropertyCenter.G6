using ItAcademy.PropertyCenter.Core;
using ItAcademy.PropertyCenter.Models;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace ItAcademy.PropertyCenter.Controllers
{
    [Authorize]
    public class AccountController : LocalizableController
    {
        [Dependency]
        public IAuthenticationService AuthenticationService { private get; set; }

        [Dependency]
        public IUserService UserService { private get; set; }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid && AuthenticationService.Login(model.UserName, model.Password, model.RememberMe))
            {
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Erreur lors de l'authentification");
            return View(model);
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            AuthenticationService.LogOut();

            return RedirectToAction("Index", "Home");
        }


        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    AuthenticationService.CreateUserAndAccount(model.UserName, model.Password, model.FirstName, model.LastName);
                    AuthenticationService.Login(model.UserName, model.Password, false);
                    return RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        [AllowAnonymous]
        public JsonResult IsUserAvailable(string username)
        {
            if (!UserService.UserExists(username))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            string suggestedUserName = string.Format("{0} is not available.", username);

            for (int i = 0; i < 50; i++)
            {
                string altCandiate = username + i.ToString();

                if (!UserService.UserExists(altCandiate))
                {
                    suggestedUserName = string.Format("{0} is not available. Try {1}",
                        username, altCandiate);
                    break;
                }
            }

            return Json(suggestedUserName, JsonRequestBehavior.AllowGet);
        }


        private string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
    }
}