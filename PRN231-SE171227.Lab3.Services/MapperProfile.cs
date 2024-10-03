using AutoMapper;
using Repository.entities;
using Services.BusinessObject;

namespace Services;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Repository.entities.Product, BusinessObject.ProductResponse>();
        CreateMap<Product, Response.ProductDetailResponse>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ReverseMap();
    }
}