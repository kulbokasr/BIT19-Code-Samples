using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VintedConsoleApp.Models;

namespace VintedConsoleApp.Services
{
    public class FileService
    {
        private List<ShippingInfo> _providers;
        private IProvidersService _providersService;

        public FileService(IProvidersService providersService)
        {
            _providersService = providersService;
            _providers = _providersService.GetProviders();
        }

        public async Task<List<ReadAndUpdate>> ReadFileAsync()
        {
            string[] lines = await File.ReadAllLinesAsync("Data/input.txt");
            List<ReadAndUpdate> readData = new List<ReadAndUpdate>(); 
            foreach (string line in lines)
            {
                string[] lineInfo = line.Split(" ");
                DateOnly date;
                if (DateOnly.TryParse(lineInfo[0], out date) && _providers.FirstOrDefault(p => p.PackageSize == lineInfo[1]) != null && _providers.FirstOrDefault(p => p.Provider == lineInfo[2]) != null)
                {
                    ReadAndUpdate oneLine = new ReadAndUpdate()
                    {
                        Date = DateOnly.Parse(lineInfo[0]),
                        PackageSize = lineInfo[1],
                        Provider = lineInfo[2],
                        OriginalPrice = _providers.FirstOrDefault(s => s.PackageSize == lineInfo[1] && s.Provider == lineInfo[2]).Price
                    };
                    readData.Add(oneLine);
                }
                else
                {
                    ReadAndUpdate oneLine = new ReadAndUpdate()
                    {
                        ErrorLine = line + " Ignored ",
                        IsError = true
                    };
                    readData.Add(oneLine);
                }
            }
            return readData;
        }
    }

}
