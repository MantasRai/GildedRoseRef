using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;
using GildedRose.Model.Models;

namespace GildedRose.Model
{
    public class UpdateItemMain : IItemUpdateContract
    {
        public IStockItemUpdateContract Create(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Parameter: " + nameof(item) + " can not be null");

            // TO-DO implement logic of choosing correct model

            return null;
        }
    }
}
