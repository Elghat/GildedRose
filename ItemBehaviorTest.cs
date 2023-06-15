using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp
{
    [TestClass]
    public class ItemBehaviorTest
    {
        [TestMethod]
        public void DefaultProductTest()
        {
            //Arrange
            var defaultProduct = new Item() { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            var pasedDefaultProduct = new Item() { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };

            //Act
            ItemBehavior.DefaultItem(defaultProduct);
            ItemBehavior.DefaultItem(pasedDefaultProduct);

            //Assert
            Assert.AreEqual(9, defaultProduct.SellIn);
            Assert.AreEqual(19, defaultProduct.Quality);

            Assert.AreEqual(-1, pasedDefaultProduct.SellIn);
            Assert.AreEqual(18, pasedDefaultProduct.Quality);
        }

        [TestMethod]
        public void AgedProductTest()
        {
            //Arrange
            var agedProduct = new Item() { Name = "Aged Brie", SellIn = 2, Quality = 0 };
            var pasedAgedProduct = new Item() { Name = "Aged Brie", SellIn = 0, Quality = 0 };

            //Act
            ItemBehavior.AgedItem(agedProduct);
            ItemBehavior.AgedItem(pasedAgedProduct);

            //Assert
            Assert.AreEqual(1, agedProduct.SellIn);
            Assert.AreEqual(1, agedProduct.Quality);

            Assert.AreEqual(-1, pasedAgedProduct.SellIn);
            Assert.AreEqual(1, pasedAgedProduct.Quality);
        }

        [TestMethod]
        public void BackstagePassesProductTest()
        {
            //Arrange
            var backstagePassesProduct = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 };
            var pasedBackstagePassesProduct = new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 };

            //Act
            ItemBehavior.BackstagePassesItem(backstagePassesProduct);
            ItemBehavior.BackstagePassesItem(pasedBackstagePassesProduct);

            //Assert
            Assert.AreEqual(4, backstagePassesProduct.SellIn);
            Assert.AreEqual(23, backstagePassesProduct.Quality);

            Assert.AreEqual(-1, pasedBackstagePassesProduct.SellIn);
            Assert.AreEqual(0, pasedBackstagePassesProduct.Quality);
        }
    }
}
