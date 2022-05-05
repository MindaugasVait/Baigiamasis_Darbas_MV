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
        private IWebElement _visoskategorijosButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container"));
        //Neveikiantis:
        private IWebElement _searchElement => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div:nth-child(2) > div > div > a:nth-child(9)"));
        private IWebElement _elektronikosKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div:nth-child(2) > div > div > a:nth-child(4)"));

        //private IWebElement _elektronikosKomponentaiButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container > div > div > div:nth-child(4) > a"));
        private IWebElement _aktyvusKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(2)"));
        
        private IWebElement _puslaidininkiaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(3)"));
        private IWebElement _visiTranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(5)"));
        private IWebElement _tranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(1)"));
        private IWebElement _daugiauFiltruButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > div > button.btn-with-icon.product-filters-desk-toggler.btn.btn-light"));
        private IWebElement _korpusasFilter => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul > li:nth-child(5) > div.List.product-filters-value-list"));
        private IWebElement _korpusasTO220Filter => Driver.FindElement(By.Id("desk-ep_string_1694-TO220"));

        //
        //Click funkcijos:
        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }
        public void ClickVisosKategorijosButton()
        {
            _visoskategorijosButton.Click();
        }
        public void ClickSearchElement()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_searchElement);
            //action.ContextClick(_searchElement);
            _searchElement.Click();           
            action.Build().Perform();
        }
        public void ClickElektronikosKomponentai()
        {
            //Actions action = new Actions(Driver);
            //action.MoveToElement(_elektronikosKomponentaiButton);
            // action.ContextClick(_elektronikosKomponentaiButton);
            _elektronikosKomponentaiButton.Click();
            // action.Build().Perform();
        }

        public void ClickAktyvusKomponentai()
        {
            _aktyvusKomponentaiButton.Click();
        }
        public void ClickPuslaidininkiai()
        {
            _puslaidininkiaiButton.Click();
        }
        public void ClickVisiTranzistoriai()
        {
            _visiTranzistoriaiButton.Click();
        }
        public void ClickTranzistoriai()
        {
            _tranzistoriaiButton.Click();
        }
        public void ClickDaugiauFiltruButton()
        {
            _daugiauFiltruButton.Click();
        }
        /*public void ClickKorpusasTO220Selections()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_korpusasFilter);
            action.MoveToElement(_korpusasTO220Filter);
            _korpusasTO220Filter.Click();
            action.Build().Perform();
        }*/
    }
}
