using DIdemoLibrary;

namespace TestDIdemo.UnitTests
{
    public static class Dependency
    {
        public static SimpleInjector.Container Container = new();

        public static void Configure()
        {
            Container.Register<ILogger, TraceLogger>(SimpleInjector.Lifestyle.Transient);
            Container.Register<IApiService, ApiServiceMock>(SimpleInjector.Lifestyle.Transient);
        }
    }
}
