using System;
using System.Threading.Tasks;
using IMAS_QOTD_API;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace IMAS_QOTD_API.Tests
{
    public class QoutesControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _fixture;

        public QoutesControllerTests(WebApplicationFactory<Startup> fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Get_Random_Qoute_200()
        {
            Assert.True(true);
            var response = await _fixture.CreateClient().GetAsync("/qoutes");

            response.EnsureSuccessStatusCode();
        }
    }
}