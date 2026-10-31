using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;


namespace HardwarePOS.Business.Services
{
    public class UnitService
    {
        private readonly UnitRepository _unitRepository;

        public UnitService(UnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<int> AddUnitAsync(string unitName, string unitShortName)
        {
            if (string.IsNullOrWhiteSpace(unitName) || string.IsNullOrWhiteSpace(unitShortName))
            {
                throw new Exception("Unit name or Short Name is Los");
            }

            Unit unit = new()
            {
                UnitName = unitName,
                UnitCode = unitShortName,
      
            };

            return await _unitRepository.AddUnitAsync(unit);
        }

        public async Task<List<Unit>> GetAllAsync()
        {
            return await _unitRepository.GetAllAsync();
        }
    }
}
