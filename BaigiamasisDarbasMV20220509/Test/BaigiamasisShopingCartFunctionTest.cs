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
            _baigiamasisSearchFunctionPage.SubmitSearch("---npn 0.1a 0.5w to92---");
            _baigiamasisSearchFunctionPage.EvaluateTestSearchResults("npn", "to92", "0.1a");
            _baigiamasisShoppingCartFunctionPage.AddToShoppingCart();
            _baigiamasisShoppingCartFunctionPage.CheckTheItemInShoppingCart();
            //_baigiamasisSearchFunctionPage.SubmitSearch("---Resistor 10k Axial Metal-Oxide---");
            //_baigiamasisSearchFunctionPage.EvaluateTestSearchResults("10k", "axial", "metal oxide");
            //_baigiamasisShoppingCartFunctionPage.AddToShoppingCart();
            //_baigiamasisShoppingCartFunctionPage.MoveFromPopUp();
            // 
        }        
    }
}
