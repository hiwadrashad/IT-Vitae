using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;




namespace Scientific_Calculator___Hiwad_Rashad
{

   

    public partial class Form1 : Form
    {
        int angletype = 1;
        bool onevalueneeded = false;
        bool firstpart = true;
        string firstnumber = "";
        string secondnumber = "";
        bool sinclicked = false;
        bool cosclicked = false;
        bool tanclicked = false;
        bool CEclicked = false;
        bool Cclicked = false;
        bool sinminusoneclicked = false;
        bool cosminusoneclicked = false;
        bool tanminusoneclicked = false;
        bool deleteclicked = false;
        bool logclicked = false;
        bool expclicked = false;
        bool modclicked = false;
        bool divideclicked = false;
        bool lnclicked = false;
        bool nexclamationclicked = false;
        bool pieclicked = false;
        bool xclicked = false;
        bool minusclicked = false;
        bool onedividedbyxclicked = false;
        bool eexponentialxclicked = false;
        bool tenexponentialxclicked = false;
        bool ysquarerootxclicked = false;
        bool plusclicked = false;
        bool xexponentialtwoclicked = false;
        bool xexponentialthreeclicked = false;
        bool xexponentialyclicked = false;
        bool squarerootclicked = false;
        bool dotclicked = false;
        bool equalsclicked = false;
        bool dotalreadyclicked = false;
        bool openingbracketclicked = false;





        public Form1()
        {
            InitializeComponent();
        }



        private void zero_Click(object sender, EventArgs e)
        {
         
            if (firstpart == true)
            {
                firstnumber = firstnumber + "0";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "0";
                textBox1.Text = secondnumber;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "1";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "1";
                textBox1.Text = secondnumber;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "2";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "2";
                textBox1.Text = secondnumber;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "3";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "3";
                textBox1.Text = secondnumber;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "4";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "4";
                textBox1.Text = secondnumber;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "5";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "5";
                textBox1.Text = secondnumber;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "6";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "6";
                textBox1.Text = secondnumber;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "7";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "7";
                textBox1.Text = secondnumber;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "8";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "8";
                textBox1.Text = secondnumber;
            }
        }


