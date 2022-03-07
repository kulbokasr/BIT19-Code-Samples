using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VintedConsoleApp.Models;

namespace VintedConsoleApp.Services
{
    public class CalculationService
    {
        public List<ReadAndUpdate> Calculate(List<ReadAndUpdate> info)
        {
            var minSPrice = info.Where(p => p.PackageSize == "S").Min(p => p.OriginalPrice);
            decimal availableDiscount = 10;
            var LpLshipmentCount = 0;

            foreach (var item in info)
            {

                var itemIndex = info.IndexOf(item);
                if (itemIndex - 1 < 0)
                { itemIndex++; };
                if (info[itemIndex].Date.Month != info[itemIndex - 1].Date.Month)
                {
                    availableDiscount = 10;
                    LpLshipmentCount = 0;
                }

                if (item.PackageSize == "S" && item.OriginalPrice > minSPrice)
                {
                    item.Discount = item.OriginalPrice - minSPrice;
                    if (item.Discount < availableDiscount)
                    {
                        item.DiscountedPrice = item.OriginalPrice - item.Discount;
                        availableDiscount -= item.Discount;
                    }
                    else if (item.Discount > availableDiscount)
                    {
                        item.DiscountedPrice = item.OriginalPrice - availableDiscount;
                        item.Discount = availableDiscount;
                        availableDiscount = 0;
                    }
                    else
                    { item.DiscountedPrice = item.OriginalPrice; }


                }
                else if (item.PackageSize == "L" && item.Provider == "LP")
                {
                    LpLshipmentCount++;
                    item.DiscountedPrice = item.OriginalPrice;
                    if (LpLshipmentCount == 3)
                    {
                        item.Discount = item.OriginalPrice;
                        item.DiscountedPrice = 0;
                        availableDiscount -= item.Discount;
                    }
                }
                else
                {
                    item.DiscountedPrice = item.OriginalPrice;
                }

            }
            return info;
        }
    }
}
