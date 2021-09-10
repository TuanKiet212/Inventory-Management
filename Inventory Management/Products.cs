using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Product
    {
        public int ProductCode { get; set; }

        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public int Amount { get; set; }

        public string ConditionOfProduct { get; set; }

        public double Price { get; set; }

        private Product() 
        { 

        }

        public Product(int productCode, string productName, string productType, int amount, string conditionOfProduct, double price)
        {
            ProductCode = productCode;
            ProductName = productName;
            ProductType = productType;
            Amount = amount;
            ConditionOfProduct = conditionOfProduct;
            Price = price;
        }

        public override string ToString()
        {
            string result = $"\t >>Product Code: {ProductCode} | Product Name: {ProductName} | ProductType: {ProductType} | Amount: {Amount} | Condition Of Product: {ConditionOfProduct} | Price: {Price}\n";
            return result;
        }
    }
}

