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
        private IWebElement _BenrovesZirmunuParduotuvesAdresas => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div > div:nth-child(2) > div.html-root-1pb > div > div > div > div > div > div:nth-child(12) > div > div > div > div:nth-child(3) > div > div:nth-child(2) > p"));
        private IWebElement _BenrovesZirmunuParduotuvesTelefonas => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div > div:nth-child(2) > div.html-root-1pb > div > div > div > div > div > div:nth-child(12) > div > div > div > div:nth-child(3) > div > div.column-list4000 > p"));
        private IWebElement _BenrovesZirmunuParduotuvesDarboLaikas => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div > div:nth-child(2) > div.html-root-1pb > div > div > div > div > div > div:nth-child(12) > div > div > div > div:nth-child(3) > div > div.column-list3000 > p"));
        
        //Funkciju sarasas:
        public void ClickKontaktaiButton()
        {
            _kontaktaiButton.Click();
        }
        public void CheckShopInfo(string shopName, string zirmPardAdresss, string zirmPardTelephone, string zirmPardDarboLaikas)
        {
            string shopNameFromSite = _BenrovesPavadinimas.Text;
            string zirmunuParduotuvesAdresas = _BenrovesZirmunuParduotuvesAdresas.Text;
            string zirmunuParduotuvesTelefonas = _BenrovesZirmunuParduotuvesTelefonas.Text;
            string zirmunuParduotuvesDarboLaikas = _BenrovesZirmunuParduotuvesDarboLaikas.Text;            

            Assert.IsTrue(shopNameFromSite.Equals(shopName), "Displayed result varies from expected");
            Assert.IsTrue(zirmunuParduotuvesAdresas.Equals(zirmPardAdresss), "Displayed result varies from expected");
            Assert.IsTrue(zirmunuParduotuvesTelefonas.Equals(zirmPardTelephone), "Displayed result varies from expected");
            Assert.IsTrue(zirmunuParduotuvesDarboLaikas.Equals(zirmPardDarboLaikas), "Displayed result varies from expected");

        }
    }
}
