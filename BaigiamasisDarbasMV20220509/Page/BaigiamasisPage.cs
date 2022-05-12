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
        //Konstruktorius Web driveriui:
        public BaigiamasisPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        //Elementu sarasas:
        private static IWebElement _popup => Driver.FindElement(By.CssSelector("#root > div.CookieWarning-warningContainer-2rh > div > button"));

        /*Panaudoti Explicit Wait (gal pades su stale element?):
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(target_xpath)));
        informacija is: https://www.lambdatest.com/blog/explicit-fluent-wait-in-selenium-c/
        */
        
        //Uzdaro PopUp:
        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();                       
        }        
    }
}
