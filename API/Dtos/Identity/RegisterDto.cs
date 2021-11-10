namespace API.Dtos.Identity
{
    public class RegisterDto
    {
        public string Name {set; get;}
        public string Password {set;get;}
        public string ConfirmPassword {set; get;}
        public string Email {set; get;}
    }
}