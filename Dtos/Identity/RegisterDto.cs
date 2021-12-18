using System.ComponentModel.DataAnnotations;

namespace Dtos.Identity
{
    public class RegisterDto
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string Password { set; get; }
        [Compare("Password", ErrorMessage ="Password is not match")]
        public string ConfirmPassword { set; get; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Email is not format")]
        public string Email { set; get; }
    }
}