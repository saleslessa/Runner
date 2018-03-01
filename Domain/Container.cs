using Microsoft.Extensions.DependencyInjection;

namespace Runner.Domain
{
    public static class Container
    {
        public static ServiceProvider serviceProvider = new ServiceCollection()
            .AddScoped<ISequenceAnalysis, SequenceAnalysis>()
            .AddScoped<ISumOfMultiple, SumOfMultiple>()
            .BuildServiceProvider();

        public static T GetService<T>() => serviceProvider.GetService<T>();
    }
}
