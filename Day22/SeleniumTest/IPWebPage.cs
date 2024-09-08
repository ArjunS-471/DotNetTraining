using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class IPWebPage
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();

            IWebElement element = driver.FindElement(By.XPath("//html/body/center/font"));
            string ipAddress = element.Text;
            Console.WriteLine(ipAddress);
        }
    }
}
