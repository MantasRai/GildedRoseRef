using System.Collections.Generic;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;
using Ninject;

namespace GildedRose.Console.Tests
{
    [TestFixture]
    public class DefaultAppDataTests
    {
        [TestCase("Default item", 1, 0)]
        [TestCase("+5 Dexterity Vest", 1, 0)]
        [TestCase("Elixir of the Mongoose", 1, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 1, 1)]
        [TestCase("Conjured Mana Cake", 2, 0)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 50, 53)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 12, 15)]
        public void ItemShouldInExpectedQuality(string itemName, int quality, int expect)
        {
            var kernal = new StandardKernel(new DiContainer());
            var item = new Item { Name = itemName, Quality = quality, SellIn = 1 }; // SellIn = 1
            var program = new Program(kernal.Get<IItemUpdateContractFactory>()) { Items = new List<Item> { item } };
            program.UpdateQuality();
            Assert.AreEqual(expect, item.Quality);
        }
    }
}