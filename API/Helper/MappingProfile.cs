using AutoMapper;
using Core.Entities.Identity;
using Core.Entities.Store;
using Dtos.Identity;
using Dtos.Store;
using Microsoft.AspNetCore.Identity;

namespace API.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<AppUser,UserDto>();
            CreateMap<IdentityRole,RoleDto>();
        }
    }
}