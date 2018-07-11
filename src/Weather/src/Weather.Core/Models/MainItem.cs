using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class MainItem
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}