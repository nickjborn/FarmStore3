﻿using System.Collections.Generic;

namespace FarmStore3.Models
{
    public class ProductViewModel
    {
        //public IEnumerable<Products> Products { get; set; }
        public IEnumerable<ProductListItemViewModel> ListOfProducts { get; set; }

    }
}
