using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriverTestsDemo
{
    [TestFixture]
    public class ChromeTests
    {
        private ChromeDriver _driver;

        [SetUp]
        public void TestInit()
        {
            ////var chromeOptions = new ChromeOptions();
            ////chromeOptions.AddArguments("headless");
            _driver = new ChromeDriver();           
        }

        [TearDown]
        public void TestCleanUp()
        {
            _driver.Quit();
        }

        [Test]
        public void NavigateToAutomateThePlanet()
        {
            _driver.Navigate().GoToUrl("https://www.automatetheplanet.com/selenium-webdriver-4-overview/");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement myElement = wait.Until((d) => d.FindElement(By.Id("someDynamicElement")));
            myElement.Click();

            Assert.AreEqual("Most Complete Selenium WebDriver 4.0 Overview", _driver.Title);
        }

         [Test]
        public void NavigateToBellatrix()
        {
            _driver.Navigate().GoToUrl("https://www.automatetheplanet.com/selenium-webdriver-4-overview/");

             var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            var el = webDriverWait.Until(ExpectedConditions.ElementExists(By.Id("someDynamicElement")));
            var el1 = webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("someDynamicElement")));



            Thread.Sleep(5000);
            Assert.AreEqual("Most Complete Selenium WebDriver 4.0 Overview", _driver.Title);
        }
    }
}