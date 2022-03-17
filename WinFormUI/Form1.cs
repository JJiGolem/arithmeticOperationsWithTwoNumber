using System;
using System.Windows.Forms;
using CalculatorCore.Views;
using CalculatorCore.Models;
using CalculatorCore.Controllers;
using CalculatorCore.Infrastructures;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IWinFormView
    {
        private Controller _controller;

        public Form1()
        {
            InitializeComponent();

            _controller = new ControllerBuilder()
                              .SetView(this)
                              .SetModel(new Model(new Sum()))
                              .SetConverter(new NumberConverter())
                              .Build();

            sumRadioBtn.Checked = true;
            calculateBtn.Click += delegate { _controller.ButtonClick(); };
        }

        public string FirstNumber => firstNumberTextBox.Text;

        public string SecondNumber => secondNumberTextBox.Text;

        public string Result { set => MessageBox.Show("Result: " + value, _controller?.Model.Name); }

        public void ToDoAction(string message)
        {
            MessageBox.Show(message);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button == null)
                return;

            if (_controller == null)
                return;

            switch (button.Text)
            {
                case "+":
                    _controller.Model = new Model(new Sum());
                    break;
                case "-":
                    _controller.Model = new Model(new Sub());
                    break;
                case "x":
                    _controller.Model = new Model(new Mult());
                    break;
                case "/":
                    _controller.Model = new Model(new Div());
                    break;
                default:
                    MessageBox.Show("Not valid operation", button.Text, MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