        private void nine_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "9";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + "9";
                textBox1.Text = secondnumber;
            }
        }

        #region equals
        private void equals_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == true)
            {
 
            
            
                    if (firstpart == true)
                    {
                        Expression number = new Expression(firstnumber);
                        double endnumber = Convert.ToDouble(number.Evaluate());
                        textBox1.Text = Convert.ToString(endnumber);
                        openingbracketclicked = false;
                    }
                    else
                    {
                        Expression number = new Expression(secondnumber);
                        double endnumber = Convert.ToDouble(number.Evaluate());
                        textBox1.Text = Convert.ToString(endnumber);
                        openingbracketclicked = false;
                    }
             
            }
            

            if (plusclicked == true)
            {
                
                equalsclicked = true;
                secondnumber = textBox1.Text;
                decimal endresult = (decimal.Parse(firstnumber)) + (decimal.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                plusclicked = false;
            }

            if (minusclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                decimal endresult = (decimal.Parse(firstnumber)) - (decimal.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                minusclicked = false;
            }

            if (divideclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                decimal endresult = (decimal.Parse(firstnumber)) / (decimal.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                divideclicked = false;
            }

            if (xclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                decimal endresult = (decimal.Parse(firstnumber)) * (decimal.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                xclicked = false;
            }

            if (squarerootclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Sqrt(double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                squarerootclicked = false;
            }

            if (tenexponentialxclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Pow(10, double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                tenexponentialxclicked = false;
            }

            if (modclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                decimal endresult = (decimal.Parse(firstnumber)) % (decimal.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                modclicked = false;
            }


            if (xexponentialyclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                double endresult = Math.Pow(double.Parse(firstnumber), double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                xexponentialyclicked = false;
            }


            if (ysquarerootxclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                double endresult = Math.Pow(double.Parse(firstnumber),1/( double.Parse(secondnumber)));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                ysquarerootxclicked = false;
            }

            if (nexclamationclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                decimal endresult = (decimal.Parse(secondnumber));
                int i = 1;
                decimal endendresult = endresult;
                if (endresult > 1)
                {
                    while (i == endresult)
                    {
                        endendresult = endendresult * (endresult - i);
                    }
                }
                else if (endresult == 1)
                { endendresult = 1; }
                textBox1.Text = Convert.ToString(endendresult);
                firstnumber = Convert.ToString(endendresult);
                secondnumber = "";
                dotalreadyclicked = false;
                nexclamationclicked = false;
            }

            if (eexponentialxclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Pow((Math.E), double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                eexponentialxclicked = false;
            }

            if (xexponentialthreeclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Pow((double.Parse(secondnumber)), 3);
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                xexponentialthreeclicked = false;
            }

            if (xexponentialtwoclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Pow((double.Parse(secondnumber)), 2);
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                xexponentialtwoclicked = false;
            }

            if (onedividedbyxclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = (1 / (double.Parse(secondnumber)));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                xexponentialtwoclicked = false;
            }

            if (cosclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Cos(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Cos(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Cos(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosclicked = false;
                }
            }

            if (sinclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Sin(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Sin(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Sin(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinclicked = false;
                }
            }

            if (sinminusoneclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Asin(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinminusoneclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Asin(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinminusoneclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Asin(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    sinminusoneclicked = false;
                }
            }

            if (cosminusoneclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Acos(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosminusoneclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Acos(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosminusoneclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Acos(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    cosminusoneclicked = false;
                }
            }

            if (tanclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Tan(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Tan(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Tan(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanclicked = false;
                }
            }

            if (tanminusoneclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (angletype == 2)
                {
                    double endresult = Math.Atan(double.Parse(secondnumber));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanminusoneclicked = false;
                }
                if (angletype == 1)
                {
                    double endresult = Math.Atan(double.Parse(secondnumber) * (200 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanminusoneclicked = false;
                }
                if (angletype == 3)
                {
                    double endresult = Math.Atan(double.Parse(secondnumber) * (180 / 3.14159265359));
                    textBox1.Text = Convert.ToString(endresult);
                    firstnumber = Convert.ToString(endresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    tanminusoneclicked = false;
                }
            }

            if (logclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Log(double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                logclicked = false;
            }

            if (lnclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                double endresult = Math.Pow(2.7182818284590452353602874713527, double.Parse(secondnumber));
                textBox1.Text = Convert.ToString(endresult);
                firstnumber = Convert.ToString(endresult);
                secondnumber = "";
                dotalreadyclicked = false;
                logclicked = false;
            }

            if (expclicked == true)
            {
                equalsclicked = true;
                secondnumber = textBox1.Text;
                textBox1.Text = "";
                if (secondnumber[0] == '0')
                {
                    if (secondnumber.Length <= 1)
                    {
                        string thirdnumber = secondnumber;
                        secondnumber = "0e+0";
                        textBox1.Text = secondnumber;
                        firstnumber = thirdnumber;
                        secondnumber = "";
                        dotalreadyclicked = false;
                        expclicked = false;

                    }
                    else
                    {
                        string thirdnumber = secondnumber;
                        int a = secondnumber.IndexOf('1');
                        int b = secondnumber.IndexOf('2');
                        int c = secondnumber.IndexOf('3');
                        int d = secondnumber.IndexOf('4');
                        int f = secondnumber.IndexOf('5');
                        int g = secondnumber.IndexOf('6');
                        int h = secondnumber.IndexOf('7');
                        int i = secondnumber.IndexOf('8');
                        int j = secondnumber.IndexOf('9');

                        var numbers = new[] { a, b, c, d, f, g, h, i, j };
                        int highestnumber = numbers.Max();
                        int dotlocation = secondnumber.IndexOf('.');
                        int amountofzeros = (highestnumber - dotlocation) + 1;

                        if (secondnumber[highestnumber + 1] == '1' || secondnumber[highestnumber + 1] == '2' || secondnumber[highestnumber + 1] == '3' || secondnumber[highestnumber + 1] == '4' || secondnumber[highestnumber + 1] == '5' || secondnumber[highestnumber + 1] == '6' || secondnumber[highestnumber + 1] == '7' || secondnumber[highestnumber + 1] == '8' || secondnumber[highestnumber + 1] == '9')
                        {
                            secondnumber = "";
                            secondnumber = Convert.ToString(thirdnumber[highestnumber]) + "." + (Convert.ToString(thirdnumber[highestnumber + 1]) + "e-" + Convert.ToString(amountofzeros));
                            firstnumber = Convert.ToString(thirdnumber);
                            textBox1.Text = Convert.ToString(secondnumber);
                            secondnumber = "";
                            dotalreadyclicked = false;
                            expclicked = false;
                        }
                        else
                        {
                            secondnumber = "";
                            secondnumber = Convert.ToString(thirdnumber[highestnumber] + "e-" + Convert.ToString(amountofzeros));
                            firstnumber = Convert.ToString(thirdnumber);
                            textBox1.Text = Convert.ToString(secondnumber);
                            secondnumber = "";
                            dotalreadyclicked = false;
                            expclicked = false;
                        }

                    }


                }
                else
                {
                    if (secondnumber.Length <= 1)
                    {
                        string thirdnumber = secondnumber;
                        secondnumber = secondnumber + "e+0";
                        textBox1.Text = Convert.ToString(secondnumber);
                        firstnumber = Convert.ToString(thirdnumber);
                        secondnumber = "";
                        dotalreadyclicked = false;
                        expclicked = false;

                    }
                    else if (secondnumber.Length == 2)
                    {
                        string a = Convert.ToString(secondnumber[0]);
                        string b = Convert.ToString(secondnumber[1]);
                        string thirdnumber = secondnumber;
                        secondnumber = "";
                        secondnumber = a + "." + b + "e+0";
                        textBox1.Text = Convert.ToString(secondnumber);
                        firstnumber = Convert.ToString(thirdnumber);
                        secondnumber = "";
                        dotalreadyclicked = false;
                        expclicked = false;

                    }
                    else 
                    {
                        string a = Convert.ToString(secondnumber[0]);
                        string b = Convert.ToString(secondnumber[1]);
                        int countnumbers = secondnumber.Length;
                        string thirdnumber = secondnumber;
                        countnumbers = countnumbers - 2;
                        secondnumber = "";
                        secondnumber = a + "." + b + "e+" + Convert.ToString(countnumbers);
                        textBox1.Text = Convert.ToString(secondnumber);
                        firstnumber = Convert.ToString(thirdnumber);
                        secondnumber = "";
                        dotalreadyclicked = false;
                        expclicked = false;
                    }
                }
            
            }
        }


        #endregion


        private void plus_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    plusclicked = true;
                    dotalreadyclicked = false;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = firstnumber + "+";
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = secondnumber + "+";
                    textBox1.Text = secondnumber;
                }
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    minusclicked = true;
                    dotalreadyclicked = false;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = firstnumber + "-";
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = secondnumber + "-";
                    textBox1.Text = secondnumber;
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    divideclicked = true;
                    dotalreadyclicked = false;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = firstnumber + "/";
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = secondnumber + "/";
                    textBox1.Text = secondnumber;
                }
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    xclicked = true;
                    dotalreadyclicked = false;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = firstnumber + "*";
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = secondnumber + "*";
                    textBox1.Text = secondnumber;
                }
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (firstpart == true && dotalreadyclicked == false)
            {
                firstnumber = firstnumber + ".";
                textBox1.Text = firstnumber;
                dotalreadyclicked = true;
            }
            else if (dotalreadyclicked == false)
            {
                secondnumber = secondnumber + ".";
                textBox1.Text = secondnumber;
                dotalreadyclicked = true;
            }
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    squarerootclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Sqrt(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Sqrt(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void ysquarerootx_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    ysquarerootxclicked = true;
                }
                else
                {
                   
                }
            }
            else
            {
                {
                    if (firstpart == true)
                    {
                        firstnumber = "Pow(" + firstnumber + ",1/";
                        textBox1.Text = Convert.ToString(firstnumber);

                    }
                    else
                    {
                        firstnumber = "Pow(" + secondnumber + ",1/";
                        textBox1.Text = Convert.ToString(secondnumber);

                    }
                }
            }
        }

        private void xexponentialy_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    xexponentialyclicked = true;
                    dotalreadyclicked = false;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber =  firstnumber + "^";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber =  secondnumber + "^";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void tenexponentialx_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    tenexponentialxclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Pow(10," + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Pow(10," + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }

        }

        private void pie_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true)
                {
                    firstnumber = Convert.ToString(3.14159265359);
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = Convert.ToString(3.14159265359);
                    textBox1.Text = secondnumber;
                }
            }
            else
            {

                if (firstpart == true)
                {
                    firstnumber = firstnumber + "3.14159265359";
                    textBox1.Text = firstnumber;
                }
                else
                {
                    secondnumber = secondnumber + "3.14159265359";
                    textBox1.Text = secondnumber;
                }
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == true)
            {


                if (firstpart == true || equalsclicked == true)
                {
                    textBox1.Text = "";
                    firstpart = false;
                    xclicked = true;
                    dotalreadyclicked = false;
                    modclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber =  firstnumber + "%";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber =  secondnumber + "%";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void tanminus1_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    tanminusoneclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Atan(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Atan(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    tanclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Tan(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Tan(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    cosclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Cos(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Cos(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void cosminus1_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    cosminusoneclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Acos(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Acos(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            if (firstpart == true || equalsclicked == true)
            {
                firstpart = false;
                expclicked = true;
            }
            else
            {

            }
        }

        private void nexclamation_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    nexclamationclicked = true;
                }
                else
                {

                }
            }
            else
            {
                {
         
                    Expression number = new Expression(textBox1.Text);
                    double endnumber = Convert.ToDouble(number.Evaluate());
                    openingbracketclicked = false;
                    equalsclicked = true;
                    textBox1.Text = "";
                    double endresult = endnumber;
                    int i = 1;
                    double endendresult = endresult;
                    if (endresult > 1)
                    {
                        while (i == endresult)
                        {
                            endendresult = endendresult * (endresult - i);
                        }
                    }
                    else if (endresult == 1)
                    { endendresult = 1; }
                    textBox1.Text = Convert.ToString(endendresult);
                    firstnumber = Convert.ToString(endendresult);
                    secondnumber = "";
                    dotalreadyclicked = false;
                    nexclamationclicked = false;
                }

            }
        }

        private void eexponentialx_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    eexponentialxclicked = true;
                }
                else
                {

                }
            }
            else

            {
                if (firstpart == true)
                {
                    firstnumber = "Pow(" + firstnumber + ",";
                    textBox1.Text = Convert.ToString(firstnumber);

                }
                else
                {
                    firstnumber = "Pow(" + secondnumber + ",";
                    textBox1.Text = Convert.ToString(secondnumber);

                }
            }

        }

        private void xexponential3_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    xexponentialthreeclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Pow(" + firstnumber + ",3)";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Pow(" + secondnumber + ",3)";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void xexponential2_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    xexponentialtwoclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Pow(" + firstnumber + ",2)";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Pow(" + secondnumber + ",2)";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void onedividedbyx_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    onedividedbyxclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "1/" + firstnumber;
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "1/" + secondnumber;
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    lnclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Pow(2.718," + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Pow(2.718," + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    logclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Log(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Log(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void sinminus1_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    sinminusoneclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Asin(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Asin(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (openingbracketclicked == false)
            {
                if (firstpart == true || equalsclicked == true)
                {
                    firstpart = false;
                    sinclicked = true;
                }
                else
                {

                }
            }
            else
            {
                if (firstpart == true)
                {
                    firstnumber = "Sin(" + firstnumber + ")";
                    textBox1.Text = Convert.ToString(firstnumber);
                }
                else
                {
                    firstnumber = "Sin(" + secondnumber + ")";
                    textBox1.Text = Convert.ToString(secondnumber);
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            angletype = 1;
            textBox1.Text = "";
            onevalueneeded = false;
            firstpart = true;
            firstnumber = "";
            secondnumber = "";
            sinclicked = false;
            cosclicked = false;
            tanclicked = false;
            CEclicked = false;
            Cclicked = false;
            sinminusoneclicked = false;
            cosminusoneclicked = false;
            tanminusoneclicked = false;
            deleteclicked = false;
            logclicked = false;
            expclicked = false;
            modclicked = false;
            divideclicked = false;
            lnclicked = false;
            nexclamationclicked = false;
            pieclicked = false;
            xclicked = false;
            minusclicked = false;
            onedividedbyxclicked = false;
            eexponentialxclicked = false;
            tenexponentialxclicked = false;
            ysquarerootxclicked = false;
            plusclicked = false;
            xexponentialtwoclicked = false;
            xexponentialthreeclicked = false;
            xexponentialyclicked = false;
            squarerootclicked = false;
            dotclicked = false;
            equalsclicked = false;
            dotalreadyclicked = false;

        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = "";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = "";
                textBox1.Text = secondnumber;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber.Substring(0,firstnumber.Length - 1);
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber.Substring(0,firstnumber.Length - 1);
                textBox1.Text = secondnumber;
            }
        }

        private void Rad_Click(object sender, EventArgs e)
        {
            angletype = 2;
        }

        private void Grad_Click(object sender, EventArgs e)
        {
            angletype = 3;
        }

        private void Deg_Click(object sender, EventArgs e)
        {
            angletype = 1;
        }

        private void openingbracket_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + "(";
                textBox1.Text = firstnumber;
                openingbracketclicked = true;
            }
            else
            {
                secondnumber = secondnumber + "(";
                textBox1.Text = secondnumber;
                openingbracketclicked = true;
            }
        }

        private void endingbracket_Click(object sender, EventArgs e)
        {
            if (firstpart == true)
            {
                firstnumber = firstnumber + ")";
                textBox1.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + ")";
                textBox1.Text = secondnumber;
            }
        }
    }
}
