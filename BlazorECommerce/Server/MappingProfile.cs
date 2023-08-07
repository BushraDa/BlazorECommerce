using AutoMapper;
using BlazorECommerce.Server.Dtos;
using BlazorECommerce.Shared;

namespace BlazorECommerce.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductAddDto, Product>();
        }
    }
}
