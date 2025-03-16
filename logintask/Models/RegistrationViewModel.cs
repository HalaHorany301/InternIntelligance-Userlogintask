using System.ComponentModel.DataAnnotations;

namespace logintask.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(25, ErrorMessage = "Max 25 characters is allowed.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(25, ErrorMessage = "Max 25 characters is allowed.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters is allowed.")]
        //[EmailAddress(ErrorMessage ="Please enter valid Email.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(25, ErrorMessage = "Max 25 characters is allowed.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(25,MinimumLength =5, ErrorMessage = "Max 25 or min 5 characters is allowed.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Please confiem your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
