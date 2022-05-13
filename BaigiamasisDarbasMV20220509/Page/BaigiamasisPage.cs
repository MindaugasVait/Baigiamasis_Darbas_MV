using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace BaigiamasisDarbasMV20220509.Page
{
    class BaigiamasisPage : BasePage
    {
        private const string PageAddress = "https://www.lemona.lt/";
        
        public BaigiamasisPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
       
        private static IWebElement _popup => Driver.FindElement(By.CssSelector("#root > div.CookieWarning-warningContainer-2rh > div > button"));
             
        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();                       
        }        
    }
}
