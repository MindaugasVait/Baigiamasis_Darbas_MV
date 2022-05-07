using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbasMV20220509.Drivers
{
    class CustomDrivers
    {
        public static IWebDriver GetChromeDriver()
        {
            return GetDriver(Browsers.Chrome);
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }

        private static IWebDriver GetDriver(Browsers browser)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browsers.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--disable-notifications");
                    webDriver = new ChromeDriver(options);
                    break;
                case Browsers.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    ChromeOptions dOptions = new ChromeOptions();
                    dOptions.AddArguments("--disable-notifications");
                    webDriver = new ChromeDriver(dOptions);
                    break;
            }
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Manage().Window.Maximize();

            return webDriver;
        }            
    }
}
