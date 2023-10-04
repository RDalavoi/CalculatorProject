using CalculatorProject.BaseClass;
using CalculatorProject.PageObject;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V115.Profiler;

namespace CalculatorProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {                
        [Test]
        public void CalculatorTestMethod()
        {
            var equ = "=";
            var calculatorpage = new PageObjectModel(driver);
            calculatorpage.calcMethod(5, 6, "+");
            var outputValue = calculatorpage.result(equ);
            Console.Out.WriteLine(outputValue);
            Thread.Sleep(1000);
            calculatorpage.calcMethod(8, 6, "-");
            outputValue = calculatorpage.result(equ);
            Console.Out.WriteLine(outputValue);
            Thread.Sleep(1000);
            calculatorpage.calcMethod(8, 6, "*");
            outputValue = calculatorpage.result(equ);
            Console.Out.WriteLine(outputValue);
            Thread.Sleep(1000);
            calculatorpage.calcMethod(6, 6, "%");
            outputValue = calculatorpage.result(equ);
            Console.Out.WriteLine(outputValue);
            Thread.Sleep(1000);
        }
    }
}