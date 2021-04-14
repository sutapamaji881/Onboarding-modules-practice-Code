using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject
{
    public class Tests
    {
        String test_url = "https://www.google.com";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Url = test_url;

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();

            Console.WriteLine("Test Passed");
        }
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}