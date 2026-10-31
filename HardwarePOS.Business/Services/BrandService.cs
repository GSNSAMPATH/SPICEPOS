using HardwarePOS.Models.Entities;
using HardwarePOS.Data.Repositories;

namespace HardwarePOS.Business.Services
{
    public class BrandService
    {
        private readonly BrandRepository _brandRepository;

        public BrandService(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<int> AddBrandAsync(string brandName)
        {
            if (string.IsNullOrWhiteSpace(brandName))
            {
                throw new Exception("Category name required");
            }

            Brand brand = new()
            {
                BrandName = brandName,
                IsActive = true
            };

            return await _brandRepository.AddBrandAsync(brand);
        }
    }
}
