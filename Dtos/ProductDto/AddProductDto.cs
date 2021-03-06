﻿using ESShopReact.NetCore.Data;
using ESShopReact.NetCore.Dtos.Category;

namespace ESShopReact.NetCore.Dtos
{
    public class AddProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
        public int OrderedQuantity { get; set; }
        public decimal ListPrice { get; set; }
        public int CategoryID { get; set; }
        public GetCategoryDto Category { get; set; }
    }
}
