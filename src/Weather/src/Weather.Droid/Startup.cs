using Grace.DependencyInjection;

namespace Weather.Droid
{
    public static class Startup
    {
        public static DependencyInjectionContainer RegisterDroidDependencies(this  DependencyInjectionContainer container)
        {
            return container;
        }
    }
}
