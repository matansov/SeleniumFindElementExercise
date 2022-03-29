using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumFindElementExercise
{
    internal class FindElement
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver("c:\\");
            driver.Manage().Window.Maximize();

            driver.Url = "http://demo.guru99.com/test/ajax.html";

            driver.FindElement(By.Id("No")).Click();
            driver.FindElement(By.Id("buttoncheck")).Click();
        }
    }
}
