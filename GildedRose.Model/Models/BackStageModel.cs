using System;
using GildedRose.Contracts;
using GildedRose.Contracts.Dto;

namespace GildedRose.Model.Models
{
    public class BackStageModel : IItemCreateContract
    {
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();

            /*
            if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

 
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }                        
                    }
            */
        }
    }
}
