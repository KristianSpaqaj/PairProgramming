using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingTests
{
    [TestClass]
    public class FrontendTests
    {
        private static readonly string _driverDirectory = @"C:\WebDrivers";
        //private static readonly string _driverDirectory = @"C:\Code\3.Semester\ChromeDriver";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext ctx)
        {
            _driver = new ChromeDriver(_driverDirectory);
           // _driver = new FirefoxDriver(_driverDirectory);
        }

        [TestCleanup]
        public void Clean()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void Data_ShouldLoad_OnStartup()
        {
            string url = @"C:\Users\gstok\source\repos\KristianSpaqaj\PairProgramming\PairProgrammingWebApp\index.html";
            //string url = @"C:\Users\sunsh\source\repos\PairProgramming\PairProgrammingWebApp\index.html";
            _driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement list = wait.Until((d) => d.FindElement(By.Id("recordsList")));
            Assert.IsTrue(list.Text.Length > 0);
        }
    }
}
