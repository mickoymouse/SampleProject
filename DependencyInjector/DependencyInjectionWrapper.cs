using Microsoft.Extensions.DependencyInjection;
using SampleLibrary.Calculator;

namespace DependencyInjector
{
    public class DependencyInjectionWrapper
    {
        private static readonly ServiceProvider ServiceProvider;

        static DependencyInjectionWrapper()
        {
            ServiceProvider = new ServiceCollection()
                .AddScoped<ICalculator, Calculator>()
                .BuildServiceProvider();
        }

        public static TService GetService<TService>() where TService : class
        {
            return ServiceProvider.GetRequiredService<TService>();
        }
    }
}
