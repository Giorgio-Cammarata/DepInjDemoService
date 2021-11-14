using DIdemoLibrary;

namespace DIdemoConsole
{
    public static class Dependency
    {
        public static SimpleInjector.Container Container = new();

        public static void Configure()
        {
            Container.Register<ILogger, ConsoleLogger>(SimpleInjector.Lifestyle.Transient);
            Container.Register<IApiService, ApiService>(SimpleInjector.Lifestyle.Transient);
        }
    }
}
