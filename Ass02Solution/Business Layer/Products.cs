using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02Solution.Business_Layer
{
    public class Products
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string Weight { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public Products()
        {
        }

        public Products(int productId, int categoryId, string productName, string weight, decimal unitPrice, int unitsInStock)
        {
            ProductId = productId;
            CategoryId = categoryId;
            ProductName = productName;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
    }
}
