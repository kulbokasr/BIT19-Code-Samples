
using CreditApplicationProject;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using CreditApplicationProject.Models;

namespace CreditApplicationControllerTest
{
    public class CreditApplicationControllerTest
    {
        public class CreditApplicationControllerTests
        {
            private WebApplicationFactory<Program> _application;

            private HttpClient _client;

            public CreditApplicationControllerTests()
            {
                _application = new WebApplicationFactory<Program>();
                _client = _application.CreateClient();
            }

            [Fact]
            public async Task Test()
            {
                var applicationAnswerNo = new Application()
                {
                    CreditAmount = 100,
                    Term = 10,
                    CurrentCreditAmount = 100,
                };

                var result = await _client.PostAsJsonAsync("/calculate", applicationAnswerNo);

                result.EnsureSuccessStatusCode();

                var creditDecision = await result.Content.ReadAsAsync<Decision>();

                creditDecision.Answer.Should().Be("No");
                creditDecision.InterestRate.Should().Be(0);
            }
        }
    }
}
