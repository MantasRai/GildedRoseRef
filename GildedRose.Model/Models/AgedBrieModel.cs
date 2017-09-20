using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;

namespace GildedRose.Model.Models
{
    public class AgedBrieModel : IItemUpdateContract
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50)
                item.Quality++;
        }
    }
}
