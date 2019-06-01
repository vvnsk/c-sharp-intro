using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using Acme.Common;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "foo@bar.com",
                FirstName = "Foo",
                LastName = "Bar",
                AddressList = null
            };
            changedItems.Add(customer);
            
            var product = new Product(2)
            {
                ProductName = "Test",
                ProductDescription = "Exotic test",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing to assert
        }
    }
}
