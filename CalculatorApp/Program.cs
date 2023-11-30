using DependencyInjector;
using SampleLibrary.Calculator;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = DependencyInjectionWrapper.GetService<ICalculator>();

            int a = 10, b = 20;
            Console.WriteLine($"Sum of {a} and {b} is {calculator.Add(a, b)}.");
        }
    }
}
