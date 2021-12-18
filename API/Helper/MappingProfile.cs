using AutoMapper;
using Core.Entities.Identity;
using Core.Entities.Store;
using Dtos.Identity;
using Dtos.Store;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace API.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<AppUser,UserDto>();
            CreateMap<IdentityRole,RoleDto>();
            CreateMap<Product, ProductDto>()
                .ForMember(des => des.ProductImages, otp => otp.MapFrom<ProductImageResolver>());
        }
        public class ProductImageResolver : IValueResolver<Product, ProductDto,List<string>>
        {
            public List<string> Resolve(Product source, ProductDto destination, List<string> destMember, ResolutionContext context)
            {
                return source.ProductImages.Select(x => x.Url).ToList();
            }
        }
    }
}