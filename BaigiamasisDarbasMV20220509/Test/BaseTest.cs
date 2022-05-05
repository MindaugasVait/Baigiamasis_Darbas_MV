using BaigiamasisDarbasMV20220509.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbasMV20220509.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static BaigiamasisPage _baigiamasisPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            _baigiamasisPage = new BaigiamasisPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            // _driver.Quit();
        }
    }
}
