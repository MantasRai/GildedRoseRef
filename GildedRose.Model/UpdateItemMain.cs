using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;
using GildedRose.Model.Models;

namespace GildedRose.Model
{
    public class UpdateItemMain : IItemUpdateContract
    {
        public IItemCreateContract Create(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Parameter: " + nameof(item) + " can not be null");

            if (item.Name == "Aged Brie")
                return new AgedBrieModel();
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasModel();
            }
            if (item.Name == "Conjured Mana Cake")
            {
                return new ConjuredModel();
            }
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackStageModel();
            }
            return new StandardUpdateModel();
        }
    }
}
