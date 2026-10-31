using HardwarePOS.Data.Repositories;


namespace HardwarePOS.Business.Services
{
    public class PurchaseService
    {
        private readonly PurchaseRepository _PurchaseRepository;

        public PurchaseService(PurchaseRepository productRepository)
        {
            _PurchaseRepository = productRepository;
        }

        public async Task<int> GetDaySesstion()
        {
            return await _PurchaseRepository.GetDaySesstion();
        }

        public async Task<string> GetNextPurchaseNoAsync()
        {
            return await _PurchaseRepository.GetNextPurchaseNoAsync();
        }

        public async Task<int> SavePurchaseAsync(PurchaseHeader purchase)
        {
            return await _PurchaseRepository.SavePurchaseAsync(purchase);
        }
    }
}
