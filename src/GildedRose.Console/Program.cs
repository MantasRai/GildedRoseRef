using System.Collections.Generic;
using GildedRose.Contracts;
using GildedRose.Contracts.Entities;
using Ninject;
using static GildedRose.Console.DefaultAppData;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        private IItemUpdateContractFactory ItemUpdateContract { get; }

        public Program(IItemUpdateContractFactory itemUpdateContract)
        {
            ItemUpdateContract = itemUpdateContract;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var kernal = new StandardKernel(new DiContainer());

            var mainWorker = new Program(kernal.Get<IItemUpdateContractFactory>())
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
