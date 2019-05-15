using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {

        [TestMethod()]
        public void RetrieveAllTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                new Vendor() {VendorId = 7, CompanyName = "TYU Toy Corp", Email = "tyu@tyu.com"},
                new Vendor() {VendorId = 9, CompanyName = "JKL Toy Corp", Email = "jkl@jkl.com"}
            };

            //Act
            var vendors = repository.RetrieveAll();

            var vendorQuery = from v in vendors
                              where v.CompanyName.Contains("Toy")
                              select v;

            //Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());

        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();

            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Corp", Email = "xyz@xyz.com" });

            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual.ToList());

        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                {
                    new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" }
                },
                {
                    new Vendor() { VendorId = 2, CompanyName = "XYZ Corp", Email = "xyz@xyz.com" }
                }
            };

            //Act
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Console.WriteLine(item);
            }
            var actual = vendorIterator.ToList();

            //Assert
            CollectionAssert.AreEqual(expected,actual);
        }

    }
}