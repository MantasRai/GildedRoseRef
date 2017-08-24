using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class BackStageModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 11 && item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 6 && item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 0)
                item.Quality = 0;
        }
    }
}
