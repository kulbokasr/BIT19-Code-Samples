using CreditApplicationProject.Models;
using CreditApplicationProject.Services;
using FluentAssertions;
using System;
using Xunit;

namespace CreditApplicationProject.UnitTests
{
    public class ApplicationServiceTests : IClassFixture<ApplicationService>  
    {
        private readonly ApplicationService _applicationService;

        public ApplicationServiceTests(ApplicationService applicationService)  
        {
            _applicationService = applicationService;
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
            String testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert parrunink testa 
            testDecision.Should().Be(correctDecision.ToString());
        }
        [Fact]
        public void GetDecision_GivenNoCreditValues_GetYesAnswer()
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
            String testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert parrunink testa 
            testDecision.Should().Be(correctDecision.ToString());
        }
        [Fact]
        public void GetDecision_GivenNoCreditValues_GetYesAnswer2()
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
            String testDecision = _applicationService.GetDecision(applicationAnswerNo);
            //assert
            testDecision.Should().Be(correctDecision.ToString());
        }
    }
}