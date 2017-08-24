using GildedRose.Contracts.Dto;

namespace GildedRose.Contracts
{
    public interface IItemUpdateContract
    {
        IStockItemUpdateContract Create(Item item);
    }
}
