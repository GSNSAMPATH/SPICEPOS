using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Business.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int>AddProductAsync(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }

        public async Task<List<ProductListDto>>GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }

        public Task<List<Product>> GetCategoriesByProductAsync(int categoryId)
        {
            return _productRepository.GetCategoriesByProductAsync(categoryId);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<List<CategoryDto>>GetCategoriesAsync()
        {
            return await _productRepository.GetCategoriesAsync();
        }

        //public async Task<List<BrandDto>>GetBrandsAsync()
        //{
        //    return await _productRepository.GetBrandsAsync();
        //}

        public async Task<List<UnitDto>>GetUnitsAsync()
        {
            return await _productRepository.GetUnitsAsync();
        }
        //public async Task<List<SupplierDto>> GetSupplierAsync()
        //{
        //    return await _productRepository.GetSupplierAsync();
        //}
    }
}