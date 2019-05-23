using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class HomeCalculator : Form
    {
        public HomeCalculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, Result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            Result = firstNumber + secondNumber;
            resultTextBox.Text = Convert.ToString(Result);
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, Result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            Result = firstNumber - secondNumber;
            resultTextBox.Text = Convert.ToString(Result);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, Result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            Result = firstNumber * secondNumber;
            resultTextBox.Text = Convert.ToString(Result);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber;
            double Result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            Result = (double)firstNumber / secondNumber;
            resultTextBox.Text = Convert.ToString(Result);
        }
    }
}
