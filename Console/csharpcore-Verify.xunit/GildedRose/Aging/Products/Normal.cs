using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging.Products
{
    public class Normal : IProduct
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.SellIn > 0)
                {
                    item.Quality --;
                }
                else
                {
                    item.Quality -= 2;
                }
            }
            item.SellIn --;
        }
    }
}
