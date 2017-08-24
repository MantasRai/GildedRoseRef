using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class StandardUpdateModel: IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
            /*
                sellin - 1; sellin >= 0; quality - 1 if sellin = 0;
            */
        }
    }
}
