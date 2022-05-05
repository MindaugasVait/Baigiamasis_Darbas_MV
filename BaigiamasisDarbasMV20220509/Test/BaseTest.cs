using BaigiamasisDarbasMV20220509.Drivers;
using BaigiamasisDarbasMV20220509.Page;
using BaigiamasisDarbasMV20220509.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
            Driver = CustomDrivers.GetChromeDriver();
                       
            _baigiamasisPage = new BaigiamasisPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            // _driver.Quit();
        }
        [TearDown]
        public static void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome!= ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}
