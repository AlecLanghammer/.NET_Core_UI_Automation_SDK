using OpenQA.Selenium;

namespace Core.Driver.Sessions
{
    public interface IDriverSession
    {
        IWebDriver GetDriver();
    }
}
