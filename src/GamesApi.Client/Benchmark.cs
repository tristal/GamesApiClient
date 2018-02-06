using Newtonsoft.Json;

namespace GamesApi.Client
{
    public class Benchmark
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}