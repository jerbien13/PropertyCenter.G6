using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using ItAcademy.PropertyCenter.Controllers;
using ItAcademy.PropertyCenter.Domain;
using ItAcademy.PropertyCenter.Repository;
using ItAcademy.PropertyCenter.Services;

namespace ItAcademy.PropertyCenter
{
    public class CustomControllerFactory : IControllerFactory
    {
        private IAnnouncementService announcementService = new AnnouncementService();

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Home" && requestContext.RouteData.Values["action"] == "Index")
            {
                announcementService.UnitOfWork = new UnitOfWork(new PropertyCenterDbContext());

                var announcementController = Activator.CreateInstance<AnnouncementController>();
                announcementController.AnnouncementService = announcementService;

                return announcementController;
            }
            else
            {
                announcementService.UnitOfWork = new UnitOfWork(new PropertyCenterDbContext());

                if (controllerName == "Announcement")
                {
                    var controller = Activator.CreateInstance<AnnouncementController>();
                    controller.AnnouncementService = announcementService;
                    return controller;
                }
                else 
                {
                    var controller = Activator.CreateInstance<HomeController>();
                    controller.AnnouncementService = announcementService;

                    return controller;
                }
            }
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {

        }
    }
}