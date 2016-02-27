using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class AgencyController : Controller
    {
        [Dependency]
        public IAgencyService AgencyService { get; set; }

        // GET: Agency
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

        public ActionResult Create(Agency agency)
        {
            if (ModelState.IsValid)
            {
                AgencyService.Add(announcement);

                return AgencyList();
            }

            return PartialView("_CreateAgency", agency);
        }
    }
}