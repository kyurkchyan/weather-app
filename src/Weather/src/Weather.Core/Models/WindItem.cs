using Newtonsoft.Json;

namespace Weather.Core.Models
{
    public class WindItem
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}