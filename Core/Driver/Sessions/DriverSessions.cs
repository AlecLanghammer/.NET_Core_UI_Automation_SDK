
namespace Core.Driver.Sessions
{
    /// <summary>
    /// Returns a driver session for the browser configured in the run parameters
    /// </summary>
    public class DriverSessions
    {
        public static IDriverSession GetSessionType(string session)
        {

            switch (session)
            {
                case "firefox":
                    return new FirefoxSession();
                case "chrome":
                    return new ChromeSession();
                default:
                    return new ChromeSession();
            }
        }
    }
}
