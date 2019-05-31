using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace YoutubeTesting
{
    public class FirstTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.youtube.com");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void FirstSeleniumTest()
        {
            var TrendingVideos = new TC_01_OpenTrendingVideo(_driver);

        }

    }
}
