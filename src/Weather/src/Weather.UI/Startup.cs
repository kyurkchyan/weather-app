using Grace.DependencyInjection;
using Weather.UI.ViewModels.Main;
using Weather.UI.ViewModels.Main.Implementation;

namespace Weather.UI
{
    public static class Startup
    {
        public static DependencyInjectionContainer RegisterUIDependencies(this DependencyInjectionContainer container)
        {
            container.Add(block => block.Export<MainViewModel>().As<IMainViewModel>());
            return container;
        }
    }
}