namespace SampleLibrary.Calculator
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
