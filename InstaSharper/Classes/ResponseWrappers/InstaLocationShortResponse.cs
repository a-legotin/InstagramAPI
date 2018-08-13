﻿using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers
{
    public class InstaLocationShortResponse
    {
        [JsonProperty("lat")] public double Lat { get; set; }

        [JsonProperty("lng")] public double Lng { get; set; }

        [JsonProperty("address")] public string Address { get; set; }

        [JsonProperty("facebook_places_id")] public string ExternalId { get; set; }

        [JsonProperty("external_source")] public string ExternalSource { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("short_name")] public string ShortName { get; set; }

        [JsonProperty("pk")] public long Pk { get; set; }

        [JsonProperty("city")] public string City { get; set; }
    }
}