using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Business.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository
            _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> AddCategoryAsync(string categoryName, string categorydescription)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new Exception("Category name required");
            }

            ProductCategory category = new()
            {
                CategoryName = categoryName,
            };

            return await _categoryRepository.AddCategoryAsync(category);
        }
    }
}