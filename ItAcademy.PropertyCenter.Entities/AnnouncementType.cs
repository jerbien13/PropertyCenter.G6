using System.Collections.Generic;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Entities
{
    public class AnnouncementType : EntityBase, IDeletable
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public bool Deleted { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
