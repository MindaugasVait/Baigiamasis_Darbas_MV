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
    class BaigiamasisNavigateMenuPage : BasePage
    {

        //Konstruktorius Web driveriui:
        public BaigiamasisNavigateMenuPage(IWebDriver webDriver) : base(webDriver) { }

        //Elementu sarasas:        
        private IWebElement _visoskategorijosButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container"));
        //Paveiksleliu meniu:
        private IWebElement _elektronikosKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div:nth-child(2) > div > div > a:nth-child(4)"));
        private IWebElement _aktyvusKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(2)"));
        private IWebElement _puslaidininkiaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(3)"));
        //Mega meniu:
        private IWebElement _elektronikosKomponentaiMegaMeniuButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container > div > div > div:nth-child(4) > a"));
        private IWebElement _puslaidininkiaiTextMeniuButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div.columnGroup-root-1fZ > div:nth-child(1) > div:nth-child(8) > ul:nth-child(1) > li:nth-child(3) > ul > li:nth-child(2) > a"));
        //Elementu paieska:
        //private IList<IWebElement> _elementList = Driver.FindElements(By.ClassName("category-card"));

        public void ClickVisosKategorijosButton()
        {
            _visoskategorijosButton.Click();
        }
        //Testuojama vizualinio meniu funkcija:
        public void ClickVisualButtons()
        {
            _visoskategorijosButton.Click();
            Driver.Navigate().Refresh();            
            Actions action = new Actions(Driver);
            action.MoveByOffset(0, 500);            
            action.Build().Perform();
            _elektronikosKomponentaiButton.Click();
            _aktyvusKomponentaiButton.Click();
            _puslaidininkiaiButton.Click();

        }
        public void ClickMegaMenuButtons()
        {
            _visoskategorijosButton.Click();
            Actions action = new Actions(Driver);
            action.MoveByOffset(600, 100);
            action.ContextClick(_elektronikosKomponentaiMegaMeniuButton);
            action.Build().Perform();

        }
        public void ClickTextMenuButtons()
        {
            _visoskategorijosButton.Click();
            //Driver.Navigate().Refresh();
            Actions action = new Actions(Driver);
            action.MoveByOffset(500, 0);
            //action.MoveToElement(_puslaidininkiaiTextMeniuButton);
            action.Click(_puslaidininkiaiTextMeniuButton);
            action.Build().Perform();
            
        }
        //Verifikuojami rezultatai:
        public void CheckElementsInPuslaidininkiai()
        {
            List<string> RealPuslaidininkiuKomponentai = new List<string>() { "Tilteliniai lygintuvai (18)", "Mikrovaldikliai, mikroprocesoriai ir ... (54)", "Diodai (140)", "Tiristoriai ir triakai (36)", "BJT, IGBT ir FET tranzistoriai (312)", "Integriniai grandynai (337)" };

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
    }
}
