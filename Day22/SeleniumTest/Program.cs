using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void MainM(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Navigate().GoToUrl("https://www.flipkart.com/");
            //driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            //IWebElement element = driver.FindElement(By.Id("userName"));
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement element = driver.FindElement(By.Name("q"));
            
            element.SendKeys("C# .Net");
            
            IWebElement clickElement = driver.FindElement(By.Name("btnK"));
            clickElement.Click();
            string title = driver.Title;
            //driver.Quit();
            Console.WriteLine(title);
        }
    }
}