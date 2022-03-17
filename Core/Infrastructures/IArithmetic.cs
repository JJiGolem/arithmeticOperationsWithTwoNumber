
namespace CalculatorCore.Infrastructures
{
    public interface IArithmetic
    {
        string Name { get; }
        double Result(double x, double y);
    }

    public class Div : IArithmetic
    {
        public string Name => "Division";

        public double Result(double x, double y) => x / y;
    }

    public class Sub : IArithmetic
    {
        public string Name => "Subtraction";

        public double Result(double x, double y) => x - y;
    }

    public class Sum : IArithmetic
    {
        public string Name => "Addition";
        public double Result(double x, double y) => x + y;
    }

    public class Mult : IArithmetic
    {
        public string Name => "Multiplication";
        public double Result(double x, double y) => x * y;
    }
}
