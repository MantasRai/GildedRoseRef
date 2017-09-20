using System;
using System.Collections.Generic;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;
using GildedRose.Model.Models;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace GildedRose.Tests
{
    public class DefaultAppDataTests
    {
        [Fact]
        public void TestUpdateOnZeroZeroItem()
        {
            var dataAndContractPairs = new List<Tuple<Item, IItemUpdateContract>>
            {
                Tuple.Create(new Item {Quality = 0, SellIn = 0},
                    (IItemUpdateContract) new SulfurasModel()),
                Tuple.Create(new Item {Quality = 1, SellIn = -1},
                    (IItemUpdateContract) new AgedBrieModel()),
                Tuple.Create(new Item {Quality = 0, SellIn = -1},
                    (IItemUpdateContract) new BackStageModel()),
                Tuple.Create(new Item {Quality = 0, SellIn = -1},
                    (IItemUpdateContract) new StandardUpdateModel(2)),
                Tuple.Create(new Item {Quality = 0, SellIn = -1},
                    (IItemUpdateContract) new StandardUpdateModel())
            };

            foreach (var itemPair in dataAndContractPairs)
            {
                var testCase = new Item {Quality = 0, SellIn = 0};
                itemPair.Item2.UpdateItem(testCase);
                Assert.AreEqual(itemPair.Item1.Quality, testCase.Quality);
                Assert.AreEqual(itemPair.Item1.SellIn, testCase.SellIn);
            }
        }

        [Fact]
        public void TestUpdateOnFiveFiveItem()
        {
            var dataAndContractPairs = new List<Tuple<Item, IItemUpdateContract>>
            {
                Tuple.Create(new Item {Quality = 5, SellIn = 5},
                    (IItemUpdateContract) new SulfurasModel()),
                Tuple.Create(new Item {Quality = 6, SellIn = 4},
                    (IItemUpdateContract) new AgedBrieModel()),
                Tuple.Create(new Item {Quality = 8, SellIn = 4},
                    (IItemUpdateContract) new BackStageModel()),
                Tuple.Create(new Item {Quality = 3, SellIn = 4},
                    (IItemUpdateContract) new StandardUpdateModel(2)),
                Tuple.Create(new Item {Quality = 4, SellIn = 4},
                    (IItemUpdateContract) new StandardUpdateModel())
            };

            foreach (var itemPair in dataAndContractPairs)
            {
                var testCase = new Item {Quality = 5, SellIn = 5};
                itemPair.Item2.UpdateItem(testCase);
                Assert.AreEqual(itemPair.Item1.Quality, testCase.Quality);
                Assert.AreEqual(itemPair.Item1.SellIn, testCase.SellIn);
            }
        }

        [Fact]
        public void TestUpdateOnSpecifiedValues()
        {
            var dataAndContractPairs = new List<Tuple<Item, Item, IItemUpdateContract>>
            {
                Tuple.Create(new Item {Quality = 15, SellIn = 10},
                    new Item {Name = "+5 Dexterity Vest", Quality = 16, SellIn = 11},
                    (IItemUpdateContract) new StandardUpdateModel()),
                Tuple.Create(new Item {Quality = 5, SellIn = 4},
                    new Item {Name = "Elixir of the Mongoose", Quality = 6, SellIn = 5},
                    (IItemUpdateContract) new StandardUpdateModel()),
                Tuple.Create(new Item {Quality = 51, SellIn = 10},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 51},
                    (IItemUpdateContract) new SulfurasModel()),
                Tuple.Create(new Item {Quality = 4, SellIn = 2},
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                    (IItemUpdateContract) new StandardUpdateModel(2)),
                Tuple.Create(new Item {Quality = 1, SellIn = 1},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    (IItemUpdateContract) new AgedBrieModel()),
                Tuple.Create(new Item {Quality = 13, SellIn = 16},
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 12, SellIn = 17},
                    (IItemUpdateContract) new BackStageModel())
            };

            foreach (var itemPair in dataAndContractPairs)
            {
                itemPair.Item3.UpdateItem(itemPair.Item2);
                Assert.AreEqual(itemPair.Item1.Quality, itemPair.Item2.Quality);
                Assert.AreEqual(itemPair.Item1.SellIn, itemPair.Item2.SellIn);
            }
        }
    }
}