using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class ConjuredModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 2)
            {
                item.Quality -= 2;
            }
            else
            {
                if (item.Quality == 1)
                    item.Quality--;
            }
            //"Conjured" items degrade in Quality twice as fast as normal items | So found a bug and fixed in this refact solution
            if (item.SellIn > 0)
                item.SellIn--;
        }
    }
}
