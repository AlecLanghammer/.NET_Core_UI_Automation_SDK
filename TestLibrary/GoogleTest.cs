using System;
using Core.TestUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageLibrary;

namespace TestLibrary
{
    [TestClass]
    public class GoogleTest : BaseTest
    {
        GoogleMainPage googleMainPage;
        public override TestContext TestContext { get; set; }

        [TestInitialize]
        public void StartTest()
        {
            googleMainPage = new GoogleMainPage(driver, "http://www.google.com");
        }

        [TestCategory("Example"), TestMethod]
        public void GoogleMainPageTest()
        {
            googleMainPage.Load();
            googleMainPage.EnterSearchField("Test");
        }
    }
}
