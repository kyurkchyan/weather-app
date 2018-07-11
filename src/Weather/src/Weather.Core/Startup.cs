using Grace.DependencyInjection;
using Grace.DependencyInjection.Lifestyle;
using Weather.Core.Services;
using Weather.Core.Services.Implementation;

namespace Weather.Core
{
    public static class Startup
    {
        public static DependencyInjectionContainer RegisterCoreDependencies(this DependencyInjectionContainer container)
        {
            container.Add(block => block.Export<WebDataClient>().As<IDataClient>().UsingLifestyle(new SingletonLifestyle()));
            container.Add(block => block.Export<OpenWeatherService>().As<IWeatherService>());
            return container;
        }
    }
}