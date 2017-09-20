using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;

namespace GildedRose.Model.Models
{
    public class StandardUpdateModel : IItemUpdateContract
    {
        private readonly int _factor;

        public StandardUpdateModel(int factor = 1)
        {
            _factor = factor;
        }

        public void UpdateItem(Item item)
        {
            item.SellIn--; // Can it be negative?
            if (item.Quality > 0)
                item.Quality -= (item.SellIn < 0 ? 2 : 1) * _factor;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
