using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_6
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            // ТЕСТ: Ограниченное число пассажиров
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\artik\Desktop\AutoTest\AutoTest"); //path to ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; //path to my Chrome browser
            driver = new ChromeDriver(service, options);
            driver.Url = "https://www.cheapflights.ca";
            IWebElement element5 = driver.FindElement(By.ClassName("hasValue"));
            element5.Click();
            Thread.Sleep(2000);
            IWebElement element1 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element1.Click();
            IWebElement element2 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element2.Click();
            IWebElement element3 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element3.Click();
            IWebElement element4 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element4.Click();
            IWebElement element6 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element6.Click();
            IWebElement element7 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element7.Click();
            IWebElement element = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element.Click();
            IWebElement element8 = driver.FindElement(By.XPath("//button[@title='Increment']"));
            element8.Click();
        }
    }
}
