using CarpetSystem.DAL.Model;
using CarpetSystem.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.BLL.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unit,IMapper mapper)
        {
            _unit=unit;
            _mapper=mapper;

        }
        public async Task<bool> AddCategoryAsync(CategoryAddDto category)
        {

            var cat = _mapper.Map<Category>(category);
            _unit.Categories.AddAsync(cat);
            var result=await _unit.SaveAsync();
            return result > 0 ? true : false;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var cat =await _unit.Categories.GetByIdAsync(id);

            if(cat is null)
                return false;

            _unit.Categories.Delete(cat);

            var result= await _unit.SaveAsync();
            return result > 0 ? true : false;

            

        }

        public async Task<IEnumerable<CategoryDtoPr>> GetAllCategoryAsync(bool asNoTracking = true)
        {
            var cats = await _unit.Categories.GetAllAsync();
            var result = _mapper.Map<IEnumerable<CategoryDtoPr>>(cats);

            return result;


        }

        public async Task<CategoryDtoPr> GetCategoryById(int id)
        {
            var cat = await _unit.Categories.GetByIdAsync(id);

            var result =  _mapper.Map<CategoryDtoPr>(cat);

            return result;
        }

        public async Task<bool> UpdateCategoryasync(int id)
        {
           var cat =await _unit.Categories.GetByIdAsync(id);

            if (cat is null)
                return false;


            _unit.Categories.Update(cat);
           var result=await _unit.SaveAsync();

            return result > 0 ? true : false;


        }
    }
}
