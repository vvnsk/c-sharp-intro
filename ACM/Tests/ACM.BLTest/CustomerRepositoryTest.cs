using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "foo@bar.com",
                LastName = "Bar",
                FirstName = "Foo"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(actual.FirstName, expected.FirstName);
            Assert.AreEqual(actual.LastName, expected.LastName);
            Assert.AreEqual(actual.EmailAddress, expected.EmailAddress);

        }
    }
}
