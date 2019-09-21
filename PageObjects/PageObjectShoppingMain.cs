using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demo.Tests.Website
{
    public static class PageObjectShoppingMain
    {
        private static IWebDriver driver => TestSetupTeardown.Driver;
        private static WebDriverWait wait => new WebDriverWait(
            driver, 
            TimeSpan.FromSeconds(15));

        private static IWebElement selectGender(string gender) => driver.FindElements(
            By.TagName("span"))
            .First(x => x.Text
            .Contains(gender));
        private static IWebElement shoppingItem(string item) => driver.FindElement(
            By.LinkText(item));

        public static void ClickShoppingItem(string gender, string item)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(
                "arguments[0].scrollIntoView(true)", 
                selectGender(gender));

            shoppingItem(item).Click();
        }
    }
}