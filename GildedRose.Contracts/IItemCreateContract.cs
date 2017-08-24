using GildedRose.Contracts.Dto;

namespace GildedRose.Contracts
{
    public interface IItemCreateContract
    {
        IItemUpdateContract Create(Item item);
    }
}
