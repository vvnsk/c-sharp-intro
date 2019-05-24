using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
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
        private int ProductId { get; set; }
        private string _productName;
        public string ProductName {
            get => _productName.InsertSpaces();
            set => _productName = value;
        }

        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(ProductName);

            if (CurrentPrice == null) isValid = false;

            return isValid;

        }
    }
}
