using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DinerMaxTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDatabaseConnection()
        {
            //Arrange 

            //Act
            var resultMenus = DinerMax3000.Business.Menu.GetAllMenus();

            //Assert
            Assert.IsTrue(resultMenus.Count > 0);

        }


            [TestMethod]
        public void TestDatabaseAddItem()
        {
            //Arrange 

            //Act
            var resultMenus = DinerMax3000.Business.Menu.GetAllMenus();

            int countBeforeSave = resultMenus[0].Items.Count;
            resultMenus[0].SaveNewMenuItem("UT_Name", "UT_Description", 10.00);

            resultMenus = DinerMax3000.Business.Menu.GetAllMenus();
            int countAfterSave = resultMenus[0].Items.Count;

            //Assert
            Assert.IsTrue(countAfterSave > countBeforeSave);

        }
    }
    
}
