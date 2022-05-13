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
        public BaigiamasisNavigateMenuPage(IWebDriver webDriver) : base(webDriver) { }
                 
        private IWebElement _visoskategorijosButton => Driver.FindElement(By.CssSelector("#root > header > div.sticky-wrapper > div > div > nav > ul > li.megamenu-container.first-container"));
        private IWebElement _elektronikosKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div:nth-child(2) > div > div > a:nth-child(4)"));
        private IWebElement _aktyvusKomponentaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(5)"));
        private IWebElement _puslaidininkiaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(1)"));
        private IWebElement _puslaidininkiaiTextMeniuButton => Driver.FindElement(By.CssSelector("#root > main > div > div > div > div > div.columnGroup-root-1fZ > div:nth-child(1) > div:nth-child(8) > ul:nth-child(1) > li:nth-child(3) > ul > li:nth-child(2) > a"));
        
        public void ClickVisosKategorijosButton()
        {
            _visoskategorijosButton.Click();
        }
        
        public void ClickVisualButtons()
        {
            _visoskategorijosButton.Click();
            Driver.Navigate().Refresh();            
            Actions action = new Actions(Driver);
            action.MoveByOffset(500, 0);            
            action.Build().Perform();
            _elektronikosKomponentaiButton.Click();
            _aktyvusKomponentaiButton.Click();
            _puslaidininkiaiButton.Click();
        }

        public void ClickTextMenuButtons()
        {
            _visoskategorijosButton.Click();            
            Actions action = new Actions(Driver);
            action.MoveByOffset(500, 0);            
            action.Click(_puslaidininkiaiTextMeniuButton);
            action.Build().Perform();
            
        }
       
        public void CheckElementsInPuslaidininkiai()
        {
            List<string> realPuslaidininkiuKomponentai = new List<string>() { "Integriniai grandynai", "BJT, IGBT ir FET tranzistoriai", "Tiristoriai ir triakai", "Diodai", "Mikrovaldikliai, mikroprocesoriai ir", "Tilteliniai lygintuvai" };

            IList<IWebElement> elementList = Driver.FindElements(By.ClassName("category-card"));

            IList<string> puslaidininkiuKomponentai = new List<string>();

            foreach (IWebElement element in elementList)
            {
                puslaidininkiuKomponentai.Add(element.Text);
            }            

            for (int i = 0; i < 6; i++)
            {
                Assert.IsTrue(puslaidininkiuKomponentai.ElementAt(i).Contains(realPuslaidininkiuKomponentai.ElementAt(i)), "Displayed result varies from expected");
            }
        }
    }
}
