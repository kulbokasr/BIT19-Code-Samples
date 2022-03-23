using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Aging
{
    public interface IStrategy
    {
        bool Applies(string name);
        void UpdateQuality(Item item);
    }
}
