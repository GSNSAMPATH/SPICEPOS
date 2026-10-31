using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;


namespace HardwarePOS.Business.Services
{
    public class SupplierServices
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierServices(SupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>>GetAllAsync()
        {
            return await _supplierRepository.GetAllAsync();
        }

        public async Task<int> AddSupplierAsync(string supplierName, string supplierPhone, string supplierEmail, string supplierAddress)
        {
            if (string.IsNullOrWhiteSpace(supplierName))
            {
                throw new Exception("Category name required");
            }

            Supplier supplier = new()
            {
                SupplierName = supplierName,
                SupplierPhone = supplierPhone,
                SupplierEmail = supplierEmail,
                SupplierAddress = supplierAddress
            };

            return await _supplierRepository.AddSupplierAsync(supplier);
        }
    }
}

