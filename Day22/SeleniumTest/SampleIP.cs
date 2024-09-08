using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class SampleIP
    {
        static void MainIP(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://whatismyip.com");
            driver.Manage().Window.Maximize();
            
            IWebElement element = driver.FindElement(By.XPath("//div/a[@id='ipv4']"));
            string ipAddress = element.Text;
            Console.WriteLine(ipAddress);
        }
    }
}
