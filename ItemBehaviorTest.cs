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

    }
}
