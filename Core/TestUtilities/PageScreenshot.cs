using System;
using OpenQA.Selenium;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.TestUtilities
{
    public class PageScreenshot
    {
        //TODO: figure out AddResultFile in net core
        //https://github.com/Microsoft/testfx/issues/394

        /// <summary>
        /// Takes a screenshot of the current web page and attaches it to the test context.
        /// </summary>
        /// <param name="driver">Selenium web driver object</param>
        /// <param name="tc">Mstest TestContext</param>
        /// <param name="descriptor">String to be included as part of the file name, usually either the
        /// current test name or a step comment</param>
        public static void Take(IWebDriver driver, TestContext tc, string descriptor)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd_hh_mm_ss");
                string path = FrameworkConfig.configDict["ScreenshotPath"];
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string fullPath = path + descriptor + date + ".jpg";
                screenshot.SaveAsFile(fullPath, ScreenshotImageFormat.Jpeg);
                //tc.AddResultFile(fullPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.ToString());
                Console.WriteLine("StackTrace: {0}", Environment.StackTrace);
            }
        }
    }
}
