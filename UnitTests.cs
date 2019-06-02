using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using YoutubeTesting.Pages;

namespace YoutubeTesting
{
    public class FirstTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new  WebDriverManager().GetDriver("https://www.youtube.com");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void FirstSeleniumTest()
        {
            var trendingVideos = new YouTubeTrendingPage(_driver);
            trendingVideos.ClikcByText("Trending");
            Thread.Sleep(3000);
            var titleOnTrendingPage = trendingVideos.GetTitleByVideoIndex(1);
            var viewCountOnTrendingPage = trendingVideos.GetViewsByVideoIndex(1);
            trendingVideos.OpenTrendingVideoByIndex(1);

            var videoPage = new VideoPage(_driver);
            Thread.Sleep(3000);
            var titleOnVideoPage = videoPage.GetVideoTitile();
            var viewCountOnVideoPage = videoPage.GetVideoViews();

            Assert.AreEqual(titleOnTrendingPage, titleOnVideoPage);
            Assert.AreEqual(viewCountOnTrendingPage, viewCountOnVideoPage);
        }
    }
}
