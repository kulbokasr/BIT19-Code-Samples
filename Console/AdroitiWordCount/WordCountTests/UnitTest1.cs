using AdroitiWordCount.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System.IO;

namespace WordCountTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetWordsAndCharactersCount_GivenSampleText_CalculatesCorrectly()
        {
            var fileServiceMock = new Mock<IFileService>();
            fileServiceMock.Setup(f => f.ReadFile()).Returns("Just three words are");

            var WordCountService = new WordCountService(fileServiceMock.Object);

            string[] words = {};
            int CharacterCount = 0;
            (words, CharacterCount) = WordCountService.CountWordsAndPrint();
            words.Length.Should().Be(4);
            CharacterCount.Should().Be(20);
            //words.Length.Should().Be(3);
            //CharacterCount.Should().Be(17);
        }
    }
}