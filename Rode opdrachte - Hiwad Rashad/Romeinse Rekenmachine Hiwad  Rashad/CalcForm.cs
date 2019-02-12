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
using System.Numerics;

namespace Rekenmachine_Hiwad__Rashad
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private BigInteger firstNumber = 0;
        private BigInteger secondNum = 0;
        private BigInteger result = 0;
        private int operatorType = (int)MathOperations.NoOperator;
        private Dictionary<char, BigInteger> CharValues = null;
        private string[] ThouLetters = { "", "M", "MM", "MMM" };
        private string[] HundLetters =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] TensLetters =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] OnesLetters =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };


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


            {

                if (CharValues == null)
                {
                    CharValues = new Dictionary<char, BigInteger>();
                    CharValues.Add('I', 1);
                    CharValues.Add('V', 5);
                    CharValues.Add('X', 10);
                    CharValues.Add('L', 50);
                    CharValues.Add('C', 100);
                    CharValues.Add('D', 500);
                    CharValues.Add('M', 1000);
                }


                BigInteger total = 0;
                BigInteger last_value = 0;
                for (int i = DisplayTextBox.Text.Length - 1; i >= 0; i--)
                {
                    BigInteger new_value = CharValues[DisplayTextBox.Text[i]];

                    if (new_value < last_value)
                        total -= new_value;
                    else
                    {
                        total += new_value;
                        last_value = new_value;
                    }

                    firstNumber = total;
                }


            }
            DisplayTextBox.Text = "";
        }



        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }


        private void IsButton_Click(object sender, EventArgs e)
        {

            {

                if (CharValues == null)
                {
                    CharValues = new Dictionary<char, BigInteger>();
                    CharValues.Add('I', 1);
                    CharValues.Add('V', 5);
                    CharValues.Add('X', 10);
                    CharValues.Add('L', 50);
                    CharValues.Add('C', 100);
                    CharValues.Add('D', 500);
                    CharValues.Add('M', 1000);
                }


                BigInteger total = 0;
                BigInteger last_value = 0;
                for (int i = DisplayTextBox.Text.Length - 1; i >= 0; i--)
                {
                    BigInteger new_value = CharValues[DisplayTextBox.Text[i]];

                    if (new_value < last_value)
                        total -= new_value;
                    else
                    {
                        total += new_value;
                        last_value = new_value;
                    }

                    firstNumber = total;
                }
                secondNum = total;


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


                if (firstNumber > 3000 || secondNum > 3000)
                {
                    DisplayTextBox.Text = "Number too big stay below 3000";
                    firstNumber = 0;
                    secondNum = 0;
                    result = 0;
                    operatorType = 0;
                }
                else
                {
                    string endresult = "";



                    BigInteger num;
                    num = (result / 1000);
                    endresult += (ThouLetters[(long)num]);
                    result %= 1000;


                    num = ((long)result / 100);
                    endresult += HundLetters[(long)num];
                    result %= 100;

                    num = ((long)result / 10);
                    endresult += TensLetters[(long)num];
                    result %= 10;

                    endresult += OnesLetters[(long)result];

                    DisplayTextBox.Text = endresult;
                }
            }


        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "";
            firstNumber = 0;
            secondNum = 0;
            result = 0;
            operatorType = 0;
        }


    }
}



