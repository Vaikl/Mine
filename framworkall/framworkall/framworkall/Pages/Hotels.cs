using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framworkall.Pages
{
    class Hotels
    {
        [FindsBy(How = How.ClassName, Using = "hotelsLink")]
        public IWebElement typeHotel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Staying in']")]
        public IWebElement destinationHotel { get; set; }

        [FindsBy(How = How.ClassName, Using = "searchBtn")]
        public IWebElement findHotel { get; set; }

        private IWebDriver webDriver { get; set; }

        public Hotels(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(webDriver, this);
        }
    }
}
