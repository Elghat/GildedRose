using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp
{
    public static class ItemBehavior
    {
        /// <summary>
        ///Ici je vais avoir tous les comportement des items différents que uniquement UpdateQuality appellera
        ///Todo : Implémenter les exceptions avec test à chaque fois
        /// </summary>

        public static void DefaultItem(Item product)
        {

            product.SellIn -= 1;
            if (product.Quality > 1)
            {
                product.Quality -= 1;
            }

            if (product.SellIn < 0 && product.Quality > 1)
            {
                product.Quality -= 1;
            }


        }
    }
}
