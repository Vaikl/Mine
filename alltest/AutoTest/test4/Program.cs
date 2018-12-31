using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            // № 6: Обязательный ввод пассажира
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\artik\Desktop\AutoTest\AutoTest"); //path to ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; //path to my Chrome browser
            driver = new ChromeDriver(service, options);
            driver.Url = "https://www.cheapflights.ca";
            IWebElement element5 = driver.FindElement(By.ClassName("hasValue"));
            element5.Click();
        }
    }
}
