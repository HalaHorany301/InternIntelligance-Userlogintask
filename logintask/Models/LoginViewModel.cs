using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace logintask.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Eamil is required.")]
        [MaxLength(25, ErrorMessage = "Max 25 characters is allowed.")]
        [DisplayName("Username Or Password")]
        public string UserNameOrEmail { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Max 25 or min 5 characters is allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
