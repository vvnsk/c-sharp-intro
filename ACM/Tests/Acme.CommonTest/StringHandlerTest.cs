using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            const string source = "SonicScrewdriver";
            const string expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();
            // Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            const string source = "Sonic Screwdriver";
            const string expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
