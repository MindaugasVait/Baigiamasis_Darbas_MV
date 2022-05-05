using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using System.Reflection;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;

namespace BaigiamasisDarbasMV20220509.Tools
{
    class MyScreenshot
    {
        public static void TakeScreenshot(IWebDriver webDriver)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);

            Screenshot screenshot = webDriver.TakeScreenshot();

            string screenshotDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            string screenshotFolder = Path.Combine(screenshotDirectory, "screenshot");

            Directory.CreateDirectory(screenshotFolder);

            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";

            string screenshotPath = Path.Combine(screenshotFolder, screenshotName);

            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }
    }
}
