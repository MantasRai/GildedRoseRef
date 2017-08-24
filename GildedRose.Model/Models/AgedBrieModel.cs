using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class AgedBrieModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50)
                item.Quality++;
            //"Aged Brie" actually increases in Quality the older it gets | So need to double check it
            if (item.SellIn < 0 && item.Quality < 50)
                item.Quality = item.Quality + 1;
        }
    }
}
