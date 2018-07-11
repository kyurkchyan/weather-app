using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class Point
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}