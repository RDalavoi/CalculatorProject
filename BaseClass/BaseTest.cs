using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

       [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
