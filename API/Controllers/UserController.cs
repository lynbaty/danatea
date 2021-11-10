
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Identity;
using API.Helper;
using AutoMapper;
using Core.Entities.Identity;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<UserDto>>> GetAll()
        {
            await UpdateRoles();
            var users = await _userManager.Users.ToListAsync();
            return Ok(_mapper.Map<IReadOnlyList<UserDto>>(users));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetbyId(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null) return BadRequest(new ApiResponse(404,"User khong ton tai"));
            return Ok(_mapper.Map<UserDto>(user));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null) return BadRequest(new ApiResponse(404,"User khong ton tai"));
            await _userManager.DeleteAsync(user);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> Edit(UserDto userDto)
        {
            var user = await _userManager.FindByIdAsync(userDto.Id);
            if(user == null) return BadRequest(new ApiResponse(404,"User khong ton tai"));
            user.Name = userDto.Name;
            user.Role = userDto.Role;
            var recentRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
            if (recentRole!=null) await _userManager.RemoveFromRoleAsync(user,recentRole);
            if(!string.IsNullOrEmpty(userDto.Role))
            {
                await _userManager.AddToRoleAsync(user,userDto.Role);
            }
            await _userManager.UpdateAsync(user);
            return Ok();
        }
        
        private async Task UpdateRoles()
        {
            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                var recentRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
                user.Role = recentRole ?? "None";
            }
        }

    }
}