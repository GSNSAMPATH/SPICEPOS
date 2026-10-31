using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;

namespace HardwarePOS.Business.Services
{
    public class InventoryService
    {
        private readonly InventoryRepository
            _inventoryRepository;

        public InventoryService(InventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }


        public async Task<IEnumerable<InventorySummaryDto>>GetCurrentStockAsync()
        {
            return await _inventoryRepository.GetCurrentStockAsync();
        }


        public async Task<IEnumerable<StockTransactionDto>>GetStockInAsync(DateTime staringdate, DateTime enddate)
        {
            return await _inventoryRepository.GetStockInAsync(staringdate, enddate);
        }


        public async Task<IEnumerable<StockTransactionDto>>GetStockOutAsync(DateTime staringdate, DateTime enddate)
        {
            return await _inventoryRepository.GetStockOutAsync(staringdate, enddate);
        }

        public async Task<IEnumerable<StockTransactionDto>>GetLedgerAsync(DateTime staringdate, DateTime enddat)
        {
            return await _inventoryRepository.GetLedgerAsync(staringdate, enddat);
        }


        public async Task<InventoryStatsDto>GetInventoryStatsAsync()
        {
            return await _inventoryRepository.GetInventoryStatsAsync();
        }

        public async Task<IEnumerable<string>>GetCategoriesAsync()
        {
            return await _inventoryRepository.GetCategoriesAsync();
        }

        public async Task<decimal> GetAvailableStockAsync(int productId)
        {
            return await _inventoryRepository.GetAvailableStockAsync(productId);
        }
    }
}