using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;
using System.Data;

namespace HardwarePOS.Business.Services
{
    public class DashboardService
    {
        private readonly DashboardRepository
            _dashboardRepository;

        public DashboardService(
            DashboardRepository dashboardRepository)
        {
            _dashboardRepository =
                dashboardRepository;
        }

        public async Task<DashboardStatsDto>GetStatsAsync()
        {
            return await _dashboardRepository.GetDashboardStatsAsync();
        }

        public async Task<IEnumerable<InventorySummaryDto>> GetProductSummaryAsync()
        {
            return await _dashboardRepository.GetProductSummaryAsync();
        }
    }
}