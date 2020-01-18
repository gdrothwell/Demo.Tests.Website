using NUnit.Framework;

namespace Demo.Tests.Website
{
    [TestFixture("firefox")]
    [TestFixture("chrome")]
    public class TestShoppingCart : TestSetupTeardown
    {
        public TestShoppingCart(string browser) : base(browser) {} 

        [TestCase("PINK DROP SHOULDER OVERSIZED T SHIRT", "Pink", "36")]
        [TestCase("BLACK LUX GRAPHIC T-SHIRT", "Black", "32")]
        public void TestShopForTShirtLadies(string item, string color, string size)
        {
            var ShoppingItemDetails = new ShoppingItemDetails 
            {
                Gender = "LADIES",
                Item = item,
                Color = color, 
                Size = size 
            };

            PageObjectShoppingMain.ClickShoppingItem(
                ShoppingItemDetails.Gender, 
                ShoppingItemDetails.Item);
            PageObjectShoppingItem.SelectShoppingItem(
                ShoppingItemDetails);
            PageObjectNavigation.ClickCartElement();
        }
    }
}
