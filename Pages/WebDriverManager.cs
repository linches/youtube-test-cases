using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace YoutubeTesting.Pages
{
    public class WebDriverManager
    {
        public IWebDriver GetDriver(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
