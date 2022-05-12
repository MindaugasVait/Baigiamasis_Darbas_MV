using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbasMV20220509.Test
{
    class BaigiamasisShopingCartFunctionTest : BaseTest
    {
        
        [Test]
        public static void CheckShoppingCartFunctionality()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisSearchFunctionPage.SubmitSearch("NPN ", "0.1A ", "TO92");
            _baigiamasisSearchFunctionPage.EvaluateTestSearchResults("npn", "to92", "0.1a");
            //_baigiamasisShoppingCartFunctionPage.FirstItemToShoppingCartData(0);
            _baigiamasisShoppingCartFunctionPage.AddItemToShoppingCart(0);
            //_baigiamasisSearchFunctionPage.SubmitSearch("Kabelis ", "Vienagyslis ", "Varinis");
            //_baigiamasisSearchFunctionPage.EvaluateTestSearchResults("kabelis", "vienagyslis", "varinis");            
            //_baigiamasisShoppingCartFunctionPage.SecondItemToShoppingCartData(0);
            //_baigiamasisShoppingCartFunctionPage.AddItemToShoppingCart(0);
            //_baigiamasisShoppingCartFunctionPage.CheckItemsInShoppingCart(0, 1);
            //_baigiamasisShoppingCartFunctionPage.CheckTheItemInShoppingCart(1, 1);
            //_baigiamasisShoppingCartFunctionPage.MoveFromPopUp();
            // 
        }
    }
}
