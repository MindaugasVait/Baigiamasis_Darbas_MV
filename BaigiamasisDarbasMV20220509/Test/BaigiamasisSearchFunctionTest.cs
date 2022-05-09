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
    class BaigiamasisSearchFunctionTest : BaseTest
    {
        [Test]
        public static void ClosePopUpWindow()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();           
        }
        
        [TestCase("---Kabelis Vienagyslis Varinis---", "kabelis", "vienagyslis", "varinis", TestName = "Search for cable")]
        [TestCase("---npn 0.1a 0.5w to92---", "npn", "to92", "0.1a", TestName = "Search for transistor")]
        [TestCase("---Resistor 10k Axial Metal-Oxide---", "10k", "axial", "metal oxide", TestName = "Search for resistor")]


        public static void CheckSearchFunctionality(string searchingFor, string el1, string el2, string el3)
        {
            _baigiamasisPage.NavigateToDefaultPage();
            //_baigiamasisPage.ClosePopUp();
            //_baigiamasisSearchFunctionPage.GoingOutOfVisosKategorijosMenu();            
            _baigiamasisSearchFunctionPage.SubmitSearch(searchingFor);
            _baigiamasisSearchFunctionPage.EvaluateTestSearchResults(el1, el2, el3);
        }
    }
}
