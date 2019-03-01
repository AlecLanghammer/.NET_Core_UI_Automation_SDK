using Core.PageObject;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageLibrary
{
    public class GoogleMainPage : BasePage
    {
        private string expectedPageTitle = "Google";

        WebElementProxy searchField;

        public GoogleMainPage(IWebDriver driver) : base(driver)
        {
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

        public override void WaitForLoad()
        {
            WaitForPageTitle(expectedPageTitle);
        }
    }
}
