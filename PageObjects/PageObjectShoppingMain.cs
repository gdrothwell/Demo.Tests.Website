using System.Linq;
using OpenQA.Selenium;

namespace Demo.Tests.Website
{
    public static class PageObjectShoppingMain
    {
        private static IWebDriver driver => TestSetupTeardown.Driver;

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