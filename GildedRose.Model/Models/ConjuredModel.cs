using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class ConjuredModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
            //"Conjured" items degrade in Quality twice as fast as normal items
        }
    }
}
