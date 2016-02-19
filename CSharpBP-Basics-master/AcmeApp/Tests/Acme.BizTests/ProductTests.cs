using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Test";
            currentProduct.ProductId = 1;
            currentProduct.Description = "This is a test product";
            currentProduct.ProductVendor.CompanyName = "ABC Corp";
            var expected = "Hello Test (1): This is a test product" + " Available on: ";
            //Act
            var actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_ParamConstructor()
        {
            //Arrange
            var currentProduct = new Product(1, "Test", "This is a test product");

            var expected = "Hello Test (1): This is a test product" + " Available on: ";

            //Act
            var actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void Product_Null()
        {
            //Arrange 
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;

            string expected = null;


            //Act
            var actual = companyName;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ConvertMetersToInchesTest()
        {
            //Arrange
            var expected = 78.74;

            //Act
            var actual = 2 * Product.InchesPerMeter;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumPriceTest_Default()
        {
            //Arrange
            var currentProduct = new Product();
            var expected = .96m;
            //Act
            var actual = currentProduct.MinimumPrice;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumPriceTest_Bulk()
        {
            //Arrange
            var currentProduct = new Product(1, "Bulk Tools", "");
            var expected = 9.99m;
            //Act
            var actual = currentProduct.MinimumPrice;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Productname_Format()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "  Steel Hammer  ";

            var expected = "Steel Hammer";
            //Act
            var actual = currentProduct.ProductName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Productname_Valid()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";

            string expected = "Saw";
            string expectedMessage = null;
            //Act
            var actual = currentProduct.ProductName;
            var actualMessage = currentProduct.ValidationMessage;
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
        [TestMethod()]
        public void Productname_TooShort()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "aw";

            string expected = null;
            string expectedMessage = "Product name must be at least 3 characters";
            //Act
            var actual = currentProduct.ProductName;
            var actualMessage = currentProduct.ValidationMessage;
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
        [TestMethod()]
        public void Productname_TooLong()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Steelhammer123443623656546346463463463463456";

            string expected = null;
            string expectedMessage = "Product cannot be more than 20 characters";
            //Act
            var actual = currentProduct.ProductName;
            var actualMessage = currentProduct.ValidationMessage;
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void Category_DefaultValue()
        {
            //Arrange
            var currentProduct = new Product();

            var expected = "Tools";

            //Act
            var actual = currentProduct.Category;
    
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Category_NewValue()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.Category = "Garden";

            var expected = "Garden";

            //Act
            var actual = currentProduct.Category;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Sequence_NewValue()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.SequenceNumber = 3;

            var expected = 3;

            //Act
            var actual = currentProduct.SequenceNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Sequence_DefaultValue()
        {
            //Arrange
            var currentProduct = new Product();
            var expected = 1;

            //Act
            var actual = currentProduct.SequenceNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ProductCode_Test()
        {
            //Arrange
            var currentProduct = new Product();

            var expected = "Tools-1";

            //Act
            var actual = currentProduct.ProductCode;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}