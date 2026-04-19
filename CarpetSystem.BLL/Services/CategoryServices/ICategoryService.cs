
namespace CarpetSystem.BLL.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDtoPr>> GetAllCategoryAsync(bool asNoTracking = true);

        Task<CategoryDtoPr> GetCategoryById(int id);

        Task<bool> AddCategoryAsync(CategoryAddDto category);

        Task<bool> DeleteCategoryAsync(int id);
        Task<bool> UpdateCategoryasync(int id);


    }
}
