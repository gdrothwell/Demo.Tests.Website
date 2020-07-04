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
                    var ffoptions = new FirefoxOptions();
                    ffoptions.AddArgument("-headless");
                    driver = new FirefoxDriver(ffoptions);
                    break;

                case "chrome":
                    var coptions = new ChromeOptions();
                    coptions.AddArgument("--headless");
                    coptions.AddArgument("--window-size=1280,1696");
                    driver = new ChromeDriver(coptions);
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