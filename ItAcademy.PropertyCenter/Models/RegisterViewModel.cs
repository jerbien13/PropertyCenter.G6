using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ItAcademy.PropertyCenter.Models
{
    public class RegisterViewModel
    {
        [Required,
        Remote("IsUserAvailable", "Account")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage ="Le mot de passe doit être conforme")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}