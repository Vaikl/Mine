using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using framworkall.Pages;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace framworkall.Tests
{
    [TestFixture]
    class Tests
    {
        private Main mainPage1;
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void StartBrowser()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void CityTwoDidntExistTest()
        {
            var cityName = "Minsk";
            var date = "01.03.2019";
            steps.OpenMainPage();
            mainPage1.departure.SendKeys(cityName);
            //  steps.SelectFromCity().SendKeys(cityName);
            mainPage1.departureDate.SendKeys(date);
          //  steps.SelectDepartDate().SendKeys(date);
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage1();
             Assert.AreEqual(errorMessage, "Please enter a 'To' airport.");
        }

        [Test]
        public void SameDepartureAndDestiantionTest()
        {
            var fromCity = "Minsk";
            var toCity = "Minsk";
            var departDay = "01.03.2019";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage1();
            Assert.AreEqual(errorMessage, "Please enter unique 'From' and 'To' airports.");
        }

        [Test]
        public void FromPreviousDateTest()
        {
            var fromCity = "Minsk";
            var toCity = "Moscow";
            var departDay = "03.04.2018";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectDepartDate().SendKeys(departDay);       
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage1();
            Assert.AreEqual(errorMessage, "Please enter a valid 'Depart' date.");
        }

        [Test]
        public void DateRequiredTest()
        {
            var fromCity = "Minsk";
            var toCity = "Moscow";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectToCity().SendKeys(Keys.Enter);
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage1();
            Assert.AreEqual(errorMessage, "Please enter a valid 'Depart' date.");
        }

        [Test]
        public void LimitedPassangersTest()
        {
            steps.OpenMainPage();
            steps.OpenPasssangers();
            Thread.Sleep(2000);
            for (int i=0;i<8;i++)
            steps.IncreaseAdult();
            Assert.Fail();
        }


        [Test]
        public void YouthWoAdult()
        {       
            var fromCity = "Minsk";
            var toCity = "Moscow";
            var departDay = "03.04.2019";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectToCity().SendKeys(Keys.Enter);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            steps.IncreaseYouth();
            steps.DecreaseAdult();
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage2();
            Assert.AreEqual(errorMessage, "About unaccompanied minors");
        }

        [Test]
        public void ChildWoAdult()
        {
            var fromCity = "Minsk";
            var toCity = "Moscow";
            var departDay = "03.04.2019";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectToCity().SendKeys(Keys.Enter);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            steps.IncreaseChild();
            steps.DecreaseAdult();
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage2();
            Assert.AreEqual(errorMessage, "About unaccompanied minors");
        }

        [Test]
        public void BabyWoAdult()
        {
            var fromCity = "Minsk";
            var toCity = "Moscow";
            var departDay = "03.04.2019";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectToCity().SendKeys(Keys.Enter);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            steps.IncreaseBaby();
            steps.DecreaseAdult();
            steps.FindResults();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessage2();
            Assert.AreEqual(errorMessage, "About unaccompanied minors");
        }

        [Test]
        public void StaingDidntExist()
        {
            steps.OpenMainPage();
            steps.OpenHotel();
            steps.FindHotel();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessageHotel();
            Assert.AreEqual(errorMessage, "Please enter a city, hotel name or landmark.");
        }

        [Test]
        public void HotelsDateDidntExist()
        {
            steps.OpenMainPage();
            steps.OpenHotel();
            steps.SelectStauing().SendKeys("Minsk");
            steps.FindHotel();
            Thread.Sleep(2000);
            var errorMessage = steps.GetErrorMessageHotel();
            Assert.AreEqual(errorMessage, "Please enter a check-in date.");
        }
 

        static void Main(string[] args) { 
             }
    }
}
