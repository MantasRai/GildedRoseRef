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
           // TO-DO Bind interfaces into scopes Main to single instance and depending instance for trancients
        }
    }
}
