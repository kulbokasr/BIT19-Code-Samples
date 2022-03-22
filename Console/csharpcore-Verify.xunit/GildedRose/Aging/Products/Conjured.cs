using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging.Products
{
    public class Conjured : IProduct
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.SellIn > -1)
                {
                    item.Quality -= 2;
                }
                else
                {
                    item.Quality -= 4;
                }
            }
            item.SellIn --;
        }
    }
}
