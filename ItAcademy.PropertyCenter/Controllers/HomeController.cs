﻿using System;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Core.Logging;
using ItAcademy.PropertyCenter.Filters;
using ItAcademy.PropertyCenter.Models;
using ItAcademy.PropertyCenter.Services;
using Microsoft.Practices.Unity;

namespace ItAcademy.PropertyCenter.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public IAnnouncementService AnnouncementService { private get; set; }

        protected override void OnException(ExceptionContext filterContext)
        {
            SiteEventSource.Log.PageError(filterContext.Exception.GetBaseException().Message);

            base.OnException(filterContext);
        }

        public ActionResult Index()
        {
            return View();
        }

        //[HandleError(ExceptionType = typeof(ArgumentNullException), View = "AboutError")]
        public ActionResult About()
        {
            //throw new NullReferenceException("Ceci est un message de test");
            ViewBag.Message = "Your application description page.";

            var announcements = AnnouncementService.GetAnnouncements();

            return View(announcements);
        }

        public ActionResult Contact()
        {
            //throw new ArgumentNullException();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}