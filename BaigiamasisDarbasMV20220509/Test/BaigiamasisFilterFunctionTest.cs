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
    class BaigiamasisFilterFunctionTest : BaseTest
    {
        [Test]

       public static void CheckFilterFunctionality()
       {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisNavigateMenuPage.ClickVisosKategorijosButton();
            _baigiamasisNavigateMenuPage.ClickVisualButtons();
            _baigiamasisFilterFunctionPage.GoToTransistorFilterElement();
            _baigiamasisFilterFunctionPage.ClickFirstFilterElement("kauno parduotuvė");
            _baigiamasisFilterFunctionPage.ClickSecondFilterElement("npn");
            _baigiamasisFilterFunctionPage.ClickThirdFilterElement("0.5 w");
            _baigiamasisFilterFunctionPage.ClickForthFilterElement("0.1 a");
            _baigiamasisFilterFunctionPage.EvaluateFilterFunction("npn", "0.1a", "0.5w");
        }
    }
}
