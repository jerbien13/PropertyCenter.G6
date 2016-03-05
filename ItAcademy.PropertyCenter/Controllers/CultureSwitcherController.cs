using ItAcademy.PropertyCenter.Core;
using ItAcademy.PropertyCenter.Models;
using System.Web.Mvc;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class CultureSwitcherController : Controller
    {
        [AllowAnonymous]
        public ActionResult SetCulture(CultureViewModel cultureViewModel)
        {
            var currentCulture = CultureHelper.GetImplementedCulture(cultureViewModel.Culture);

            Session["culture"] = currentCulture;

            return RedirectToAction(cultureViewModel.ReturnAction, cultureViewModel.ReturnController);
        }
    }
}