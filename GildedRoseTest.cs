using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void UpdateQualityTest()
        {
            //Arrange
            IList<Item> items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };


            //Act
            var app = new GildedRose(items);
            foreach (var listedItem in items)
            {
                app.UpdateQuality(listedItem);
            }
            

            //Assert
            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(19, items[0].Quality);

            Assert.AreEqual(1, items[1].SellIn);
            Assert.AreEqual(1, items[1].Quality);

            Assert.AreEqual(4, items[2].SellIn);
            Assert.AreEqual(6, items[2].Quality);

            Assert.AreEqual(0, items[3].SellIn);
            Assert.AreEqual(80, items[3].Quality);

            Assert.AreEqual(14, items[4].SellIn);
            Assert.AreEqual(21, items[4].Quality);
            
            Assert.AreEqual(2, items[5].SellIn);
            Assert.AreEqual(4, items[5].Quality);
        }
    }
}
