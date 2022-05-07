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
            _baigiamasisPage.ClickVisosKategorijosButton();
            _baigiamasisPage.ClickVisualButtons();
            _baigiamasisPage.GoToTranzistoriaiFilter();
        }
        
        /*
        [Test]
        public static void CheckMegaMenuButtonsFuntionality()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisPage.ClickMegaMenuButtons();
            _baigiamasisPage.CheckElementsInPuslaidininkiai();
        }
        */
        /*  _baigiamasisPage.ClickElektronikosKomponentai();
            _baigiamasisPage.ClickAktyvusKomponentai();
            _baigiamasisPage.ClickPuslaidininkiai();
            _baigiamasisPage.ClickVisiTranzistoriai();
            _baigiamasisPage.ClickTranzistoriai();
            _baigiamasisPage.ClickDaugiauFiltruButton();
            _baigiamasisPage.ClickKorpusasTO220Selections();
        */
    }
}
