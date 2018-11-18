using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjLab.Objs
{
    class MainPage
    {
        
        [FindsBy(How = How.ClassName, Using = "Common-Widgets-Text-TextInput")]
        private IWebElement ElementFrom;
        [FindsBy(How = How.Name, Using = "destination")]
        private IWebElement ElementTo;
        [FindsBy(How = How.ClassName, Using = "dateInput")]
        private IWebElement ElementDate;
        [FindsBy(How = How.ClassName, Using = "button-col")]
        private IWebElement ElementSearch;
        /*IWebElement ElementFrom = driver.FindElement(By.ClassName("Common-Widgets-Text-TextInput"));
        IWebElement ElementTo = driver.FindElement(By.Name("destination"));
        IWebElement ElementDate = driver.FindElement(By.ClassName("dateInput"));
        IWebElement ElementSearch = driver.FindElement(By.ClassName("button-col"));*/
        private static IWebDriver driver;
        public MainPage()
        {
            IWebDriver _driver = Browser.OpenBrowser();
            driver = _driver;
#pragma warning disable CS0618 // Тип или член устарел
            PageFactory.InitElements(driver, this);

        }
        public void setFromAndTo(string TownFrom, string TownTo)
        {
            ElementFrom.Click();
            ElementFrom.SendKeys(TownFrom);
            Thread.Sleep(2000);
            ElementTo.Click();   
            ElementTo.SendKeys(TownTo);
        }
        public void setDate(String valueDate)
        {
            ElementDate.Click();
            ElementDate.Clear();
            ElementDate.SendKeys(valueDate);
            ElementDate.SendKeys(Keys.Enter);
        }
        public void clickButtonSearch()
        {
            ElementSearch.Click();
        }
    }
}
