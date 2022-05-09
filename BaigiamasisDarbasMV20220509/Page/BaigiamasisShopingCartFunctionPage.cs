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
        //Konstruktorius Web driveriui:
        public BaigiamasisShoppingCartFunctionPage(IWebDriver webDriver) : base(webDriver) { }

        //Elementu sarasas:
        private IWebElement _shoppingCartButton => Driver.FindElement(By.CssSelector("#root > header > div.header-middle > div > div.header-right > div > div > div.dropdownmenu-wrapper > div.dropdown-cart-action > a"));
        
        //Search elemento patikros sarasas:
        private IList<IWebElement> _itemToCartButtonList => Driver.FindElements(By.CssSelector("#root > main > div > div.container > div > div > div.product-list.row > div:nth-child(3) > div > div.flex-grow-1 > div.product-list-product-buy-desktop-block > button.btn-with-icon.btn-add-cart.btn.btn-outline-success"));
        private IList<IWebElement> _itemResultsNameList => Driver.FindElements(By.ClassName("product-title"));
        private IWebElement _shoppingCartContent => Driver.FindElement(By.CssSelector("#root > main > div > div > div.cart-page-content-column.col-lg-9 > div.cart-page-item-list-container > div > div > div.cart-page-item-info-container > div:nth-child(2) > div > h2"));
        public void AddToShoppingCart()
        {
            _itemToCartButtonList.First().Click();                        
        }
        public void CheckTheItemInShoppingCart()
        {
            string fistItemText = _itemResultsNameList.First().Text;
            _shoppingCartButton.Click();
            string orderedItemText = _shoppingCartContent.Text;
            Assert.IsTrue(fistItemText.ToLower().Contains(orderedItemText.ToLower()), "Ordered item varies from expected");
        } 
    }
}
