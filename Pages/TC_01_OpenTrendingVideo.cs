using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YoutubeTesting
{
    public class TC_01_OpenTrendingVideo
    {
        private IWebDriver _driver;

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com");
            driver.Navigate().GoToUrl("https://www.youtube.com/feed/trending");
            IWebElement element = driver.FindElement(By.Id("endpoint"));
            
        }
    }
}
