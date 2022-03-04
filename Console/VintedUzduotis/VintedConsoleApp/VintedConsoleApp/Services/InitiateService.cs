using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VintedConsoleApp.Models;

namespace VintedConsoleApp.Services
{
    public class InitiateService
    {
        private FileService _fileService;
        private ProvidersService _providersService;
        private List<ShippingInfo> _providers;
        private CalculationService _calculationService;

        public InitiateService(FileService fileService, CalculationService calculationService)
        {
            _fileService = fileService;
            _calculationService = calculationService;
        }

        
        
        public async Task Initiate()
        {
            var allinfo = await _fileService.ReadFileAsync();
            var calculatedInfo = _calculationService.Calculate(allinfo);
            foreach (var info in calculatedInfo)
            {
                switch (info.IsError)
                {
                    case true:
                        Console.WriteLine(info.ErrorLine);
                        break;
                    case false:
                        {
                            if (info.Discount == 0)
                            { Console.WriteLine($"{info.Date} {info.PackageSize} {info.Provider} {info.DiscountedPrice.ToString("0.00")} -"); }
                            else
                            {
                                Console.WriteLine($"{info.Date} {info.PackageSize} {info.Provider} {info.DiscountedPrice.ToString("0.00")} {info.Discount.ToString("0.00")} ");
                            }
                        }
                        break;
                }

            }
        }
    }
}
