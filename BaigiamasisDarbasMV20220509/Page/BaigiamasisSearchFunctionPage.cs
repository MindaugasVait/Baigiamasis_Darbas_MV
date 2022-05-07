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
    class BaigiamasisSearchFunctionPage : BasePage
    {
        private const string PageAddress = "https://www.lemona.lt/";
        //Konstruktorius Web driveriui:
        public BaigiamasisSearchFunctionPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        //Elementu sarasas:
        private static IWebElement _popup => Driver.FindElement(By.CssSelector("#root > div.CookieWarning-warningContainer-2rh > div > button"));
        //Search elemento patikros sarasas:
        private IWebElement _searchInputField => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > div.search-wrapper > input"));
        private IWebElement _searchButton => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > button.search-button.btn-with-icon.btn.btn-primary"));

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }

        public void SubmitSearch(string searchingFor)
        {
            _searchInputField.SendKeys(searchingFor);
            _searchButton.Click();
        }

        public void EvaluateTestSearchResults(string el1, string el2, string el3)
        {
            IList<IWebElement> elementPList = Driver.FindElements(By.XPath("//div[@class='product-list-product col-sm-12']"));

            int rastuPrekiuKiekis = Driver.FindElements(By.XPath("//div[@class='product-list-product col-sm-12']")).Count;

            int prekiuAtitinkanciAprasymaKiekis = 0;

            IList<string> rastosPrekes = new List<string>();
            foreach (IWebElement preke in elementPList)
            {
                if (preke.Text.ToLower().Contains(el1) == true || preke.Text.ToLower().Contains(el2) == true || preke.Text.ToLower().Contains(el3) == true)
                {
                    prekiuAtitinkanciAprasymaKiekis++;
                }
            }

            string shownResultprekesList = string.Join(",", rastosPrekes.ToArray());
            Assert.AreEqual(rastuPrekiuKiekis, prekiuAtitinkanciAprasymaKiekis, "Found goods varies from expected");
        }       
    }
}
