using CalculatorCore.Infrastructures;

namespace CalculatorCore.Models
{
    public interface IModel
    {
        public string Name { get; }
        double Execute(double x, double y);
    }
    
    public class Model : IModel
    {
        public string Name => _arithmetic.Name;

        private readonly IArithmetic _arithmetic;
        public Model(IArithmetic arithmetic) => _arithmetic = arithmetic;
        public double Execute(double x, double y) => _arithmetic.Result(x, y);
    }
}
