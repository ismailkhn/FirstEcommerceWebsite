using AutoMapper;
using Entities;
using Entities.DTOS;

namespace WebApi.DTOProfile
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDetailDto, Product>().ReverseMap().ForMember(
                dest => dest.CategoryName,
                opt => opt.MapFrom(c => c.Category.Name)

                )
                .ForMember(
                dest => dest.Pictures,
                opt => opt.MapFrom(c => c.ProductToPictures.Select(c => c.Picture.PhotoUrl).ToList())
                )
                .ForMember(
                dest => dest.CoverPhoto,
                opt => opt.MapFrom(c => c.CoverPhoto.PhotoUrl)
                );


            CreateMap<ProductListDTO,Product>().ReverseMap().ForMember(

                dest => dest.Pictures,
                opt => opt.MapFrom(c => c.ProductToPictures.Select(c => c.Picture.PhotoUrl).ToList())
                )
                .ForMember(
                dest => dest.CoverPhoto,
                opt => opt.MapFrom(c => c.CoverPhoto.PhotoUrl)
                );

            CreateMap<ProductCreateDTO, Product>().ReverseMap();

                
                
                
                
        }
    }
}
