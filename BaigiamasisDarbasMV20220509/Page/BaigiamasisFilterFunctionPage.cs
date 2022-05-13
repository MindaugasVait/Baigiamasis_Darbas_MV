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
        public BaigiamasisFilterFunctionPage(IWebDriver webDriver) : base(webDriver) { }
        
        
        private IWebElement _visiTranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(2)"));
        private IWebElement _tranzistoriaiButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > div > a:nth-child(3)"));
        private IWebElement _daugiauFiltruButton => Driver.FindElement(By.CssSelector("#root > main > div.category > div > div > div > nav.toolbox.product-list-options-display-options > div.product-filters.product-filters-desk > form > div > button.btn-with-icon.product-filters-desk-toggler.btn.btn-light"));
        private IWebElement _filterChoises1 => Driver.FindElement(By.ClassName("form-check-input"));
        private IWebElement _filterChoises2 => Driver.FindElement(By.ClassName("form-check-input"));
        private IList<IWebElement> _elementPList => Driver.FindElements(By.XPath("//div[@class='product-list-product col-sm-12']"));
                               
        public void GoToTransistorFilterElement()
        {
            _visiTranzistoriaiButton.Click();
            _tranzistoriaiButton.Click();
            _daugiauFiltruButton.Click();
            
        }

        public void ClickFirstFilterElement(string ch1)
        {
            IList<IWebElement> elementCList = Driver.FindElements(By.ClassName("form-check"));

            IList<string> foundChoises = new List<string>();
            foreach (IWebElement choise in elementCList)
            {
                if (choise.Text.ToLower().Contains(ch1) == true)
                {
                    GetWait(5).Until(d => _filterChoises1);
                    choise.Click();
                    break;
                }
            }

        }

        public void ClickSecondFilterElement(string ch2)
        {
            Driver.Navigate().Refresh();
            _daugiauFiltruButton.Click();
            IList<IWebElement> elementCList2 = Driver.FindElements(By.ClassName("form-check"));
            IWebElement _filterChoises2 = Driver.FindElement(By.ClassName("form-check-input"));

            foreach (IWebElement choise1 in elementCList2)
            {
                if (choise1.Text.ToLower().Contains(ch2) == true)
                {
                    GetWait(5).Until(d => _filterChoises2);
                    choise1.Click();
                    break;
                }
            }
        }
        public void ClickThirdFilterElement(string ch3)
        {
            Driver.Navigate().Refresh();
            _daugiauFiltruButton.Click();
            IList<IWebElement> elementCList3 = Driver.FindElements(By.ClassName("form-check"));
            IWebElement _filterChoises3 = Driver.FindElement(By.ClassName("form-check-input"));

            foreach (IWebElement choise2 in elementCList3)
            {
                if (choise2.Text.ToLower().Contains(ch3) == true)
                {
                    GetWait(5).Until(d => _filterChoises2);
                    choise2.Click();
                    break;
                }
            }
        }
        public void ClickForthFilterElement(string ch4)
        {
            Driver.Navigate().Refresh();
            _daugiauFiltruButton.Click();
            IList<IWebElement> elementCList4 = Driver.FindElements(By.ClassName("form-check"));
            IWebElement _filterChoises4 = Driver.FindElement(By.ClassName("form-check-input"));

            foreach (IWebElement choise3 in elementCList4)
            {
                if (choise3.Text.ToLower().Contains(ch4) == true)
                {
                    GetWait(5).Until(d => _filterChoises2);
                    choise3.Click();
                    break;
                }
            }
        }
        public void EvaluateFilterFunction(string el1, string el2, string el3)
        {
            int rastuPrekiuKiekis = _elementPList.Count;

            int prekiuAtitinkanciAprasymaKiekis = 0;

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
            Assert.AreEqual(rastuPrekiuKiekis, prekiuAtitinkanciAprasymaKiekis, "Filtered goods varies from expected");
        }

    }
}
