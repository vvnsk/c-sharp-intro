using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        /// <summary>
        ///Retrieve one product
        /// </summary>
        public Product Retrieve(int productId)
        {
            var product = new Product();

            if (productId == 2)
            {
                product.ProductName = "Flame Thrower";
                product.ProductDescription = "Loreum Ipsum";
                product.CurrentPrice = 15.96M;
            }

            Console.WriteLine($"Product: {product.ToString()}");
            return product;
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
    }
}
