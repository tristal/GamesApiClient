using System.Collections.Generic;
using Newtonsoft.Json;

namespace GamesApi.Client
{
    public class Athlete
    {
        [JsonProperty("competitorId")]
        public long CompetitorId { get; set; }

        [JsonProperty("competitorName")]
        public string CompetitorName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("profilePicS3key")]
        public string ProfilePicS3Key { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("regionId")]
        public long RegionId { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("competitionAge")]
        public string CompetitionAge { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("wight")]
        public string Weight { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("divisionId")]
        public long DivisionId { get; set; }

        [JsonProperty("divisionName")]
        public string DivisionName { get; set; }

        [JsonProperty("professionId")]
        public long ProfessionId { get; set; }

        [JsonProperty("professionName")]
        public string ProfessionName { get; set; }

        [JsonProperty("affiliateId")]
        public long AffiliateId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("affiliateName")]
        public string AffiliateName { get; set; }

        [JsonProperty("benchmarks")]
        public Dictionary<string, Benchmark> Benchmarks { get; set; }

        // [JsonProperty("stats")]
        // public Stats Stats { get; set; }
    }
}