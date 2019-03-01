using System.Collections.Generic;

namespace Core
{
    public static class FrameworkConfig
    {
        public static Dictionary<string, string> configDict = new Dictionary<string, string>
            {
                {"browser","chrome"}, {"browserVersion", "57"}, {"OS","Windows 10"}, {"ScreenOnFail?","True"},
                {"SourceOnFail?" ,"True"}, {"ScreenshotPath",@"C:\TEMP\Screens\"}, {"SourcePath", @"C:\TEMP\Source\"},
                {"Environment", "Local"}, {"url", ""}
            };
    }
}
