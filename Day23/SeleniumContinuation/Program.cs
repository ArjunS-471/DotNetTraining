using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void MainDem(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            IWebElement elementName = driver.FindElement(By.Id("et_pb_contact_name_0"));
            elementName.SendKeys("Ronaldo");

            IWebElement elementMessage = driver.FindElement(By.Id("et_pb_contact_message_0"));
            elementMessage.SendKeys("Messi");

            IWebElement elementSubmit = driver.FindElement(By.Name("et_builder_submit_button"));
            elementSubmit.Click();

            IWebElement elementName2 = driver.FindElement(By.Id("et_pb_contact_name_1"));
            elementName2.SendKeys("Zidane");

            IWebElement elementMessage2 = driver.FindElement(By.Id("et_pb_contact_message_1"));
            elementMessage2.SendKeys("Figo");

            //IWebElement elementSum = driver.FindElement(By.ClassName("input.et_pb_contact_captcha"));
            IWebElement elementSum = driver.FindElement(By.XPath("//*[@id=\"et_pb_contact_form_1\"]/div[2]/form/div/div/p/input"));
            elementSum.SendKeys("27");

            IWebElement elementSubmit2 = driver.FindElement(By.XPath("//*[@id=\"et_pb_contact_form_1\"]/div[2]/form/div/button"));
            elementSubmit2.Click();

            string title = driver.Title;
            //driver.Quit();
            Console.WriteLine(title);
        }
    }
}