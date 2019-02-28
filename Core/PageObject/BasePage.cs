using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.PageObject
{
    public abstract class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
