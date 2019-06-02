using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeTesting.Pages
{
    public class YouTubeHomePage
    {
        private IWebDriver _driver;
        public YouTubeHomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SearchVideo(string textLookUpText)
        {
            _driver.FindElement(By.Id("search")).SendKeys(textLookUpText);
            _driver.FindElement(By.Id("search-icon-legacy")).Click();
        }
    }
}


