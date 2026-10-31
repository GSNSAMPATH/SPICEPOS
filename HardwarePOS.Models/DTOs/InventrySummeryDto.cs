using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwarePOS.Models.DTOs
{
    public class InventorySummaryDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public string CategoryName { get; set; } = "";
        public string UnitName { get; set; } = "";
        public string UnitCode { get; set; } = "";
        public decimal GrossWeight { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal TareWeight { get; set; }
        public decimal WetWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
