using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorProject.BaseClass;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using OpenQA.Selenium.DevTools.V115.Debugger;

namespace CalculatorProject.PageObject
{
    public class PageObjectModel
    {

        IWebDriver driver;

        public PageObjectModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickNumber(int number)
        {

            var digit = driver.FindElements(By.XPath("//div[@id ='panel']//div[@class='row']/input"));
            foreach (var num in digit)
            {
                var expNumber = num.GetAttribute("value");
                if (Convert.ToInt32(expNumber) == number)
                {
                    num.Click();
                    break;
                }
                 
            }

        }
        public void clickSymbol(string symbol)
        {
            var sign = driver.FindElements(By.XPath("//div[@id ='panel']//input"));
            foreach (var expSymbol in sign)
            {
                if (expSymbol.GetAttribute("value") == symbol)
                {
                    expSymbol.Click();
                    break;
                }
                
            }
        }
        public int? result(string equal)
        {
            var resultEq = driver.FindElement(By.XPath("//div[@class='y-row']//input[@data-type='command']"));
            if (resultEq.GetAttribute("value") == equal)
            {
                resultEq.Click();
               
            }
            var value = driver.FindElement(By.XPath("//div[@id='display']/div")).Text;
            return  Convert.ToInt32(value);
        }

        public void calcMethod(int num1, int num2, string symbol)
        {
            this.clickNumber(num1);
            this.clickSymbol(symbol);
            this.clickNumber(num2);             
        }
    }
}

