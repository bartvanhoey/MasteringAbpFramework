using AutoMapper;
using ProductManagement.Products;

namespace ProductManagement.Blazor;

public class ProductManagementBlazorAutoMapperProfile : Profile
{
    public ProductManagementBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.

        CreateMap<ProductDto, CreateUpdateProductDto>();

    }
}
