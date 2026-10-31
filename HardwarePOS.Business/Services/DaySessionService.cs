using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;

namespace HardwarePOS.Business.Services
{
    public class DaySessionService
    {
        private readonly DaySessionRepository _daySessionRepository;

        public DaySessionService(DaySessionRepository daySessionRepository)
        {
            _daySessionRepository = daySessionRepository;
        }

        public async Task<DaySessionDto?>GetOpenSessionAsync()
        {
            return await _daySessionRepository.GetOpenSessionAsync();
        }

        // ==========================================
        // CHECK DAY OPEN
        // ==========================================

        public async Task<bool>
            IsDayOpenAsync()
        {
            return await
                _daySessionRepository
                    .IsDayOpenAsync();
        }

        // ==========================================
        // START DAY
        // ==========================================

        public async Task<int> StartDayAsync(
            decimal openingCash,
            int userId)
        {
            if (openingCash < 0)
            {
                throw new ArgumentException(
                    "Opening cash cannot be negative.");
            }

            bool isOpen =
                await _daySessionRepository
                    .IsDayOpenAsync();

            if (isOpen)
            {
                throw new InvalidOperationException(
                    "A business day is already open.");
            }

            return await
                _daySessionRepository
                    .StartDayAsync(
                        openingCash,
                        userId);
        }

        // ==========================================
        // CLOSING SUMMARY
        // ==========================================

        public async Task<DayClosingSummaryDto>GetClosingSummaryAsync(int daySessionId)
        {
            return await _daySessionRepository.GetClosingSummaryAsync(daySessionId);
        }

        // ==========================================
        // CLOSE DAY
        // ==========================================

        public async Task CloseDayAsync(
            int daySessionId,
            decimal actualCash,
            int userId)
        {
            if (actualCash < 0)
            {
                throw new ArgumentException(
                    "Actual cash cannot be negative.");
            }

            await _daySessionRepository
                .CloseDayAsync(
                    daySessionId,
                    actualCash,
                    userId);
        }
    }
}