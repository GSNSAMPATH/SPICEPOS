using HardwarePOS.Data.Repositories;


namespace HardwarePOS.Business.Services
{
    public class SalesService
    {
        private readonly SalesRepository _SalesRepository;

        public SalesService(SalesRepository SalesRepository)
        {
            _SalesRepository = SalesRepository;
        }

        public async Task<int> GetDaySesstion()
        {
            return await _SalesRepository.GetDaySesstion();
        }

        public async Task<string> GetNextSalesNoAsync()
        {
            return await _SalesRepository.GetNextSalesNoAsync();
        }

        public async Task<int> SaveSalesAsync(SalesHeader sales)
        {
            return await _SalesRepository.SaveSalesAsync(sales);
        }
    }
}
