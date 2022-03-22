using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging.Products
{
    public class Sulfuras : IProduct
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = 80;
            //item.SellIn -= 1;
        }
    }
}
