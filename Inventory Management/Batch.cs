using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    class MenuOptions
    {
        public const int EMPTY = 0;
        public const int ADD_PRODUCT_INFOR = 1;
        public const int REMOVE_PRODUCT_BY_CODE = 2;
        public const int UPDATE_PRODUCT_BY_CODE = 3;
        public const int PRINT_ALL_PRODUCT_INFOR = 4;
        public const int SEARCH_PRODUCT_BY_CODE = 5;
        public const int SEARCH_PRODUCT_BY_PRICE = 6;
        public const int EXIT_PROGRAM = 7;
    }

    public class Batch 
    {
        private List<Product> product;

        private Batch()  { }

        public Batch(string name)
        {
            product = new List<Product>();
        }

        public void AddProduct(Product newProduct)
        {
            product.Add(newProduct);
        }

        public bool CheckProductCode(int productCode)
        {
            Product ProductInBatch = product.FirstOrDefault(s => s.ProductCode.Equals(productCode));
            if (ProductInBatch != null)
            {
                return true;
            }
            return false;
        }

        public bool RemoveProductByCode(int productCode)
        {
            Product ProductInBatch = product.FirstOrDefault(s => s.ProductCode.Equals(productCode));
            if (ProductInBatch != null)
            {
                product.Remove(ProductInBatch);
                return true;
            }
            return false;
        }

        public bool UpdateProductByCode(int productCode, string productName, string productType, int amount, string conditionOfProduct, double price)
        {
            Product productInBatch = product.FirstOrDefault(s => s.ProductCode.Equals(productCode));

            if (productInBatch == null) return false;
            productInBatch.ProductName = productName;
            productInBatch.ProductType = productType;
            productInBatch.Amount = amount;
            productInBatch.ConditionOfProduct = conditionOfProduct;
            productInBatch.Price = price;
            return true;
        }
        public string GetAllProductInfor()
        { 
            string result = " ";
            foreach (var s in product)
            {
                result = result + s.ToString();
            }
            return result;
        }

        public Product GetProductByCode(int productCode)
        {
            Product productInBatch = product.FirstOrDefault(std => std.ProductCode.Equals(productCode));
            if (productInBatch == null)
            {
                return null;
            }
            return productInBatch;
        }

        public string GetProductByPriceRange(double price)
        {
            string range = " ";
            Console.Write("Enter the lowest price                      : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the highest price                     : ");
            double y = double.Parse(Console.ReadLine());
            foreach (var s in product.Where(s => x <= s.Price && s.Price <= y))
            {
                range = range + s.ToString();
            }
            return range;
        }
    }
}

