using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintedConsoleApp.Services
{
    public class InitiateService
    {
        private FileService _fileService;

        public InitiateService(FileService fileService)
        {
            _fileService = fileService;
        }

        public async Task Initiate()
        {
            var allinfo = await _fileService.ReadFileAsync();
            foreach (var info in allinfo)
            {
                Console.WriteLine($"Date: {info.Date}, size: {info.PackageSize}, provider {info.Provider}");
            }
        }
    }
}
