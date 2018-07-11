using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Weather.Core.Services.Implementation
{
    public class OpenWeatherService : IWeatherService
    {
        private readonly IDataClient _dataClient;

        public OpenWeatherService(IDataClient dataClient)
        {
            _dataClient = dataClient;
        }

        public Task<Models.Weather> GetWeatherAsync(string city, CancellationToken token = default(CancellationToken))
        {
            var parameters = new Dictionary<string, string> {["q"] = city};
            return _dataClient.GetAsync<Models.Weather>("/forecast", parameters, token);
        }
    }
}