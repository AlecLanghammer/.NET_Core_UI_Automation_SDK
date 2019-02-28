using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Core.Driver.Sessions
{
    public class FirefoxSession : IDriverSession
    {
        IWebDriver IDriverSession.GetDriver()
        {
            return new FirefoxDriver();
        }
    }
}
