
namespace CalculatorCore.Infrastructures
{
    public interface INumberConverter
    {
        double Convert(string value);
        string ConvertBack(double value);
    }

    public class NumberConverter : INumberConverter
    {
        public double Convert(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }

        public string ConvertBack(double value)
        {
            return $"{value}";
        }
    }
}
