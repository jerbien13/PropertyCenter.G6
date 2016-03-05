using ItAcademy.PropertyCenter.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItAcademy.PropertyCenter.Entities
{
    [Table("UserProfile")]
    public class UserProfile : EntityBase
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
