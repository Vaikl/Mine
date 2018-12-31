using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            // № 9: Невозможность ввода пассажира-младенца(до 2 лет) без сопровождения взрослых
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\artik\Desktop\AutoTest\AutoTest"); //path to ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; //path to my Chrome browser
            driver = new ChromeDriver(service, options);
            driver.Url = "https://www.cheapflights.ca";
            IWebElement element = driver.FindElement(By.ClassName("Common-Widgets-Text-TextInput"));
            element.Click();
            element.SendKeys("Minsk");
            IWebElement element2 = driver.FindElement(By.Name("destination"));
            element2.Click();
            element2.SendKeys("Mos");
            Thread.Sleep(1000);
            element2.SendKeys("cow");
            IWebElement element4 = driver.FindElement(By.ClassName("dateInput"));
            element4.Click();
            element4.SendKeys("");
            Thread.Sleep(2000);
            element4.SendKeys("01.");
            Thread.Sleep(2000);
            element4.SendKeys("03.");
            Thread.Sleep(2000);
            element4.SendKeys("2019");
            Thread.Sleep(2000);
            element4.SendKeys(OpenQA.Selenium.Keys.Enter);
            element4.SendKeys(OpenQA.Selenium.Keys.Enter);
            IWebElement element5 = driver.FindElement(By.ClassName("hasValue"));
            element5.Click();
            Thread.Sleep(2000);
            IWebElement element1 = driver.FindElement(By.XPath("//div[contains(@id, 'seatInfant')]//div[@class='col-numberbox-button']//button[@aria-label='Increment']"));
            element1.Click();
            IWebElement element6 = driver.FindElement(By.XPath("//div[contains(@id, 'adults')]//div[@class='col-numberbox-button']//button[@aria-label='Decrement']"));
            element6.Click();
            IWebElement element3 = driver.FindElement(By.ClassName("button-col"));
            element3.Click();
        }
    }
}
