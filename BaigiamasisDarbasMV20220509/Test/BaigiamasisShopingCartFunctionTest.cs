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
            _baigiamasisShoppingCartFunctionPage.AddItemToShoppingCart(0);            
        }
    }
}
