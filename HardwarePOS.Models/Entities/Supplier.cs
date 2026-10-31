namespace HardwarePOS.Models.Entities
{
    public class Supplier
    {
        public int supplierId { get; set; }
        //public int supplierCode { get; set; }
        public string SupplierName { get; set; } = string.Empty;
        public string SupplierPhone { get; set;} = string.Empty;
        public string SupplierEmail { get; set;} = string.Empty;
        public string SupplierAddress { get; set;} = string.Empty;
        public bool IsActive { get; set; }



    }
}
