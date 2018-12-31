using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_new_10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            // ТЕСТ №10 Невозможность поиска без ввода даты
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\artik\Desktop\AutoTest\AutoTest"); //path to ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; //path to my Chrome browser
            driver = new ChromeDriver(service, options);
            driver.Url = "https://www.cheapflights.ca";
            IWebElement element = driver.FindElement(By.ClassName("hotelsLink"));
            element.Click();
            Thread.Sleep(4000);
            IWebElement element2 = driver.FindElement(By.XPath("//input[@aria-label='Staying in']"));
            element2.Click();
            element2.SendKeys("Minsk");
            Thread.Sleep(1000);  
            IWebElement element3 = driver.FindElement(By.ClassName("searchBtn"));
            element3.Click();
            Thread.Sleep(5000);
        }
    }
}
