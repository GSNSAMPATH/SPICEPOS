using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Business.Services
{
    public class CashService
    {
        private readonly CashRepository _cashrepository;

        public CashService(CashRepository cashrepository)
        {
            _cashrepository = cashrepository;
        }

        public async Task<int> SaveAsync(CashTransaction cash)
        {
            return await _cashrepository.SaveAsync(cash);
        }

        public async Task<int> GetDaySesstion()
        {
            return await _cashrepository.GetDaySesstion();
        }

        public async Task<decimal> GetCurrentCashAsync(int daySessionId)
        {
            return await _cashrepository.GetCurrentCashAsync(daySessionId);
        }

        public async Task<List<CashTransaction>> GetCashFlowAsync(string? transactionType, DateTime? from, DateTime? to, string? search)
        {
            return await _cashrepository.GetCashFlowAsync(transactionType, from, to, search);
        }
    }
}