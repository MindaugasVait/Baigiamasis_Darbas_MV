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
    class BaigiamasisShoppingCartFunctionPage : BasePage
    {    
        public BaigiamasisShoppingCartFunctionPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement _shoppingCartButton => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-right > div > div > div.dropdownmenu-wrapper > div.dropdown-cart-action > a"));
        private IList<IWebElement> _itemResultsNameList => Driver.FindElements(By.ClassName("product-title"));
        private IList<IWebElement> _itemToCartButtonList => Driver.FindElements(By.CssSelector(".btn-with-icon.btn-add-cart.btn.btn-outline-success"));
        private IList<IWebElement> _shoppingCartContentList => Driver.FindElements(By.CssSelector("h2.font-group-3"));
        
        public void AddItemToShoppingCart (int index)
        {
            string ItemOnSearchList = _itemResultsNameList.ElementAt(index).Text;
            _itemToCartButtonList.ElementAt(index).Click();
            _shoppingCartButton.Click();
            string ItemInShoppingCart = _shoppingCartContentList.ElementAt(index).Text;
            Assert.IsTrue(ItemInShoppingCart.Contains(ItemOnSearchList), "Displayed result varies from expected");
        }
    }
}
