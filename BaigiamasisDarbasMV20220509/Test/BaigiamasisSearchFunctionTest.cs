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
        
        [TestCase("Kabelis ", "Vienagyslis ", "Varinis", "kabelis", "vienagyslis", "varinis", TestName = "Search for cable")]
        [TestCase("NPN ", "0.1A ", "TO92", "npn", "to92", "0.1a", TestName = "Search for transistor")]
        [TestCase("10k ", "Resistor ", "Axial", "10k", "axial", "resistor", TestName = "Search for resistor")]


        public static void CheckSearchFunctionality(string searchingFor1, string searchingFor2, string searchingFor3, string el1, string el2, string el3)
        {
            _baigiamasisPage.NavigateToDefaultPage();            
            _baigiamasisSearchFunctionPage.SubmitSearch(searchingFor1, searchingFor2, searchingFor3);
            _baigiamasisSearchFunctionPage.EvaluateTestSearchResults(el1, el2, el3);
        }
    }
}
