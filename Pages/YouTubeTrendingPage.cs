using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

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
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath($"(//*[@id='grid-container']//*[@id='img'])[{index}]")).Click();
        }

        public string GetTitleByVideoIndex(int index)
        {
            return _driver.FindElement(By.XPath($"(//*[@id='title-wrapper']//a[@title])[{index}]")).Text;
        }

        public string GetViewsByVideoIndex(int index)
        {
            return _driver.FindElement(By.XPath($"(//div[@id='metadata-line']/span[@class='style-scope ytd-video-meta-block'][1])[{index}]")).Text;
        }


    }
}
