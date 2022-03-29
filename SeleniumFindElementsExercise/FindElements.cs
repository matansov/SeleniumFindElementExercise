using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumFindElementExercise
{
    internal class FindElements
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver("c:\\");
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.guru99.com/test/ajax.html";

            var elements = driver.FindElements(By.Name("name"));
            Console.WriteLine("Number of elements: " + elements.Count);

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine("Radion button text: " + elements[i].GetAttribute("value"));
            }
        }
    }
}
