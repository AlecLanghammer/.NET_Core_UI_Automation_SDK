using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class FrameworkConfig
    {
        public static Dictionary<string, string> GetConfigDict()
        {
            Dictionary<string, string> configDict = new Dictionary<string, string>
            {
                {"browser","chrome"}, {"browserVersion", "57"}, {"OS","Windows 10"}, {"ScreenOnFail?","True"},
                {"SourceOnFail?" ,"True"}, {"ScreenshotPath",@"C:\TEMP\Screens\"}, {"SourcePath", @"C:\TEMP\Source\"},
                {"Environment", "Local"}, {"url", ""}
            };
            return configDict;
        }
    }
}
