using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class WeatherItems
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}