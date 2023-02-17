using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator
{
    public partial class Kalkylator : Form
    {
        private List<double> numbers = new List<double>();
        private List<string> operations = new List<string>();

        public Kalkylator()
        {
            InitializeComponent();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(display.Text)) return;
            numbers.Add(Convert.ToDouble(display.Text));

            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                switch (operations[i-1])
                {
                    case "+":
                        result += numbers[i];
                        break;
                    case "-":
                        result -= numbers[i];
                        break;
                    case "*":
                        result *= numbers[i];
                        break;
                    case "/":
                        result /= numbers[i];
                        break;
                }
            }

            display.Text = result.ToString();
            numbers.Clear();
            operations.Clear();
        }

        private void one_Click(object sender, EventArgs e)
        {
            UpdateValue("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            UpdateValue("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            UpdateValue("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            UpdateValue("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            UpdateValue("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            UpdateValue("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            UpdateValue("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            UpdateValue("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            UpdateValue("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            UpdateValue("0");
        }

        private void UpdateValue(string number)
        {
            display.Text += number;
        }

        // Enkelklick rensar det nuvarande värdet som visas
        // Dubbelklick rensar alla värden, du börjar alltså från 0
        private void clear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(display.Text))
            {
                numbers.Clear();
                operations.Clear();
            } else
            {
                display.Clear();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            StoreValuesAndOperations("+");
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            StoreValuesAndOperations("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            StoreValuesAndOperations("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            StoreValuesAndOperations("/");
        }

        private void StoreValuesAndOperations(string operation)
        {
            if (string.IsNullOrEmpty(display.Text)) return;
            numbers.Add(Convert.ToDouble(display.Text));
            operations.Add(operation);
            display.Clear();
        }
    }
}
