using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using framworkall.Pages;
using OpenQA.Selenium;

namespace framworkall.Steps
{
    class Steps
    {
        public IWebDriver webDriver;

        private Main mainPage;

        private Hotels hotelPage;

        public void InitBrowser()
        {
            webDriver = Driver.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            webDriver = null;
            Driver.Driver.CloseBrowser();
        }

        public void OpenMainPage()
        {
            mainPage = new Main(webDriver);

            mainPage.OpenPage();
        }

        public IWebElement SelectFromCity()
        {
            return mainPage.departure;
        }

        public IWebElement SelectToCity()
        {
            return mainPage.destination;
        }

        public IWebElement SelectDepartDate()
        {
            return mainPage.departureDate;
        }

        public IWebElement SelectStauing()
        {
            return hotelPage.destinationHotel;
        }

        public void IncreaseAdult()
        {
            mainPage.passangers.Click();
            mainPage.adultPlusValue.Click();
        }

        public void OpenHotel()
        {
            hotelPage.typeHotel.Click();
        }

        public void FindHotel()
        {
            hotelPage.findHotel.Click();
        }

        public void DecreaseAdult()
        {      
            mainPage.adultMinusValue.Click();
        }

        public void IncreaseChild()
        {
            mainPage.passangers.Click();
            mainPage.ChildPlusValue.Click();
        }

        public void IncreaseBaby()
        {
            mainPage.passangers.Click();
            mainPage.babyPlusValue.Click();
        }

        public void IncreaseYouth()
        {
            mainPage.passangers.Click();
            mainPage.youthPlusValue.Click();
        }

        public void FindResults()
        {
            mainPage.find.Click();
        }

        public void OpenHotelPage()
        {
            hotelPage = new Hotels(webDriver);
        }

        public string GetErrorMessage1()
        {
            var errorMessage = mainPage.ErrorMessage1;
            return Convert.ToString(errorMessage.Text);
        }

        public string GetErrorMessage2()
        {
            var errorMessage = mainPage.ErrorMessage2;
            return Convert.ToString(errorMessage.Text);
        }


        public string GetErrorMessageHotel()
        {
            var errorMessage = mainPage.ErrorMessageHotel;
            return Convert.ToString(errorMessage.Text);
        }
    }
}
