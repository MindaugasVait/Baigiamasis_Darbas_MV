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
    class BaigiamasisLemoneKontaktaiCheckPage : BasePage
    {
        //Konstruktorius Web driveriui:
        public BaigiamasisLemoneKontaktaiCheckPage(IWebDriver webDriver) : base(webDriver) { }

        //Elementu sarasas:        
        private IWebElement _kontaktaiButton => Driver.FindElement(By.CssSelector("#root > header > div.header-top > div > div.header-left.header-dropdowns > div:nth-child(2) > div > div > div > div > div > div > div > ul > li:nth-child(1) > a"));
        private IWebElement _BenrovesPavadinimas => Driver.FindElement(By.CssSelector("#root > footer > div.footer-letter-and-links-wrapper > div > div > div:nth-child(1) > div > div.Requisites-requisites-3x2 > h5"));
        //Funkciju sarasas:
        public void ClickKontaktaiButton()
        {
            _kontaktaiButton.Click();
        }
        public void CheckShopInfo(string shopName)
        {
            string shopNameFromSite = _BenrovesPavadinimas.Text;
            Assert.IsTrue(shopNameFromSite.Equals(shopName), "Displayed result varies from expected");
        }
    }
}
