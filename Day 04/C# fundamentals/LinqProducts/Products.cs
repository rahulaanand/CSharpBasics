using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProducts
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int UnitInStock { get; set; }

        public override string ToString()
        {
            return $"Product ID: {ProductId}, Name: {ProductName}, Description: {ProductDescription}, Units in Stock: {UnitInStock}";
        }
    }
}

