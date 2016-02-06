using System;
using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;

namespace ItAcademy.PropertyCenter.Domain
{
    public class PropertyCenterDbInitializer : CreateDatabaseIfNotExists<PropertyCenterDbContext>
    {
        protected override void Seed(PropertyCenterDbContext context)
        {
            AnnouncementType announcementType = new AnnouncementType()
            {
                Name = "Vente Terrain", Code = "TR"
            };

            AnnouncementType announcementType1 = new AnnouncementType()
            {
                Name = "Location Maison",
                Code = "LM"
            };

            AnnouncementType announcementType2 = new AnnouncementType()
            {
                Name = "Location Studio",
                Code = "LM"
            };

            context.AnnouncementTypes.Add(announcementType);
            context.AnnouncementTypes.Add(announcementType1);
            context.AnnouncementTypes.Add(announcementType2);

            Agency agency1 = new Agency()
            {
                Name = "Agence Tunis", Description = "Description agence tunis"
            };

            Agency agency2 = new Agency()
            {
                Name = "Agence Bizerte",
                Description = "Description agence bizerte"
            };

            Agency agency3 = new Agency()
            {
                Name = "Agence Ariana",
                Description = "Description agence ariana"
            };

            context.Agencies.Add(agency1);
            context.Agencies.Add(agency2);
            context.Agencies.Add(agency3);

            Announcement announcement = new Announcement()
            {
                Agency = agency1,
                AnnouncementType = announcementType,
                Title = "Terrain à vendre TEST",
                Description = "description terrain",
                Price = 10000000,
                Reference = DateTime.Now.ToLongDateString(),
                Surface = 400
            };

            Announcement announcement2 = new Announcement()
            {
                Agency = agency2,
                AnnouncementType = announcementType1,
                Title = "Location maisson sur plage",
                Description = "description maison",
                Price = 1600,
                Reference = DateTime.Now.ToLongDateString(),
                Surface = 100
            };

            Announcement announcement3 = new Announcement()
            {
                Agency = agency2,
                AnnouncementType = announcementType2,
                Title = "Vente maison",
                Description = "description maison",
                Price = 10000000,
                Reference = DateTime.Now.ToLongDateString(),
                Surface = 250
            };

            context.Announcements.Add(announcement);
            context.Announcements.Add(announcement2);
            context.Announcements.Add(announcement3);

            context.SaveChanges();
        }
    }
}
