using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    //Inherited
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        //Item to identify Homepage
        private By productSelector = By.CssSelector(".invetory_item");

        public void OpenProduct(string productName)
        {
            var products = FindElements(productSelector);
            Console.WriteLine("Home page identified");

        }
    }
}
