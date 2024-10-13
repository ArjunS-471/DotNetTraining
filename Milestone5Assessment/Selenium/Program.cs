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
            var loginPage = new LoginPage(driver);
            var homePage = new HomePage(driver);
            
            //login and home page
            loginPage.Login("standard_user", "secret_sauce");
            homePage.OpenProduct("Sauce Labs Backpack");
            
            driver.Quit();
            Console.WriteLine("");

        }
    }
}