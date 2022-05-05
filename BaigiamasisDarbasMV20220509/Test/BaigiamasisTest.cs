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
    class BaigiamasisTest : BaseTest
    {
        [Test]

        public static void TestSelectionButtons()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisPage.ClickVisosKategorijosButton();
            //_baigiamasisPage.ClickBodyElement();
            _baigiamasisPage.ClickElektronikosKomponentai();
            _baigiamasisPage.ClickAktyvusKomponentai();
            _baigiamasisPage.ClickPuslaidininkiai();
            _baigiamasisPage.ClickVisiTranzistoriai();
            _baigiamasisPage.ClickTranzistoriai();
            _baigiamasisPage.ClickDaugiauFiltruButton();
            //_baigiamasisPage.ClickKorpusasTO220Selections();
        }
    }
}
