
namespace CalculatorCore.Views
{
    public interface IView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        string Result { set; }
    }

    public interface IConsoleView : IView
    {
        void WelcomeAction(string message);
    }

    public interface IWinFormView : IView
    {
        void ToDoAction(string message);
    }
}
