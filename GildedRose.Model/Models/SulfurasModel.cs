using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class SulfurasModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
            /*
                if (item.Quality < 50)                  
                    item.Quality = item.Quality + 1;

            if (item.SellIn >= 0) continue;
            if (item.Quality <= 0) continue;

            //never has to be sold or decreases in Quality
            */
        }
    }
}
