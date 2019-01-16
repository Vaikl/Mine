using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framworkall.Driver
{
    class Driver
    {
        private static IWebDriver driver;
        private Driver() { }
        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(15));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}
