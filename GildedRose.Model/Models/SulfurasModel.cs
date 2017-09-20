using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;

namespace GildedRose.Model.Models
{
    public class SulfurasModel : IItemUpdateContract
    {
        public void UpdateItem(Item item)
        {
            //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        }
    }
}
