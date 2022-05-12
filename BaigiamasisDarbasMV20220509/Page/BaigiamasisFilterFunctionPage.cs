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
    class BaigiamasisFilterFunctionPage : BasePage
    {
       
        //Konstruktorius Web driveriui:
        public BaigiamasisFilterFunctionPage(IWebDriver webDriver) : base(webDriver) { }
        
        //Elementu sarasas:                
        //Elementai reikalingi puslaidininkiu komponentu patikrinimui:
        private IWebElement _visiTranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(2)"));
        private IWebElement _tranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(3)"));
        private IWebElement _daugiauFiltruButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > div > button.btn-with-icon.product-filters-desk-toggler.btn.btn-light"));
        //Search elemento patikros sarasas:
        
        private IWebElement _filterChoises => Driver.FindElement(By.ClassName("form-check-input"));
        private IWebElement _korpusasTO220Filter => Driver.FindElement(By.Id("desk-ep_string_1694-TO220"));
        //Meniu elemento pasirinkimas:
        private IWebElement _bendrasFiltruMeniu => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul"));
        private IWebElement _sandelisFiltroMeniu => Driver.FindElement(By.ClassName("product-filters-desk-group"));
        private IWebElement _sandelisVidinisFiltroMeniu => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > ul > li:nth-child(1) > div.List.product-filters-value-list"));
        private IWebElement _sandelisPasirinkimoElementasFiltroMeniu => Driver.FindElement(By.ClassName("form-check"));
        private IWebElement _sandelisPasirinkimoElementoCheckBoxFiltroMeniu => Driver.FindElement(By.CssSelector(@"#desk-sources-Centrinis\ sandėlis"));
        private IWebElement _sandelisPasirinkimoElementoCentrinisFiltroMeniu => Driver.FindElement(By.CssSelector(@"#desk-sources-Vilniaus\ Žirmūnų\ parduotuvė"));
        //# desk-sources-Centrinis\ sandėlis
                       
        public void GoToTransistorFilterElement()
        {
            _visiTranzistoriaiButton.Click();
            _tranzistoriaiButton.Click();
            _daugiauFiltruButton.Click();
        }

        public void ClickFilterElements(string ch1)
        {
            IList<IWebElement> elementCList = Driver.FindElements(By.ClassName("form-check"));

            IList<string> foundChoises = new List<string>();
            foreach (IWebElement choise in elementCList)
            {
                if (choise.Text.ToLower().Contains(ch1) == true)
                {
                    GetWait(5).Until(d => _filterChoises);
                    _filterChoises.Click();
                }
            }
            Driver.Navigate().Refresh();
        }   
          /*  
            foreach (IWebElement choise in elementCList)
            {
                if (choise.Text.ToLower().Contains(el2) == true)
                {
                    GetWait(5).Until(d => _filterChoises);
                    _filterChoises.Click();
                }
            }
            Driver.Navigate().Refresh();
            
            foreach (IWebElement choise in elementCList)
            {
                if (choise.Text.ToLower().Contains(el3) == true)
                {
                    GetWait(5).Until(d => _filterChoises);
                    _filterChoises.Click();
                }
            }
            Driver.Navigate().Refresh();
            
            foreach (IWebElement choise in elementCList) 
            {
                if (choise.Text.ToLower().Contains(el4) == true)
                {
                    GetWait(5).Until(d => _filterChoises);
                    _filterChoises.Click();
                }
            }
            Driver.Navigate().Refresh();

            foreach (IWebElement choise in elementCList)
            {
                if (choise.Text.ToLower().Contains(el5) == true)
                {
                    GetWait(5).Until(d => _filterChoises);
                    _filterChoises.Click();
                }
            }
            
            Driver.Navigate().Refresh();                 
            
        */

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
