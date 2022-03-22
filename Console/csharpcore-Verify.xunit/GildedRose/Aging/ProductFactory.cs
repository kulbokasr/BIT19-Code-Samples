using GildedRose.Aging.Products;
using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging
{
    public class ProductFactory
    {
        public IProduct ChooseProduct(Item item)
        {
            if (item.Name.StartsWith("Backstage passes"))
            {
                return new BackstagePasses();
            }
            if (item.Name.StartsWith("Sulfuras"))
            {
                return new Sulfuras();
            }
            if (item.Name.StartsWith("Conjured"))
            {
                return new Conjured();
            }
            if (item.Name == "Aged Brie")
            {
                return new AgedBrie();
            }
            else 
            {
                return new Normal();
            }

        }
    }
}
