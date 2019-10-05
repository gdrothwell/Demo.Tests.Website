using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Demo.Tests.Website
{
    public class TestSetupTeardown
    {
        private static IWebDriver driver;
        private string browser;

        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public TestSetupTeardown(string browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void Setup()
        {
            switch (browser)
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.FullScreen();
            driver.Navigate().GoToUrl("http://shop.demoqa.com/");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}