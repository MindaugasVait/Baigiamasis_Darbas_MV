using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbasMV20220509.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }
    }
}
