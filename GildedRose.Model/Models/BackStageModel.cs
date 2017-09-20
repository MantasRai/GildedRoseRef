using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;

namespace GildedRose.Model.Models
{
    public class BackStageModel : IItemUpdateContract
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2;
            }
            else if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}
