using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ItAcademy.PropertyCenter.Services.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItAcademy.PropertyCenter;
using ItAcademy.PropertyCenter.Controllers;
using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Services;
using ItAcademy.PropertyCenter.Tests.Fakes;
using Moq;

namespace ItAcademy.PropertyCenter.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            IAnnouncementService announcemsntServiceStub = new StubIAnnouncementService()
            {
                GetAnnouncements = () =>
                {
                    return new List<Announcement>()
                    {
                        new Announcement() {Title = "announcement1"},
                        new Announcement() {Title = "announcement1"}
                    };
                }
            };

            controller.AnnouncementService = announcemsntServiceStub;
            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.AreEqual(typeof(List<Announcement>), result.Model.GetType());
            Assert.AreEqual(2, ((ICollection<Announcement>)result.Model).Count);
        }

        [TestMethod]
        public void About_Moq()
        {
            // Arrange
            var fakeAgengies = new List<Announcement>()
                    {
                        new Announcement() {Title = "announcement1"},
                        new Announcement() {Title = "announcement1"}
                    };

            HomeController controller = new HomeController();

            Mock<IAnnouncementService> announcemsntServiceMock = new Mock<IAnnouncementService>();

            announcemsntServiceMock.Setup(a => a.GetAnnouncements()).Returns(fakeAgengies);

            controller.AnnouncementService = announcemsntServiceMock.Object;
            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.AreEqual(typeof(List<Announcement>), result.Model.GetType());
            Assert.AreEqual(2, ((ICollection<Announcement>)result.Model).Count);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
