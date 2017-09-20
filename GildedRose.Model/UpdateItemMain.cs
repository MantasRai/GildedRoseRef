using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;
using GildedRose.Model.Models;

namespace GildedRose.Model
{
    public class UpdateItemMain : IItemUpdateContractFactory
    {
        public IItemUpdateContract Create(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Parameter: " + nameof(item) + " can not be null");

            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieModel();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasModel();
                case "Conjured Mana Cake":
                    return new StandardUpdateModel(2);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStageModel();
            }
            return new StandardUpdateModel();
        }
    }
}
