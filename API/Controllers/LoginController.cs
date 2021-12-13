using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Helper;
using Core.Entities.Identity;
using Core.Interfaces.IServices;
using Dtos.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class LoginController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<SignInDto>> GetUser()
        {
            var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;
            if(email == null) return BadRequest();
            var user =await _userManager.FindByEmailAsync(email);
            return Ok( new SignInDto {
                Name = user.Name,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var user = new AppUser()
            {
                UserName = registerDto.Email,
                Name = registerDto.Name,
                Email = registerDto.Email,
            };
            var rs = await _userManager.CreateAsync(user, registerDto.Password);
            if (!rs.Succeeded) return BadRequest(new ApiResponse(400));
            // await _userManager.AddToRoleAsync(user,"User");
            return Ok(new SignInDto{
                Name = user.Name,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });
        }
        [HttpPost]
        public async Task<ActionResult> Login([FromBody]LoginDto loginDto)
        {
            var user =await _userManager.FindByEmailAsync(loginDto.Email);
            if(user == null) return BadRequest();
            var rs = await _signInManager.PasswordSignInAsync(user,loginDto.Password,loginDto.Remember,true);
            if (!rs.Succeeded) return BadRequest();
            return Ok(new SignInDto{
                Name = user.Name,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });
        }

        [HttpGet("Logout")]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}