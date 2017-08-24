using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class AgedBrieModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
            /* 
            item.SellIn = item.SellIn - 1;

            // ?
            if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }

            if (item.SellIn >= 0) continue;
            if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
            */
        }
    }
}
