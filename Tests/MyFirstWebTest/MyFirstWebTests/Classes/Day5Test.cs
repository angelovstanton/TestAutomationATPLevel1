using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace MyFirstWebTests
{
    [TestClass]
    public class Day5Test
    {
        private ChromeDriver _driver;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Console.WriteLine("Execute ClassInitialize");
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Execute Before Each Test");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            _driver = new ChromeDriver(options);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("After Each Test");
            _driver?.Quit();
            //_driver?.Dispose();
            //_driver? = null;
        }


        [TestMethod]
        [TestCategory("Sheir-FirstWeb")]
        [Ignore]
        public void NavigateGettingStarted()
        {
            string url = "https://www.selenium.dev/documentation/en/getting_started";

            _driver.Navigate().GoToUrl(url);
            WebDriverWait waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            //Assert.AreEqual<string>("Getting started :: Documentation for Selenium", _driver.Title);

            string gridXpath = @"//*[@id='sidebar']/div[2]/ul/li[9]/a";
            IWebElement elGrid = waiter.Until((d) => d.FindElement(By.XPath(gridXpath)));
            elGrid.Click();

            Assert.AreEqual<string>("Grid :: Documentation for Selenium", _driver.Title);


            string grid4ComponentXpath = @"//*[@id='sidebar']/div[2]/ul/li[9]/ul/li[4]/ul/li[1]/a";
            //IWebElement elComponent = waiter.Until((d) => d.FindElement(By.XPath(grid4ComponentXpath)));
            var el = waiter.Until(ExpectedConditions.ElementExists(By.XPath(grid4ComponentXpath)));
            //var elComponent = waiter.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(grid4ComponentXpath)));
            var elComponent = waiter.Until(ExpectedConditions.ElementToBeClickable(By.XPath(grid4ComponentXpath)));
            Thread.Sleep(5000);
            el.Click();

            Assert.AreEqual<string>("Components :: Documentation for Selenium", _driver.Title);
            //throws exception on the Click()
        }



        [TestMethod]
        [TestCategory("Sheir-FirstWeb")]
        public void LoginBlueHostWebmailRejected()
        {
            string url = "https://login.bluehost.com/hosting/webmail";

            _driver.Navigate().GoToUrl(url);
            WebDriverWait waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            Assert.AreEqual<string>("Webmail Login - Bluehost", _driver.Title);


            string eamilId = "email";
            IWebElement elEmail = waiter.Until((d) => d.FindElement(By.Id(eamilId)));
            elEmail.Clear();
            elEmail.SendKeys("sheir@magma.ca");


            string passwordId = "password";
            IWebElement elPassword = waiter.Until((d) => d.FindElement(By.Id(passwordId)));
            elPassword.Clear();
            elPassword.SendKeys("secret");


            string loginId = "next";
            IWebElement elLogin = waiter.Until((d) => d.FindElement(By.Name(loginId)));
            elLogin.Click();

            //Thread.Sleep(3000);
            string errorId = "error";
            var elError = waiter.Until(ExpectedConditions.ElementExists(By.ClassName(errorId)));
            Assert.IsNotNull(elError);
            Console.WriteLine(elError.Text);
            //Assert.AreEqual<string>("Invalid login attempt. That account doesn't seem to be available.", el.Text);
            
            var el = waiter.Until(ExpectedConditions.TextToBePresentInElement(elError, "Invalid login attempt. That account doesn't seem to be available."));
            Console.WriteLine(el);
            Assert.IsTrue(el);
        }

        [TestMethod]
        [TestCategory("Sheir-FirstWeb")]
        public void LoginBlueHostWebmailNoCredentials()
        {
            string url = "https://login.bluehost.com/hosting/webmail";

            _driver.Navigate().GoToUrl(url);
            WebDriverWait waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            Assert.AreEqual<string>("Webmail Login - Bluehost", _driver.Title);


            string eamilId = "email";
            IWebElement elEmail = waiter.Until((d) => d.FindElement(By.Id(eamilId)));
            elEmail.Clear();
            //elEmail.SendKeys("sheir@magma.ca");


            string passwordId = "password";
            IWebElement elPassword = waiter.Until((d) => d.FindElement(By.Id(passwordId)));
            elPassword.Clear();
            //elPassword.SendKeys("secret");


            string loginId = "next";
            IWebElement elLogin = waiter.Until((d) => d.FindElement(By.Name(loginId)));
            elLogin.Click();

            //Thread.Sleep(3000);
            string errorId = "error";
            var elError = waiter.Until(ExpectedConditions.ElementExists(By.ClassName(errorId)));
            Assert.IsNotNull(elError);
            Console.WriteLine(elError.Text);

            var el = waiter.Until(ExpectedConditions.TextToBePresentInElement(elError, "Email is required."));
            Console.WriteLine(el);
            Assert.IsTrue(el);

        }
    }
}
