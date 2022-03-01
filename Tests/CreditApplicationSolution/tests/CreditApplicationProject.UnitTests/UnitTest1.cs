using CreditApplicationProject.Models;
using CreditApplicationProject.Services;
using FluentAssertions;
using System;
using Xunit;

namespace CreditApplicationProject.UnitTests
{
    public class ApplicationServiceTests
    {
        private readonly ApplicationService _applicationService;

        public ApplicationServiceTests()
        {
            _applicationService = new ApplicationService();
        }

        [Fact]
        public void GetDecision_GivenNoCreditValues_GetNoAnswer()
        {
            //arrange
            Decision correctDecision = new Decision()
            {
                Answer = "No",
                InterestRate = 0
            };
            var applicationAnswerNo = new Application()
            {
                CreditAmount = 100,
                Term = 10,
                CurrentCreditAmount = 100,
            };
            //act
            Decision testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert
            testDecision.Answer.Should().Be(correctDecision.Answer);
            testDecision.InterestRate.Should().Be(correctDecision.InterestRate);
        }
        [Fact]
        public void GetDecision_GivenGoodCreditValues_GetYesAnswer()
        {
            //arrange
            Decision correctDecision = new Decision()
            {
                Answer = "Yes",
                InterestRate = 3
            };
            var applicationAnswerNo = new Application()
            {
                CreditAmount = 2100,
                Term = 10,
                CurrentCreditAmount = 100,
            };
            //act
            Decision testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert 
            testDecision.Answer.Should().Be(correctDecision.Answer);
            testDecision.InterestRate.Should().Be(correctDecision.InterestRate);
        }
        [Fact]
        public void GetDecision_GivenGoodCreditValues_GetYesAnswer2()
        {
            //arrange
            Decision correctDecision = new Decision()
            {
                Answer = "Yes",
                InterestRate = 6
            };
            var applicationAnswerNo = new Application()
            {
                CreditAmount = 2100,
                Term = 10,
                CurrentCreditAmount = 60000,
            };
            //act
            Decision testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert
            testDecision.Answer.Should().Be(correctDecision.Answer);
            testDecision.InterestRate.Should().Be(correctDecision.InterestRate);
        }
        [Fact]
        public void GetDecision_GivenBadCreditValues_GetError()
        {
            //arrange
            Decision correctDecision = new Decision()
            {
                Answer = "Yes",
                InterestRate = 3
            };
            var applicationAnswerNo = new Application()
            {
                CreditAmount = -2100,
                Term = 10,
                CurrentCreditAmount = -100,
            };
            //act
            //Decision testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert 
            Assert.Throws<ArgumentException>(() => _applicationService.GetDecision(applicationAnswerNo));
        }
    }
}