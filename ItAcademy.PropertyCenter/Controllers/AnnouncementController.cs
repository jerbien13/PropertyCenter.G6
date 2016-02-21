using System.Net;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class AnnouncementController : Controller
    {
        [Dependency]
        public IAnnouncementService AnnouncementService { private get; set; }
        [Dependency]
        public IAgencyService AgencyService { private get; set; }
        [Dependency]
        public IAnnouncementTypeService AnnouncementTypeService { private get; set; }

        public ActionResult Index()
        {
            var announcements = AnnouncementService.GetAnnouncements();

            return View(announcements);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var announcement = new Announcement();

            InitializeViewBagForAnnouncement();

            return View(announcement);
        }

        private void InitializeViewBagForAnnouncement()
        {
            var agencies = AgencyService.GetAll();
            var announcementTypes = AnnouncementTypeService.GetAll();

            ViewBag.Agencies = new SelectList(agencies, "Id", "Name");
            ViewBag.AnnouncementTypes = new SelectList(announcementTypes, "Id", "Name");
        }

        [HttpPost]
        public ActionResult Create(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                AnnouncementService.AddAnnouncement(announcement);

                return RedirectToAction("Index");
            }

            InitializeViewBagForAnnouncement();

            return View(announcement);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var announcement = AnnouncementService.GetAnnouncementById(id);

            InitializeViewBagForAnnouncement();

            return View(announcement);
        }

        [HttpPost]
        public ActionResult Edit(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                AnnouncementService.UpdateAnnouncement(announcement);

                return RedirectToAction("Index");
            }

            InitializeViewBagForAnnouncement();

            return View(announcement);
        }
    }
}