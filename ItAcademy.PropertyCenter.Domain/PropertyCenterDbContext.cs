using System.Data.Entity;
using ItAcademy.PropertyCenter.Entities;

namespace ItAcademy.PropertyCenter.Domain
{
    public class PropertyCenterDbContext : DbContext
    {
        public const string ConnectionStringName = "PropertyCenterDbContext";

        public PropertyCenterDbContext() : base(ConnectionStringName)
        {
            
        }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<AnnouncementType> AnnouncementTypes { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
