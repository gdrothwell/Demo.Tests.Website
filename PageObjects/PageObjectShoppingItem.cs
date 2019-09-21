using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demo.Tests.Website
{
    public static class PageObjectShoppingItem
    {
        private static IWebDriver driver => TestSetupTeardown.Driver;
        private static WebDriverWait wait => new WebDriverWait(
            driver, 
            TimeSpan.FromSeconds(15));

        private static IWebElement optionColor => driver.FindElement(
            By.Id("pa_color"));
        private static IWebElement optionSize => driver.FindElement(
            By.Id("pa_size"));
        private static IWebElement buttonSubmit => driver.FindElement(
            By.ClassName("single_add_to_cart_button"));

        private static SelectElement selectSize => new SelectElement(optionSize);
        private static SelectElement selectColor => new SelectElement(optionColor);

        public static void SelectShoppingItem(ShoppingItemDetails shoppingItemDetails)
        {
            wait.Until(x => optionColor.Displayed == true);

            selectColor.SelectByText(shoppingItemDetails.Color);
            selectSize.SelectByText(shoppingItemDetails.Size);
            buttonSubmit.Click();
        }
    }
}