using CarpetSystem.BLL.DTOs.ProductDtos;
using CarpetSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.BLL.Services.ProductServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDtoPr>> GetAllProductsAsync(bool AsNoTracking=true);
        Task<ProductDtoPr> GetProductByIdAsync(int id);
        Task<bool> AddProductAsync(AddProductDtos product);
        Task<bool> DeleteProduct(int id);

        Task<bool> UpdateProduct(int id);

    }
}
