namespace Dtos.Identity
{
    public class LoginDto
    {
        public string Email { set; get; }
        public string Password { set; get; }
        public bool Remember { set; get; }
    }
}