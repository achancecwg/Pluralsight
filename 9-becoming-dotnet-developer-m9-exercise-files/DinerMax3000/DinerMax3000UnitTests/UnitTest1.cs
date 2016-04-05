using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DinerMax3000UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var resultMenus =DinerMax3000.Business.Menu.GetAllMenus();
            Assert.IsTrue(resultMenus.Count > 0);

            int countBeforeSave = resultMenus[0].Items.Count;
            resultMenus[0].SaveNewMenuItem("UT_Name", "UT_Description", 10.00);
            resultMenus = DinerMax3000.Business.Menu.GetAllMenus();
            int countAfterSave = resultMenus[0].Items.Count;

            Assert.IsTrue(countBeforeSave < countAfterSave);

        }
    }
}
