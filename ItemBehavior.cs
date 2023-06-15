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
        /// Pas besoin de faire un comportement pour sulfura puisque l'item ne bouge pas
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

        public static void AgedItem(Item product)
        {
            product.SellIn -= 1;
            if (product.Quality < 50)
            {
                product.Quality += 1;
            }
        }

        public static void BackstagePassesItem(Item product)
        {
            product.SellIn -= 1;
            if (product.Quality < 50)
            {
                product.Quality += 1;
            }

            if (product.SellIn < 11 && product.Quality < 50)
            {
                product.Quality += 1;
            }

            if (product.SellIn < 6 && product.Quality < 50)
            {
                product.Quality += 1;
            }

            if (product.SellIn < 0)
            {
                product.Quality = 0;
            }
        }

        public static void ConjuredItem(Item product)
        {
            product.SellIn -= 1;
            if (product.Quality > 1)
            {
                product.Quality -= 2;
            }

            if (product.SellIn < 0 && product.Quality > 1)
            {
                product.Quality -= 2;
            }
        }
    }
}
