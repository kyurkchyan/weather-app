using Grace.DependencyInjection;

namespace Weather.Forms
{
    public static class Startup
    {
        public static DependencyInjectionContainer RegisterFormsDependencies(this DependencyInjectionContainer container)
        {
            return container;
        }
    }
}
