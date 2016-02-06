using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Domain;
using ItAcademy.PropertyCenter.Entities;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ICollection<Announcement> announcements;

            using (PropertyCenterDbContext db = new PropertyCenterDbContext())
            {
                announcements = db.Announcements.ToList();
            }

            ViewBag.Message = "Your application description page.";

            return View(announcements);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}