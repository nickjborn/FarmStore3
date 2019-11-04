using System.Collections.Generic;

namespace FarmStore3.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public int ProduceID { get; set; }
        public string ProduceName { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool InSeason { get; set; }

    }
}
