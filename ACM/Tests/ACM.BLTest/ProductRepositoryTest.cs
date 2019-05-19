using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Flame Thrower",
                ProductDescription = "Loreum Ipsum",
                CurrentPrice = 15.96M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(actual.ProductName, expected.ProductName);
            Assert.AreEqual(actual.ProductDescription, expected.ProductDescription);
            Assert.AreEqual(actual.CurrentPrice, expected.CurrentPrice);

        }
    }
}
