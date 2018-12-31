using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 3: Проверка невозможности ввода только одной точки назначения
            IWebDriver driver;         
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\artik\Desktop\AutoTest\AutoTest"); //path to ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; //path to my Chrome browser
            driver = new ChromeDriver(service, options);
            driver.Url = "https://www.cheapflights.ca";
            IWebElement element = driver.FindElement(By.ClassName("Common-Widgets-Text-TextInput"));
            element.Click();
            element.SendKeys("Minsk");
            element.SendKeys(OpenQA.Selenium.Keys.Enter);
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
            IWebElement element3 = driver.FindElement(By.ClassName("button-col"));
            element3.Click();
        }
    }
}
