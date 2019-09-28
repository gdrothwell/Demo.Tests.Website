using NUnit.Framework;

namespace Demo.Tests.Website
{
    public class TestShoppingCart : TestSetupTeardown
    {
        [Test]
        public void TestShopForLadiesItem()
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
        public void TestShopForMensItem()
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
