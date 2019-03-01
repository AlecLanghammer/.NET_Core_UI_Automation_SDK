using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Core.PageObject
{
    public abstract class BasePage : StandardLoad
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public virtual void WaitForPageTitle(string expectedTitle)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.Title.Equals(expectedTitle));
        }
    }
}
