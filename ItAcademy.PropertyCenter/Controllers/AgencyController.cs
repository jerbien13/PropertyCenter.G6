using System.Web.Mvc;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;
using ItAcademy.PropertyCenter.Core;

namespace ItAcademy.PropertyCenter.Controllers
{
    [Authorize(Roles = "Administrator,Guest")]
    public class AgencyController : LocalizableController
    {
        [Dependency]
        public IAgencyService AgencyService { get; set; }

        [OutputCache(CacheProfile = "listProfile")]
        public ActionResult Index()
        {
            var agencies = AgencyService.GetAll();

            return View(agencies);
        }

        public ActionResult AgencyList()
        {
            var agencies = AgencyService.GetAll();

            return PartialView("_AgencyList", agencies);
        }

        public ActionResult Create()
        {
            var agency = new Agency();

            return PartialView("_CreateAgency", agency);
        }

        [HttpPost]
        public ActionResult Create(Agency agency)
        {
            if (ModelState.IsValid)
            {
                AgencyService.AddAgency(agency);

                return AgencyList();
            }

            return PartialView("_CreateAgency", agency);
        }
    }
}