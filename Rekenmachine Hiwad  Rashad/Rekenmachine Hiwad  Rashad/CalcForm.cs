using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Rekenmachine_Hiwad__Rashad
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private decimal firstNumber = 0.0m;
        private decimal secondNum = 0.0m;
        private decimal result = 0.0m;
        private int operatorType = (int)MathOperations.NoOperator;
        private bool containsEuro = false;

        public enum MathOperations
        {
            NoOperator = 0,
            Add = 1,
            Minus = 2,
            Divide = 3,
            Multiply = 4,
            Percentage = 5
        }




        private void DgtBtn_Clck(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }

            DisplayTextBox.Text += btn.Text;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains("."))
            {
                DisplayTextBox.Text += ".";
            }
        }

        private void EuroButton_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();

                if (!DisplayTextBox.Text.Contains("€"))
                {
                    containsEuro = true;
                    DisplayTextBox.Text = "€" + DisplayTextBox.Text;
                }
            }

            else
            {
                if (!DisplayTextBox.Text.Contains("€"))
                {
                    containsEuro = true;
                    DisplayTextBox.Text = "€" + DisplayTextBox.Text;
                }
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Divide);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Add);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Minus);
        }

        private void SaveValueAndOperatorType(int operation)
        {
            operatorType = operation;
            firstNumber = Convert.ToDecimal((Regex.Replace((DisplayTextBox.Text), "€", "")));
            DisplayTextBox.Text = "0";
        }
        


        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Percentage);
        }

        private void IsButton_Click(object sender, EventArgs e)
        {

            secondNum = Convert.ToDecimal((Regex.Replace((DisplayTextBox.Text), "€", "")));

            if (!(operatorType == 1 || operatorType == 2 || operatorType == 3 || operatorType == 4 || operatorType == 5))
            {
                SaveValueAndOperatorType((int)MathOperations.NoOperator);
            }

            switch (operatorType)
            {
                case 0:
                    result = firstNumber;
                    break;
                case 1:
                    result = firstNumber + secondNum;
                    break;
                case 2:
                    result = firstNumber - secondNum;
                    break;
                case 3:
                    result = firstNumber / secondNum;
                    break;
                case 4:
                    result = firstNumber * secondNum;
                    break;
                case 5:
                    result = (firstNumber / secondNum) * 100;
                    break;
            }
            if (containsEuro == false)
            {
                DisplayTextBox.Text = result.ToString();
            }
            else
            {
                DisplayTextBox.Text = "€" + result.ToString();
            }


        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            containsEuro = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            firstNumber = 0.0m;
            secondNum = 0.0m;
            result = 0;
            operatorType = 0;
            containsEuro = false;
        }


    }
}
