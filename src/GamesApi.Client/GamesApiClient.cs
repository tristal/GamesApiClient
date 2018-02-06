using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GamesApi.Client
{
    public class GamesApiClient
    {
        private readonly HttpClient client;

        public GamesApiClient()
        {
            this.client = new HttpClient
            {
                BaseAddress = new Uri("https://games.crossfit.com/competitions/api/v1/")
            };
        }

        /// <summary>
        /// Issues a request to the Games API for a specified athlete's ID.
        /// </summary>
        /// <param name="atheleteId">The id of the athlete to retrieve.</param>
        /// <returns>The retrieved <see cref="Athlete"/>.</returns>
        public async Task<Athlete> GetAtheleteByIdAsync(string atheleteId)
        {
            var response = await this.client.GetStringAsync($"athlete/{atheleteId}").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<Athlete>(response);
        }
    }
}
