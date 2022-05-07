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
        [TestCase("kabelis, vienagyslis, varinis", "kabelis", "vienagyslis", "varinis")]
        [TestCase("npn, 0.1a, 0.5w, to92", "npn", "to92", "0.1a")]
        [TestCase("resistor, 10k, axial, metal, oxide", "10k", "axial", "metal oxide")]


        public static void CheckSearchFunctionality(string searchingFor, string el1, string el2, string el3)
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisPage.SubmitSearch(searchingFor);
            _baigiamasisPage.EvaluateTestSearchResults(el1, el2, el3);
        }
    }
}
