
using System.ComponentModel.DataAnnotations;
using ItAcademy.PropertyCenter.Entities.Core;

namespace ItAcademy.PropertyCenter.Entities
{
    public class Announcement : EntityBase
    {
        [Required]
        public string Reference { get; set; }

        [Required, StringLength(256)]
        public string Title { get; set; }

        [DataType(DataType.MultilineText), StringLength(1024)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Surface { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Display(Name = "Agency")]
        public int AgencyId { get; set; }

        public virtual Agency Agency { get; set; }

        [Display(Name = "Announcement type")]
        public int AnnouncementTypeId { get; set; }

        public virtual AnnouncementType AnnouncementType { get; set; }
    }
}
