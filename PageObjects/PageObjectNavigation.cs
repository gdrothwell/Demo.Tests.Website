using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demo.Tests.Website
{
    public static class PageObjectNavigation
    {
        private static IWebDriver driver => TestSetupTeardown.Driver;

        private static IWebElement elementCart => driver.FindElement(
            By.ClassName("cart-item"));

        public static void ClickCartElement()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            wait.Until(x => elementCart.Displayed == true);            
            elementCart.Click();
        }
    }
}