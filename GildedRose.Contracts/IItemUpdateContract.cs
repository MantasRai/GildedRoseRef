using GildedRose.Contracts.Entities;

namespace GildedRose.Contracts
{
    public interface IItemUpdateContractFactory
    {
        IItemUpdateContract Create(Item item);
    }
}
