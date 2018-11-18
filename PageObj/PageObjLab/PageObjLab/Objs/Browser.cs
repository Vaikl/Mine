using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjLab.Objs
{
    class Browser
    {
        public static IWebDriver OpenBrowser()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.cheapflights.ca");
            return Driver;
        }

        
    }
}
