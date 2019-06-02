

using OpenQA.Selenium;

namespace YoutubeTesting.Pages
{
    public class VideoPage
    {
        private IWebDriver _driver;
        private IWebElement mainVideoViews => _driver.FindElement(By.XPath("//yt-view-count-renderer/span[2]"));

        IWebElement mainVideoTitle => _driver.FindElement(By.XPath("//yt-formatted-string[@class='style-scope ytd-video-primary-info-renderer']"));

        public VideoPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public string GetVideoTitile()
        {
            return mainVideoTitle.Text;
        }

        public string GetVideoViews()
        {
            return mainVideoViews.GetAttribute("innerText");
        }

    }
}

