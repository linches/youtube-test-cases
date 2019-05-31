using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeTesting
{
    class TC_01_OpenTrendingVideo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com");
            driver.Navigate().GoToUrl("https://www.youtube.com/feed/trending");
            //IWebElement element = driver.FindElement(By.Id("endpoint"));
            
        }
    }
}
