using System.Web.Mvc;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public IAnnouncementService AnnouncementService { private get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var announcements = AnnouncementService.GetAnnouncements();

            return View(announcements);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}