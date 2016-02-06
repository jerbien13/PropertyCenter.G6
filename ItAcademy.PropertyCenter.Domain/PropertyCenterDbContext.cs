using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;

namespace ItAcademy.PropertyCenter.Domain
{
    public class PropertyCenterDbContext : DbContext
    {
        public PropertyCenterDbContext()
        {
            Database.SetInitializer(new PropertyCenterDbInitializer());
        }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<AnnouncementType> AnnouncementTypes { get; set; }
    }
}
