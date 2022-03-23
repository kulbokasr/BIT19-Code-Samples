using GildedRose.Aging.Products;
using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging
{
    public class CalculationService
    {
        public void ChooseProduct(Item item)
        {
            List<IStrategy> strategies = new List<IStrategy>
            {
                new Sulfuras(),
                new BackstagePasses(),
                new AgedBrie(),
                new AgedBrie(),
                new Conjured(),
                new Normal()
            };
            var selectedStrategy = strategies.FirstOrDefault(s => s.Applies(item.Name));

            selectedStrategy.UpdateQuality(item);
        }
    }
}
