using CalculatorCore.Infrastructures;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace CalculatorCore.Controllers
{
    public class ControllerBuilder
    {
        private Controller _controller;

        public ControllerBuilder() => _controller = new Controller();

        public ControllerBuilder SetView(IView view)
        {
            _controller.View = view;
            return this;
        }

        public ControllerBuilder SetModel(IModel model)
        {
            _controller.Model = model;
            return this;
        }

        public ControllerBuilder SetConverter(INumberConverter converter)
        {
            _controller.Converter = converter;
            return this;
        }

        public Controller Build() => _controller;
    }
}
