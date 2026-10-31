namespace HardwarePOS.Models.DTOs
{
    public class ProductListDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
            = string.Empty;

        public string CategoryName { get; set; }
            = string.Empty;
        public string UnitName { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal AveragePrice { get; set; }

        public decimal CurrentStock { get; set; }
    }
}