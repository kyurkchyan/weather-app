using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class CityItem
    {
        [JsonProperty("name")]
        public string CityName { get; set; }
        [JsonProperty("coord")]
        public Point Coordinate { get; set; }
    }
}
