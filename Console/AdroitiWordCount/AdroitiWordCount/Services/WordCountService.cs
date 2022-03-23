using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdroitiWordCount.Services
{
    
    public class WordCountService
    {
        private IFileService _fileService;

        public WordCountService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public (string[] words, int CharacterCount) CountWordsAndPrint()
        {
            var allText = _fileService.ReadFile();
            //Console.WriteLine(allText);
            string[] words = allText.Split(" ");
            int CharacterCount = allText.Length;
            Console.WriteLine($"There are {words.Length.ToString()} words and {CharacterCount.ToString()} characters in the file");
            return (words, CharacterCount);
        }
    }
}
