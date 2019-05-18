using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        ///Retrieve one product
        /// </summary>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        public List<Product> Retrieve()
        {
            return new List<Product>();

        }

        /// <summary>
        /// Saves Current Product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;

        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(ProductName);

            if (CurrentPrice == null) isValid = false;

            return isValid;

        }
    }
}
