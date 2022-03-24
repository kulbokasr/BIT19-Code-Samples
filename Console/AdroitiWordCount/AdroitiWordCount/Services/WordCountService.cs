using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSpell;

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
            NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
            oDict.DictionaryFile = ("~/App_Data/Dictionaries/en-US.dic");
            oDict.Initialize();
            NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();
            oSpell.Dictionary = oDict;
            var allText = _fileService.ReadFile();
            //Console.WriteLine(allText);
            string[] words = allText.Split(" ");
            int englishWords = 0;
            foreach (string word in words)
            {
                if (oSpell.TestWord(word))
                {
                    englishWords++;
                }
            }
            int CharacterCount = allText.Length;
            Console.WriteLine($"There are {words.Length.ToString()} words, {englishWords} English words and {CharacterCount.ToString()} characters in the file");
            return (words, CharacterCount);
        }
    }
}
