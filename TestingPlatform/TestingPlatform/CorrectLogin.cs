using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace TestingPlatform
{
    class CorrectLogin
    {

        private static FirefoxOptions options;
        private static IWebDriver driver;
        private static WebDriverWait wait;

        public static void Setup()
        {
            options = new FirefoxOptions();
            options.BrowserExecutableLocation = (@"C:\Users\wojnarowski_b\AppData\Local\Mozilla Firefox\firefox.exe");
            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"D:\SoftwareTesting\Sources\geckodriver.exe");
            driver = new FirefoxDriver(options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public static void Test()
        {
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");


            var UserName = driver.FindElement(By.XPath("//*/input[@name='userName']"));
            var Password = driver.FindElement(By.XPath("//*/input[@name='password']"));
            var Submit = driver.FindElement(By.XPath("//*/input[@name='submit']"));

            UserName.Click();
            UserName.SendKeys("Bartolini");

            Password.Click();
            Password.SendKeys("qwerty");

            Submit.Click();
            Console.WriteLine("we are  logging");



            var le = driver.FindElement(By.XPath("//*/h3[text()=\"Login Successfully\"]"));

            Console.WriteLine("checking if it  is loged");

            Assert.AreEqual("Login Successfully", le.Text);
            Console.WriteLine(string.Equals("Login Successfully", le.Text));

        }

        public static void TearDown()
        {
            driver.Quit();
            Console.WriteLine("Test Completed");
        }


    }
}
