using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelDemo.Pages;

namespace PageObjectModelDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            driver.Manage().Window.Maximize();
            //POM
            var loginPage = new LoginPage(driver);
            var homePage = new HomePage(driver);
            
            //login ID and password update
            loginPage.Login("standard_user", "secret_sauce");

            //J-Query forclicking button
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string script = "document.getElementById('login-button').click()";
            js.ExecuteScript(script);
            
            homePage.OpenProduct("Sauce Labs Backpack");

            //Using xpath - alternate approach
            IWebElement heading = driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/span"));
            Console.WriteLine(heading.Text);
            if (heading.Text == "Products")
            {
                Console.WriteLine("Login succesful using Xpath");
            }
            else
            {
                Console.WriteLine("Login failed");
            }

            driver.Quit();
            Console.WriteLine("");

        }
    }
}