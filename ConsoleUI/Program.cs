using System;
using CalculatorCore.Controllers;
using CalculatorCore.Infrastructures;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace ConsoleApp1
{
    class UI : IConsoleView
    {
        public string FirstNumber
        {
            get { Console.Write("FirstNumber: "); return Console.ReadLine(); }
        }

        public string SecondNumber
        {
            get { Console.Write("SecondNumber: "); return Console.ReadLine(); }
        }

        public string Result 
        {
            set { Console.WriteLine($"Result: {value}"); }
        }

        public void WelcomeAction(string message)
        {
            Console.WriteLine($"{message}");
        }
    }

    class Program
    {
        private static Controller _controller;
        static void Main(string[] args)
        {
            _controller = new ControllerBuilder()
                                .SetView(new UI())
                                .SetModel(new Model(new Sum()))
                                .SetConverter(new NumberConverter())
                                .Build();

            bool isOpen = true;
            while (isOpen)
            {
                Console.Clear();
                (_controller.View as UI)?.WelcomeAction("====|Arithmetic operation solver for two numbers|====\n");

                Console.WriteLine("Select operation:");
                Console.WriteLine("1) +");
                Console.WriteLine("2) -");
                Console.WriteLine("3) x");
                Console.WriteLine("4) /");
                Console.WriteLine("5) Exit");

                Console.Write("\nEnter number: ");
                string enteredValue = Console.ReadLine();
                while (int.TryParse(enteredValue, out int number) == false)
                {
                    Console.Write("Enter number: ");
                    enteredValue = Console.ReadLine();
                }
                    

                int operationNumber = int.Parse(enteredValue);
                switch (operationNumber)
                {
                    case 1:
                        _controller.Model = new Model(new Sum());
                        break;
                    case 2:
                        _controller.Model = new Model(new Sub());
                        break;
                    case 3:
                        _controller.Model = new Model(new Mult());
                        break;
                    case 4:
                        _controller.Model = new Model(new Div());
                        break;
                    case 5:
                        isOpen = false;
                        continue;
                    default:
                        Console.WriteLine("No valid operation number. Try Again");
                        Console.ReadLine();
                        continue;
                }

                Console.WriteLine("=================================");
                Console.WriteLine($"Operation: {_controller.Model.Name}\n");
                _controller.ButtonClick();
                Console.ReadLine();
            }
        }
    }
}
