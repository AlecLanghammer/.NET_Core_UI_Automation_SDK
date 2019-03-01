using System;
using OpenQA.Selenium;
using System.IO;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.TestUtilities
{
    public class PageSource
    {
        //TODO: figure out AddResultFile in net core
        //https://github.com/Microsoft/testfx/issues/394

        /// <summary>
        /// Saves the current page source as an html file and attaches it to the test context.
        /// </summary>
        /// <param name="driver">Selenium web driver object</param>
        /// <param name="tc">Mstest TestContext</param>
        /// <param name="descriptor">String to be included as part of the file name, usually either the
        /// current test name or a step comment</param>
        public static void Save(IWebDriver driver, TestContext tc, string descriptor)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd_hh_mm_ss");
                string path = FrameworkConfig.configDict["SourcePath"];
                string fullPath = path + descriptor + date + ".html";
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.Write(driver.PageSource);
                }
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
