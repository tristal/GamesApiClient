using System;
using System.Threading.Tasks;
using GamesApi.Client;
using Xunit;

namespace GamesApi.Client.Test
{
    public class GamesApiClientTests
    {
        [Fact]
        public async Task GetAtheleteByIdAsync_ReturnsSuccessfullyAsync()
        {
            var client = new GamesApiClient();

            var result = await client.GetAtheleteByIdAsync("455950").ConfigureAwait(false);

            Assert.NotNull(result);
            Assert.True(result.CompetitorId > 0);
        }
    }
}
