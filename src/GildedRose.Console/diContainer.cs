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
            Bind(typeof(IItemUpdateContract)).To(typeof(UpdateItemMain)).InSingletonScope();
            Bind(typeof(IItemCreateContract)).To(typeof(AgedBrieModel)).InSingletonScope();
            Bind(typeof(IItemCreateContract)).To(typeof(BackStageModel)).InSingletonScope();
            Bind(typeof(IItemCreateContract)).To(typeof(ConjuredModel)).InSingletonScope();
            Bind(typeof(IItemCreateContract)).To(typeof(StandardUpdateModel)).InSingletonScope();
            Bind(typeof(IItemCreateContract)).To(typeof(SulfurasModel)).InSingletonScope();
        }
    }
}
