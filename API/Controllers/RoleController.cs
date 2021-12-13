using System.Collections.Generic;
using System.Threading.Tasks;
using API.Helper;
using AutoMapper;
using Core.Entities.Identity;
using Dtos.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class RoleController : BaseController
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        public RoleController(RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _mapper = mapper;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<IdentityRole>>> GetAll()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return Ok(_mapper.Map<IReadOnlyList<RoleDto>>(roles));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if(role == null) return BadRequest(new ApiResponse(404,"Khong tim thay Role"));
            await _roleManager.DeleteAsync(role);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<IdentityRole>> Create(RoleDto roleDto)
        {
            var role = new IdentityRole(){Name = roleDto.Name};
            await _roleManager.CreateAsync(role);
            return Ok(_mapper.Map<RoleDto>(role));
        }
}
}