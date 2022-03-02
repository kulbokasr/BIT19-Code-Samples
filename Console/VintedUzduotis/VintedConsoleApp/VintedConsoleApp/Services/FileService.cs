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
        public async Task<List<ReadDataModel>> ReadFileAsync()
        {
            string[] lines = await File.ReadAllLinesAsync("Data/input.txt");
            List<ReadDataModel> readData = new List<ReadDataModel>(); 
            foreach (string line in lines)
            {
                string[] lineInfo = line.Split(" ");
                ReadDataModel oneLine = new ReadDataModel()
                {
                    Date = DateOnly.Parse(lineInfo[0]),
                    PackageSize = lineInfo[1],
                    Provider = lineInfo[2]
                };
                readData.Add(oneLine);
            }
            return readData;
        }
    }

}
