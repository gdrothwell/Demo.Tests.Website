using NUnit.Framework;

namespace Demo.Tests.Website
{
    [TestFixture("firefox")]
    [TestFixture("chrome")]
    public class TestShoppingCart : TestSetupTeardown
    {
        public TestShoppingCart(string browser) : base(browser) {} 

        [Test]
        public void TestShopForTShirt1()
        {
            var ShoppingItemDetails = new ShoppingItemDetails 
            {
                Gender = "LADIES",
                Item = "PINK DROP SHOULDER OVERSIZED T SHIRT",
                Color = "Pink", 
                Size = "36" 
            };

            PageObjectShoppingMain.ClickShoppingItem(
                ShoppingItemDetails.Gender, 
                ShoppingItemDetails.Item);
            PageObjectShoppingItem.SelectShoppingItem(
                ShoppingItemDetails);
            PageObjectNavigation.ClickCartElement();
        }

        [Test]
        public void TestShopForTShirt2()
        {
            var ShoppingItemDetails = new ShoppingItemDetails
            {
                Gender = "LADIES",
                Item = "BLACK LUX GRAPHIC T-SHIRT",
                Color = "Black",
                Size = "32"
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
