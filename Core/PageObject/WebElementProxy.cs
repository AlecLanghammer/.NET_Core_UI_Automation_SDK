using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.PageObject
{
    public class WebElementProxy
    {
        private By locator;
        private IWebDriver driver;
        public WebElementProxy(IWebDriver driver, By locator)
        {
            this.locator = locator;
            this.driver = driver;
        }

        public IWebElement Get()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(drv => drv.FindElement(locator));
        }
    }
}
