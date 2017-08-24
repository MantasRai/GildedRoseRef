using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class StandardUpdateModel: IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 0)
                item.Quality--;
            if (item.SellIn > 0)
                item.SellIn--;
        }
    }
}
