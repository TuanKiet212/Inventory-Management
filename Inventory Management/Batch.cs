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
        public const int PRINT_PRODUCT_INFOR_BY_CODE = 5;
        public const int PRINT_PRODUCT_INFOR_BY_PRICE = 6;
        public const int PRINT_PRODUCT_INFOR_BY_AMOUNT = 7;
        public const int EXIT_PROGRAM = 8;
    }

    public class Batch 
    {
        public static List<Product> _product;

        private Batch() 
        { 

        }

        public Batch(string name)
        {
            _product = new List<Product>();
        }

        public void AddProduct(int productCode, string productName, string productType, int amount, string conditionOfProduct, double price)
        {
            Product newProduct = new Product(productCode, productName, productType, amount, conditionOfProduct, price);
            _product.Add(newProduct);
        }

        public bool RemoveProductByCode(int productCode)
        {
            Product ProductInBatch = _product.FirstOrDefault(s => s.ProductCode.Equals(productCode));
            if (ProductInBatch != null)
            {
                _product.Remove(ProductInBatch);
                return true;
            }
            return false;
        }

        public bool UpdateProductByCode(int productCode, string productName, string productType, int amount, string conditionOfProduct, double price)
        {
            Product ProductInBatch = _product.FirstOrDefault(s => s.ProductCode.Equals(productCode));

            if (ProductInBatch == null) return false;

            ProductInBatch.ProductName = productName;
            ProductInBatch.ProductType = productType;
            ProductInBatch.Amount = amount;
            ProductInBatch.ConditionOfProduct = conditionOfProduct;
            ProductInBatch.Price = price;

            return true;
        }
        public string GetAllProductInfor()
        { 
            string result = "";
            foreach (var s in _product)
            {
                result = result + s.ToString();
            }
            return result;
        }

        public Product GetProductByCode(int productCode)
        {
            Product ProductInBatch = _product.FirstOrDefault(std => std.ProductCode.Equals(productCode));
            if (ProductInBatch == null)
            {
                return null;
            }
            return ProductInBatch;

        }

        public Product GetProductByPrice(int price)
        {
            Product ProductInBatch = _product.FirstOrDefault(std => std.Price.Equals(price));
            if (ProductInBatch == null)
            {
                return null;
            }
            return ProductInBatch;
        }


    }
}

