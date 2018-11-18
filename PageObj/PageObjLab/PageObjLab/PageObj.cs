using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjLab.Objs;

namespace PageObjLab
{
    class TestPageObj
    {
       
        static void Main(string[] args)
        {
            MainPage mainPage = new MainPage();
            mainPage.setFromAndTo("Minsk", "Moscow");
            mainPage.setDate("30.10.2018");
           
        }
    }
}
