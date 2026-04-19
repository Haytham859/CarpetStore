using CarpetSystem.BLL.DTOs.ProductDtos;
using CarpetSystem.DAL.Model;
using CarpetSystem.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.BLL.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public async Task<bool> AddProductAsync(AddProductDtos product)
        {
            var productMapping = _mapper.Map<Product>(product);

             await _unitOfWork.Products.AddAsync(productMapping);

            var check= await _unitOfWork.SaveAsync();

            return check>0 ? true:false;

        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);

            if (product == null)
                return false;

            _unitOfWork.Products.Delete(product);

            await _unitOfWork.SaveAsync(); 

            return true;


        }

        public async Task<IEnumerable<ProductDtoPr>> GetAllProductsAsync(bool AsNoTracking = true)
        {

            var products=await _unitOfWork.Products.GetAllAsync(AsNoTracking);

            var result = _mapper.Map<IEnumerable<ProductDtoPr>>(products);

            return result;

            
        }

        public async Task<ProductDtoPr> GetProductByIdAsync(int id)
        {

            var product = await _unitOfWork.Products.GetByIdAsync(id);

            var result = _mapper.Map<ProductDtoPr>(product);
            return result;
        }

        public async Task<bool> UpdateProduct(int id)
        {

            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product is null)
                return false;
            _unitOfWork.Products.Update(product);
            _unitOfWork.SaveAsync();
            return true;
        }
    }
}
