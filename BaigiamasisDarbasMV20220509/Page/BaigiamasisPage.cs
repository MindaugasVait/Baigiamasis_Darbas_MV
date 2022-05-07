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
        //Sarasas paveiksleliu meniu:
        private IWebElement _elektronikosKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div:nth-child(2) > div > div > a:nth-child(4)"));
        private IWebElement _aktyvusKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(2)"));
        private IWebElement _puslaidininkiaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(3)"));
        //Sarasas Mega meniu:
        private IWebElement _elektronikosKomponentaiMegaMeniuButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container > div > div > div:nth-child(4) > a"));
        private IWebElement _puslaidininkiaiMegaMeniuButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container > div > div > div:nth-child(4) > ul > li:nth-child(2) > div:nth-child(1) > ul > li:nth-child(2) > a"));
        //Elementai reikalingi puslaidininkiu komponentu patikrinimui:
        private IWebElement _puslaidininkiuMeniuKomponentai => Driver.FindElement(By.ClassName("category-card"));
        private IWebElement _visiTranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(5)"));
        private IWebElement _tranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(1)"));
        private IWebElement _daugiauFiltruButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > div > button.btn-with-icon.product-filters-desk-toggler.btn.btn-light"));
        //Search elemento patikros sarasas:
        private IWebElement _searchInputField => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > div.search-wrapper > input"));
        private IWebElement _searchButton => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-center > div > form > div > button.search-button.btn-with-icon.btn.btn-primary"));
        //**
        private IWebElement _korpusasFilter => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul > li:nth-child(5) > div.List.product-filters-value-list"));
        private IWebElement _korpusasTO220Filter => Driver.FindElement(By.Id("desk-ep_string_1694-TO220"));
        //Meniu elemento pasirinkimas:
        private IWebElement _bendrasFiltruMeniu => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul"));
        private IWebElement _sandelisFiltroMeniu => Driver.FindElement(By.ClassName("product-filters-desk-group"));
        private IWebElement _sandelisVidinisFiltroMeniu => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul > li:nth-child(1) > div.List.product-filters-value-list"));
        private IWebElement _sandelisPasirinkimoElementasFiltroMeniu => Driver.FindElement(By.ClassName("form-check"));
        private IWebElement _sandelisPasirinkimoElementoCheckBoxFiltroMeniu => Driver.FindElement(By.CssSelector(@"#desk-sources-Centrinis\ sandėlis"));
        private IWebElement _sandelisPasirinkimoElementoCentrinisFiltroMeniu => Driver.FindElement(By.CssSelector(@"#desk-sources-Vilniaus\ Žirmūnų\ parduotuvė"));
                                                                                                                    //# desk-sources-Centrinis\ sandėlis
        
        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();            
        }
        public void ClickVisosKategorijosButton()
        {
            _visoskategorijosButton.Click();
        }
 
        public void ClickVisualButtons()
        {
            _visoskategorijosButton.Click();
            Driver.Navigate().Refresh();
            _elektronikosKomponentaiButton.Click();
            _aktyvusKomponentaiButton.Click();
            _puslaidininkiaiButton.Click();

        }
        public void ClickMegaMenuButtons()
        {
            _visoskategorijosButton.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(_elektronikosKomponentaiMegaMeniuButton);
            _puslaidininkiaiMegaMeniuButton.Click();
            action.Build().Perform();

        }

        public void CheckElementsInPuslaidininkiai()
        {
            List<string> RealPuslaidininkiuKomponentai = new List<string>() { "Tilteliniai lygintuvai (18)", "Mikrovaldikliai, mikroprocesoriai ir ... (54)", "Diodai (139)", "Tiristoriai ir triakai (37)", "BJT, IGBT ir FET tranzistoriai (312)", "Integriniai grandynai (337)" };
            
            string expectedResultPuslaidininkiuKomponentai = string.Join(",", RealPuslaidininkiuKomponentai.ToArray());

            IList<IWebElement> elementList = Driver.FindElements(By.ClassName("category-card"));
            
            IList<string> puslaidininkiuKomponentai = new List<string>();

            foreach (IWebElement element in elementList)
            {
                puslaidininkiuKomponentai.Add(element.Text);
            }
            
            string shownResultPuslaidininkiuKomponentai = string.Join(",", puslaidininkiuKomponentai.ToArray());
            
            Assert.IsTrue(shownResultPuslaidininkiuKomponentai.Equals(expectedResultPuslaidininkiuKomponentai), "Displayed result varies from expected");

        }

        public void GoToTranzistoriaiFilter()
        {
            _visiTranzistoriaiButton.Click();
            _tranzistoriaiButton.Click();
            _daugiauFiltruButton.Click();
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

        //Ieskome: NPN 0.1A 0.5W TO92
        //Ieskome2: resistor 10k, axial, metal oxide
        //Ieskome3: 

        /*public void ClickKorpusasTO220Selections()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_korpusasFilter);
            action.MoveToElement(_korpusasTO220Filter);
            _korpusasTO220Filter.Click();
            action.Build().Perform();
        }*/

        /*public void ClickKorpusasTO220Selections()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_bendrasFiltruMeniu);
            action.MoveToElement(_sandelisFiltroMeniu);
            action.MoveToElement(_sandelisVidinisFiltroMeniu);
            action.MoveToElement(_sandelisPasirinkimoElementasFiltroMeniu);
            _sandelisPasirinkimoElementoCheckBoxFiltroMeniu.Click();
            action.MoveToElement(_bendrasFiltruMeniu);
            action.MoveToElement(_sandelisFiltroMeniu);
            action.MoveToElement(_sandelisVidinisFiltroMeniu);
            action.MoveToElement(_sandelisPasirinkimoElementoCentrinisFiltroMeniu);
            _sandelisPasirinkimoElementoCentrinisFiltroMeniu.Click();
            action.Build().Perform();
        }*/
    }
}
