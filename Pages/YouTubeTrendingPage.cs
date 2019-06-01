using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YoutubeTesting
{
    public class YouTubeTrendingPage
    {
        private IWebDriver _driver;
        public YouTubeTrendingPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public void ClikcByText(string textToClick)
        {
            _driver.FindElement(By.XPath($"//*[text()='{textToClick}']")).Click();
        }

        public void OpenTrendingVideoByIndex(int index)
        {
            _driver.FindElement(By.XPath($"(//*[@id='grid-container']//*[@id='img'])[{index}]")).Click();
        }

        public string GetTitleByVideoIndex(int index)
        {
            return _driver.FindElement(By.XPath($"(//*[@id='video-title'])[{index}]")).Text;
        }

        public string GetViewsByVideoIndex(int index)
        {
            return _driver.FindElement(By.XPath($"(//*[@id='metadata-line']/*[@class='style-scope ytd-video-meta-block'])[{1+(index-1)*2}]")).Text;
        }


    }
}
