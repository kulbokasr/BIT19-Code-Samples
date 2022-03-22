using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging.Products
{
    public class AgedBrie : IProduct
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn > 0)
                {
                    item.Quality ++;
                }
                else
                {
                    item.Quality += 2;
                }
                if (item.Quality > 50)
                { item.Quality = 50; }
            }
            item.SellIn --;
        }
    }
}
