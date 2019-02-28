using Core.PageObject;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageLibrary
{
    public class GoogleMainPage : BasePage
    {
        private string expectedPageTitle = "Google";
        private string homePageUrl;

        WebElementProxy searchField;

        public GoogleMainPage(IWebDriver driver, string url) : base(driver)
        {
            homePageUrl = url;
            InitializeElements();
        }

        void InitializeElements()
        {
            searchField = new WebElementProxy(driver, By.Name("q"));
        }

        public void EnterSearchField(string searchString)
        {
            searchField.Get().SendKeys(searchString);
        }

        protected override void ExecuteLoad()
        {
            driver.Navigate().GoToUrl(homePageUrl);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.Title.Equals(expectedPageTitle));
        }

        protected override bool EvaluateLoadedStatus()
        {
            return expectedPageTitle == driver.Title;
        }
    }
}
