using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFindElementTest
{
    [TestClass]
    public class Tests
    {
        IWebDriver driver;

        [TestMethod]
        public void FindElementTest()
        {
            // arrange phase
            driver = new FirefoxDriver("c:\\");
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.guru99.com/test/ajax.html";

            // act phase
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); // GDPR Consent accept
            wait.Until(drv => driver.FindElement(By.Id("gdpr-consent-tool-wrapper")));
            driver.SwitchTo().Frame("gdpr-consent-notice");
            wait.Until(drv => driver.FindElement(By.Id("save")));
            driver.FindElement(By.Id("save")).Click();
            driver.SwitchTo().DefaultContent();

            driver.FindElement(By.Id("No")).Click();
            driver.FindElement(By.Id("buttoncheck")).Click();

            // assert phase
            Assert.AreEqual("Radio button is checked and it's value is No", driver.FindElement(By.ClassName("radiobutton")).Text);
        }

        [TestMethod]
        public void FindElementTests()
        {
            // arrange phase
            driver = new FirefoxDriver("c:\\");
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.guru99.com/test/ajax.html";

            // act phase
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); // GDPR Consent accept
            wait.Until(drv => driver.FindElement(By.Id("gdpr-consent-tool-wrapper")));
            driver.SwitchTo().Frame("gdpr-consent-notice");
            wait.Until(drv => driver.FindElement(By.Id("save")));
            driver.FindElement(By.Id("save")).Click();
            driver.SwitchTo().DefaultContent();

            var elements = driver.FindElements(By.Name("name"));
            Console.WriteLine("Number of elements: " + elements.Count);

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine("Radion button text: " + elements[i].GetAttribute("value"));
            }

            // assert phase
            Assert.AreEqual(2, elements.Count);
        }

        [TestCleanup]
        public void Close()
        {
            driver.Close();
        }
    }
}