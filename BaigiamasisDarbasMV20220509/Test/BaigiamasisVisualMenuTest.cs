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
    class BaigiamasisVisualMenuTest : BaseTest
    {
        
        [Test]
        public static void CheckVisualMenuFuntionality()
        {
            _baigiamasisPage.NavigateToDefaultPage();
            _baigiamasisPage.ClosePopUp();          
            _baigiamasisPage.ClickVisosKategorijosButton();            
            _baigiamasisPage.ClickVisualButtons();
            _baigiamasisPage.CheckElementsInPuslaidininkiai();
        }    
        
    }
}
