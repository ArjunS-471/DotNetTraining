using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Windows;


namespace SeleniumTest
{
    internal class Shopping
    {
        public static void MainShop()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");
            IWebElement passWord = driver.FindElement(By.Id("password"));
            passWord.SendKeys("secret_sauce");
            IWebElement login = driver.FindElement(By.Id("login-button"));
            login.Click();

            IWebElement addToCart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCart.Click();
            IWebElement shoppingCart = driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
            shoppingCart.Click();

            IWebElement checkOut = driver.FindElement(By.Id("checkout"));
            checkOut.Click();

            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("Cristiano");
            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("Ronaldo");
            IWebElement postalCode = driver.FindElement(By.Id("postal-code"));
            postalCode.SendKeys("070707");

            IWebElement continueClick = driver.FindElement(By.Id("continue"));
            continueClick.Click();

            IWebElement finishClick = driver.FindElement(By.Id("finish"));
            finishClick.Click();

            IWebElement messageThankYou = driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2"));
            Console.WriteLine(messageThankYou.Text);

            Console.WriteLine("==============END=========");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            //driver.Quit();
        }
    }
}