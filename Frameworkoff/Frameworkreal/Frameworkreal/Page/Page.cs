using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;
using System.Threading;

namespace Framework
{
    class PageHome
    {
        private const string url = "https://www.cheapflights.ca";
        private const string cityDestination = "Minsk";
        private const string cityDeparture = "Moscow";

        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "Common-Widgets-Text-TextInput")]
        private IWebElement ElementFrom;
        [FindsBy(How = How.Name, Using = "destination")]
        private IWebElement ElementTo;
        [FindsBy(How = How.ClassName, Using = "dateInput")]
        private IWebElement ElementDate;
        [FindsBy(How = How.ClassName, Using = "button-col")]
        private IWebElement ElementSearch;
        [FindsBy(How = How.ClassName, Using = "errorContent")]
        private IWebElement errorMess;

        public IWebElement elementFrom { get => ElementFrom; }
        public IWebElement elementTo { get => ElementTo; }
        public IWebElement elementDate { get => ElementDate; }
        public IWebElement elementSearch { get => ElementSearch; }
        public IWebElement ErrorMess { get => errorMess; }

        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Тип или член устарел
            PageFactory.InitElements(this.driver, this);

        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void PutParametrs()
        {
            elementFrom.SendKeys(cityDestination);
            Thread.Sleep(2000);
            elementTo.SendKeys(cityDeparture);
            Thread.Sleep(2000);
            elementDate.Click();
            elementDate.SendKeys("30.12.2018");
            elementSearch.Click();
        }

        public string GetErrorMes()
        {
            return errorMess.GetAttribute("content");
        }
    }
}
