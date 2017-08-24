using GildedRose.Contracts.Dto;

namespace GildedRose.Contracts
{
    public interface IItemUpdateContract
    {
        IItemCreateContract Create(Item item);
    }
}
