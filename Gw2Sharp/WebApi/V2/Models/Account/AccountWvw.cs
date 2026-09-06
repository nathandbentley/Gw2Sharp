using System;
using System.Text.Json.Serialization;

namespace Gw2Sharp.WebApi.V2.Models
{
    public class AccountWvw : IApiV2Object
    {
        [JsonPropertyName("team")]
        public int Team { get; set; }

        [JsonPropertyName("guild")]
        public Guid? Guild { get; set; }
    }
}
