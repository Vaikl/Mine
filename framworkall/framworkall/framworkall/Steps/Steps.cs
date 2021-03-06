﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread.Sleep(2000);
        }

        public void InsertFromCity(string cityName_dep)
        {
            mainPage.departure.Click();
            mainPage.departure.SendKeys(cityName_dep);
            Thread.Sleep(2000);
        }

        public void InserToCity(string cityName_des)
        {
            mainPage.destination.Click();
           mainPage.destination.SendKeys(cityName_des);
            mainPage.destination.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }

        public void SelectDepartDate(string dateDep)
        {
            mainPage.departureDate.SendKeys(dateDep);
            mainPage.departureDate.SendKeys(Keys.Enter);
            mainPage.departureDate.SendKeys(Keys.Enter);
        }

        public void SelectStauing(string hotelDest)
        {
            hotelPage.destinationHotel.Click();
            hotelPage.destinationHotel.SendKeys(hotelDest);
        }

        public void IncreaseAdult()
        {
            mainPage.passangers.Click();
            Thread.Sleep(2000);
            mainPage.adultPlusValue.Click();
        }

        public void OpenHotel()
        {
            hotelPage.typeHotel.Click();
            Thread.Sleep(2000);
        }

        public void FindHotel()
        {
            Thread.Sleep(2000);
            hotelPage.findHotel.Click();
            Thread.Sleep(2000);
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
            mainPage.youthPlusValue.Click();
        }
        public void OpenPasssangers()
        {
            mainPage.passangers.Click();
            Thread.Sleep(2000);
        }

        public void FindResults()
        {
            Thread.Sleep(2000);
            mainPage.find.Click();
            Thread.Sleep(2000);

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
