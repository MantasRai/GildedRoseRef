using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Contracts.Dto;

namespace GildedRose.Contracts
{
    public interface IStockItemUpdateContract
    {
        void UpdateItem(Item item);
    }
}
