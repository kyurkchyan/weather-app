using System.Threading;
using System.Threading.Tasks;

namespace Weather.Core.Services
{
    public interface IWeatherService
    {
        Task<Models.Weather> GetWeatherAsync(string city, CancellationToken token = default(CancellationToken));
    }
}