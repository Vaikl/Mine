using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framworkall.Pages
{
    class Main
    {
        private const string BASE_URL = "https://www.cheapflights.ca";
        [FindsBy(How = How.ClassName, Using = "Common-Widgets-Text-TextInput")]
        public IWebElement departure { get; set; }
     
        [FindsBy(How = How.XPath, Using = "//ul[contains(@class, 'errorMessages')]//li//ul//li")]
        public IWebElement ErrorMessage1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class, 'errorMessages')]//li//p")]
        public IWebElement ErrorMessage2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class, 'errorMessages')]//li")]
        public IWebElement ErrorMessageHotel { get; set; }

        [FindsBy(How = How.Name, Using = "destination")]
        public IWebElement destination { get; set; }

        [FindsBy(How = How.ClassName, Using = "dateInput")]
        public IWebElement departureDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "button-col")]
        public IWebElement find { get; set; }

        [FindsBy(How = How.ClassName, Using = "hasValue")]
        public IWebElement passangers { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@title='Increment']")]
        public IWebElement adultPlusValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'youth')]//div[@class='col-numberbox-button']//button[@aria-label='Increment']")]
        public IWebElement youthPlusValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'adults')]//div[@class='col-numberbox-button']//button[@aria-label='Decrement']")]
        public IWebElement adultMinusValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'seatInfant')]//div[@class='col-numberbox-button']//button[@aria-label='Increment']")]
        public IWebElement babyPlusValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'child')]//div[@class='col-numberbox-button']//button[@aria-label='Increment']")]
        public IWebElement ChildPlusValue { get; set; }

        private IWebDriver webDriver;

        public Main(IWebDriver driver)
        {
            webDriver = driver;

            PageFactory.InitElements(webDriver, this);
        }

        public void OpenPage()
        {
            webDriver.Navigate().GoToUrl(BASE_URL);
        }
    }
}
