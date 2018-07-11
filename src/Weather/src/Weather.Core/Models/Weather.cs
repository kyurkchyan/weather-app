using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class Weather
    {
        [JsonProperty("list")]
        public ListItem[] ListItems { get; set; }
        [JsonProperty("city")]
        public CityItem City { get; set; }
    }
}