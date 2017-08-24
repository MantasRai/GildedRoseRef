using System.Collections.Generic;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;
using Ninject;
using static GildedRose.Console.DefaultAppData;

namespace GildedRose.Console
{
    class Program
    {
        public IList<Item> Items;
        private IItemUpdateContract ItemUpdateContract { get; }

        public Program(IItemUpdateContract itemUpdateContract)
        {
            ItemUpdateContract = itemUpdateContract;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var kernal = new StandardKernel(new DiContainer());

            var mainWorker = new Program(kernal.Get<IItemUpdateContract>())
            {
                Items = GetDefaultData()
            };
            mainWorker.UpdateQuality();

            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                ItemUpdateContract.Create(item).UpdateItem(item);
            }
        }
    }
}
