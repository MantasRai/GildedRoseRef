using Ninject.Modules;
using GildedRose.Contracts;
using GildedRose.Model;
using GildedRose.Model.Models;


namespace GildedRose.Console
{
    public class DiContainer : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IItemUpdateContractFactory)).To(typeof(UpdateItemMain)).InSingletonScope();
            Bind(typeof(IItemUpdateContract)).To(typeof(AgedBrieModel)).InSingletonScope();
            Bind(typeof(IItemUpdateContract)).To(typeof(BackStageModel)).InSingletonScope();
            Bind(typeof(IItemUpdateContract)).To(typeof(StandardUpdateModel)).InSingletonScope();
            Bind(typeof(IItemUpdateContract)).To(typeof(SulfurasModel)).InSingletonScope();
        }
    }
}
