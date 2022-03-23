using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging.Products
{
    public class BackstagePasses : IStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn > 10)
                { item.Quality ++;}
                if (item.SellIn <= 10 && item.SellIn > 5)
                {item.Quality += 2;}
                if (item.SellIn <= 5 && item.SellIn >= 0)
                {item.Quality += 3;}
                if (item.SellIn < 0)
                {item.Quality = 0;}
            }
            if (item.SellIn < 1)
            {
                item.Quality = 0;
            }
            if (item.Quality > 50)
            {item.Quality = 50;}

            item.SellIn --;
        }
        public bool Applies(string name)
        {
            return name.StartsWith("Backstage passes");
        }
    }
}
