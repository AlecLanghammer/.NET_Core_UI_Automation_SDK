using OpenQA.Selenium;

namespace Core.PageObject
{
    /// <summary>
    /// A component is defined as a section of the UI that can be broken off. They are
    /// typically instantiated in the relevant page object classes.
    /// </summary>
    public abstract class BaseComponent
    {
        protected IWebDriver driver;

        public BaseComponent(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}