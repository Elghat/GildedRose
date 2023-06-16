using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp
{
    public static class ItemBehavior
    {
        /// <summary>
        ///Ici je vais avoir tous les comportement des items différents que uniquement UpdateQuality appellera
        /// Pas besoin de faire un comportement pour sulfura puisque l'item ne bouge pas
        /// </summary>
        
        private const int MaxProductQuality = 50;
        private const int MinProductQuality = 1;
        private const int QualityModifier = 1;
        private const int ConjuredQualityModifier = 2;
        private const int SellInModifier = 1;
        private const int ExpiredSellIn = 0;
        private const int ConcertIsSoon = 11;
        private const int ConcertIsVerySoon = 6;
        private const int ConcertPassedQuality= 0;

        public static void DefaultItem(Item product)
        {

            product.SellIn -= SellInModifier;
            if (product.Quality > MinProductQuality)
            {
                product.Quality -= QualityModifier;
            }

            if (product.SellIn < ExpiredSellIn && product.Quality > MinProductQuality)
            {
                product.Quality -= QualityModifier;
            }


        }

        public static void AgedItem(Item product)
        {
            product.SellIn -= SellInModifier;
            if (product.Quality < MaxProductQuality)
            {
                product.Quality += QualityModifier;
            }
        }

        public static void BackstagePassesItem(Item product)
        {
            product.SellIn -= SellInModifier;
            if (product.Quality < MaxProductQuality)
            {
                product.Quality += QualityModifier;
            }

            if (product.SellIn < ConcertIsSoon && product.Quality < MaxProductQuality)
            {
                product.Quality += QualityModifier;
            }

            if (product.SellIn < ConcertIsVerySoon && product.Quality < MaxProductQuality)
            {
                product.Quality += QualityModifier;
            }

            if (product.SellIn < ExpiredSellIn)
            {
                product.Quality = ConcertPassedQuality;
            }
        }

        public static void ConjuredItem(Item product)
        {
            product.SellIn -= SellInModifier;
            if (product.Quality > MinProductQuality)
            {
                product.Quality -= ConjuredQualityModifier;
            }

            if (product.SellIn < ExpiredSellIn && product.Quality > MinProductQuality)
            {
                product.Quality -= ConjuredQualityModifier;
            }
        }
    }
}
