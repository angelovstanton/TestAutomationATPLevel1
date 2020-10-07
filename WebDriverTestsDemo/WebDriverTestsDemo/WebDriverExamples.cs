using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace WebDriverTestsDemo
{
    [TestFixture]
    public class WebDriverExamples
    {
        private IWebDriver _driver;

        [SetUp]
        public void TestInit()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TestCleanup()
        {
            _driver.Quit();
        }

        [Test]
        public void CheckSeleniumDocsLinks()
        {
            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/en/getting_started");

            IWebElement gridLink = _driver.FindElement(By.XPath("//a[contains(text(),'Grid')][1]"));
            gridLink.Click();

            var gridHeader = _driver.FindElement(By.Id("grid"));
            Assert.AreEqual("Grid", gridHeader.Text);

            var componentsLink = _driver.FindElement(By.XPath("//a[contains(text(),'Components')][1]"));
            componentsLink.Click();

            var componentsPageHeader = _driver.FindElement(By.TagName("h1"));
            Assert.AreEqual("Components", componentsPageHeader.Text);


            Actions actions = new Actions(_driver);
            var gitHubRepoLink = _driver.FindElement(By.XPath("//a[text()='GitHub repo']"));
            actions.MoveToElement(gitHubRepoLink).Perform();
            gitHubRepoLink.Click();

            var githubRepoPageHeader = _driver.FindElements(By.TagName("h1"))[1];
            Assert.AreEqual("Selenium Site and Documentation", githubRepoPageHeader.Text);
        }
    }
}
