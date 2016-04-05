using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var menusResult = DinerMax3000.Business.Menu.GetAllMenus();
            Assert.IsTrue(menusResult.Count > 0);

            int countBeforeSave = menusResult[0].items.Count;
            menusResult[0].SaveNewMenuItem("UT_Title", "UT_Description", 10.00);

            menusResult = DinerMax3000.Business.Menu.GetAllMenus();
            int countAfterSave = menusResult[0].items.Count;

            Assert.IsTrue(countBeforeSave < countAfterSave);

        }
    }
}
