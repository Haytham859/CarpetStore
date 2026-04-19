
using CarpetSystem.BLL.DTOs.ProductDtos;
using CarpetSystem.DAL.Model;

namespace CarpetSystem.BLL.Mapping
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<AddProductDtos, Product>().ReverseMap();


            CreateMap<Product, ProductDtoPr>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Category, CategoryAddDto>().ReverseMap();

            CreateMap<Category, CategoryDtoPr>().ReverseMap();
        }
    }
}
