using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Driver.Sessions;

namespace Core.TestUtilities
{
    /// <summary>
    /// Base test class for all test classes to inherit.  Handles driver creation and teardown.
    /// </summary>
    [TestClass]
    public abstract class BaseTest
    {
        public abstract TestContext TestContext { get; set; }
        protected IDriverSession driverSession;
        protected IWebDriver driver;
        protected static Dictionary<string, string> inputParameters;

        /// <summary>
        /// Called the start of tests.  Merges run parameters and creates the web driver.
        /// </summary>
        [TestInitialize]
        public void SetupTest()
        {
            inputParameters = MergeParameters.BuildParameters();
            driverSession = DriverSessions.GetSessionType(inputParameters["browser"]);
            driver = driverSession.GetDriver();
        }

        /// <summary>
        /// Handles test cleanup including optional reporting of screenshots and page source on failure.
        /// </summary>
        [TestCleanup]
        public void EndTest()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                string testName = TestContext.TestName + "_";
                if (Convert.ToBoolean(inputParameters["screenonfail?"]))
                {
                    PageScreenshot.Take(driver, TestContext, testName);
                }
                if (Convert.ToBoolean(inputParameters["sourceonfail?"]))
                {
                    PageSource.Save(driver, TestContext, testName);
                }
            }
            if (driver != null) { driver.Quit(); }
        }
    }
}
