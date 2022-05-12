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
using System.Threading;

namespace BaigiamasisDarbasMV20220509.Page
{
    class BaigiamasisSearchFunctionPage : BasePage
    {
        //Konstruktorius Web driveriui:
        public BaigiamasisSearchFunctionPage(IWebDriver webDriver) : base(webDriver) { }

        //Elementu sarasas:
        //Menu sarasas:
        private IWebElement _visoskategorijosButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container"));
        //Search elemento patikros sarasas:    
        //private IWebElement _switchOffNaujienaPopUp => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > div.image-search-tooltip > div.fake-tooltip > div > button > svg"));
        private IWebElement _searchInputField => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > div.search-wrapper > input"));
        private IWebElement _searchButton => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > button.search-button.btn-with-icon.btn.btn-primary"));
        private IList<IWebElement> _elementPList => Driver.FindElements(By.XPath("//div[@class='product-list-product col-sm-12']"));

        //Iseinama is visos kategorijos menu:
        public void GoingOutOfVisosKategorijosMenu()
        {
            _visoskategorijosButton.Click();
            Driver.Navigate().Refresh();
        }


        //Ijungiama Search Funkcija:
        public void SubmitSearch(string searchingFor1, string searchingFor2, string searchingFor3)
        {
            //_switchOffNaujienaPopUp.Click();
            _searchInputField.Clear();
            Thread.Sleep(1000);
            _searchInputField.SendKeys(searchingFor1);
            Thread.Sleep(500);
            _searchInputField.SendKeys(searchingFor2);
            Thread.Sleep(500);
            _searchInputField.SendKeys(searchingFor3);
            
            _searchButton.Click();
        }

        //Tikrinami Search funkcijos rezultatai:
        public void EvaluateTestSearchResults(string el1, string el2, string el3)
        {
            int rastuPrekiuKiekis = _elementPList.Count;

            int prekiuAtitinkanciAprasymaKiekis = 0;

            /*Pabandymui:
            IList<string> puslaidininkiuKomponentai = new List<string>();

            foreach (IWebElement element in _elementPList)
            {
                puslaidininkiuKomponentai.Add(element.Text);
            }
            */

            //IList<string> rastosPrekes = new List<string>();

            if (rastuPrekiuKiekis != 0 && rastuPrekiuKiekis > 1)
            {
                foreach (IWebElement preke in _elementPList)
                {
                    if (preke.Text.ToLower().Contains(el1) == true || preke.Text.ToLower().Contains(el2) == true || preke.Text.ToLower().Contains(el3) == true)
                    {
                        prekiuAtitinkanciAprasymaKiekis++;
                    }
                }
            }
            Assert.AreEqual(rastuPrekiuKiekis, prekiuAtitinkanciAprasymaKiekis, "Found goods varies from expected");
        }
    }
}
