using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VintedConsoleApp.Models;

namespace VintedConsoleApp.Services
{
    public class PrintService
    {
        public void PrintToConsole(List<ReadAndUpdate> info)
        {
            foreach (var item in info)
            {
                switch (item.IsError)
                {
                    case true:
                        Console.WriteLine(item.ErrorLine);
                        break;
                    case false:
                        {
                            if (item.Discount == 0)
                            { Console.WriteLine($"{item.Date} {item.PackageSize} {item.Provider} {item.DiscountedPrice.ToString("0.00")} - "); }
                            else
                            {
                                Console.WriteLine($"{item.Date} {item.PackageSize} {item.Provider} {item.DiscountedPrice.ToString("0.00")} {item.Discount.ToString("0.00")} ");
                            }
                        }
                        break;
                }

            }
        }
    }
}
