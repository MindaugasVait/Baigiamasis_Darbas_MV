using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaigiamasisDarbasMV20220509.Page;

namespace BaigiamasisDarbasMV20220509.Test
{
    class BaigiamasisLemonaKontaktaiCheckTest : BaseTest
    {
        [Test]
        public static void CheckLemonaShopInformation()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisLemoneKontaktaiCheckPage.ClickKontaktaiButton();
            _baigiamasisLemoneKontaktaiCheckPage.CheckShopInfo("UAB “Lemona”", "P. Lukšio g. 19, Vilnius, LT-09132", "+370 (616) 19222", "I-V 8:00 - 18:00, VI 10:00 - 15:00");
        }

    }
}
