using Microsoft.Extensions.DependencyInjection;

namespace Runner.Tests
{
    public class BaseTest
    {
        protected readonly ISequenceAnalysis _sequenceAnalysis;
        protected readonly ISumOfMultiple _sumOfMultiple;

        public BaseTest()
        {
            //setup DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<ISequenceAnalysis, SequenceAnalysis>()
                .AddScoped<ISumOfMultiple, SumOfMultiple>()
                .BuildServiceProvider();

            _sequenceAnalysis = serviceProvider.GetService<ISequenceAnalysis>();
            _sumOfMultiple = serviceProvider.GetService<ISumOfMultiple>();
        }
    }
}
