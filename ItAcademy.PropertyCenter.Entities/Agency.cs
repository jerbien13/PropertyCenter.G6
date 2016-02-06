
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Entities
{
    public class Agency : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText), StringLength(1024)]
        public string Description { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
