using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core.Driver.Sessions
{
    public class ChromeSession : IDriverSession
    {
        IWebDriver IDriverSession.GetDriver()
        {
            return new ChromeDriver();
        }
    }
}
