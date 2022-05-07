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
        public static BaigiamasisSearchFunctionPage _baigiamasisSearchFunctionPage;
        public static BaigiamasisNavigateMenuPage _baigiamasisNavigateMenuPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDrivers.GetChromeDriver();
                       
            _baigiamasisPage = new BaigiamasisPage(Driver);
            _baigiamasisSearchFunctionPage = new BaigiamasisSearchFunctionPage(Driver);
            _baigiamasisNavigateMenuPage = new BaigiamasisNavigateMenuPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
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
