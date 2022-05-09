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
        public static void CheckTextMenuFuntionality()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();
            _baigiamasisLemoneKontaktaiCheckPage.ClickKontaktaiButton();
            _baigiamasisLemoneKontaktaiCheckPage.CheckShopInfo("UAB “Lemona”");

        }

    }
}
