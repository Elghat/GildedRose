using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ItemBehaviorTest
    {
        [Test]
        public void foo()
        {
            var product = new Item() { Name = "foo", SellIn = 0, Quality = 0 };
            //Utiliser la métode default Behavior
            
            //Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
