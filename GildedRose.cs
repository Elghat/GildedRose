using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        /// <summary>
        /// UpdateQuality va appeler les méthodes de ItemBehavior selon l'item que je lui passe en paramètre
        /// Elle devrais détecter en fonction du début du string quel type d'objet c'est et appeler la méthode correspondante
        /// </summary>
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        //Old UpdateQuality
        /*public void UpdateQuality()
        {
            foreach (var product in Items)
            {
                //Ca ne sert à rien de continuer dans le if si c'est sulfura puisque l'item ne se dégrade pas 
                if (product.Name == "Sulfuras, Hand of Ragnaros") { continue; }

                if (product.Name != "Aged Brie" && product.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (product.Quality > 0)
                    {
                        product.Quality -= 1;
                    }
                }
                else
                {
                    if (product.Quality < 50)
                    {
                        product.Quality += 1;

                        if (product.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            //Les billet de concert augmentent de qualité plus ils sont proche de la date de concert
                            if (product.SellIn < 11 && product.Quality < 50)
                            {
                                product.Quality += 1;
                            }

                            if (product.SellIn < 6 && product.Quality < 50)
                            {
                                product.Quality += 1;
                            }
                        }
                    }
                }

                product.SellIn -= 1;

                if (product.SellIn < 0)
                {
                    if (product.Name != "Aged Brie")
                    {
                        if (product.Name != "Backstage passes to a TAFKAL80ETC concert" && product.Quality > 0)
                        {
                            product.Quality -= 1;
                        }
                        else
                        {
                            //Si le concert est passé, la qualité du billet tombe à 0
                            product.Quality = 0;
                        }
                    }
                    else
                    {
                        if (product.Quality < 50)
                        {
                            product.Quality += 1;
                        }
                    }
                }
            }
        }*/

        public void UpdateQuality(Item itemToUpdate)
        {
            switch (itemToUpdate.Name)
            {
                case string itemType when itemType.Contains("Aged"):
                    ItemBehavior.AgedItem(itemToUpdate);
                    break;
                case string itemType when itemType.Contains("Backstage passes"):
                    ItemBehavior.BackstagePassesItem(itemToUpdate);
                    break;
                case string itemType when itemType.Contains("Sulfuras"):
                    break;
                case string itemType when itemType.Contains("Conjured"):
                    ItemBehavior.ConjuredItem(itemToUpdate);
                    break;
                default:
                    ItemBehavior.DefaultItem(itemToUpdate);
                    break;
            }
        }
    }
}
