using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boter_kaas_en_eieren_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // add action to all buttons inside panel2 
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)

                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }

        int XofO = 0;
        // create button action 
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {


                if (XofO % 2 == 0)
                {
                    btn.Text = "X";
                    label1.Text = "De beurt is aan O";
                    getTheWinner();
                }

                else

                {
                    btn.Text = "O";
                    label1.Text = "De beurt is aan X";
                    getTheWinner();
                }


                XofO++;
            }

        }


        bool win = false;
        public void getTheWinner()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winEffect(button1, button2, button3);
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                winEffect(button4, button5, button6);
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                winEffect(button7, button8, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                winEffect(button1, button4, button7);
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                winEffect(button2, button5, button8);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                winEffect(button3, button6, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                winEffect(button1, button5, button9);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                winEffect(button3, button5, button7);
                win = true;
            }

            if (AllBtnLength() == 9 && win == false)
            {
                label1.Text = "Geen winnaar";
            }
        }

        public int AllBtnLength()
        {
            int allTextButtonsLength = 0;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLength += c.Text.Length;
                }
            }
            return allTextButtonsLength;
        }

        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.BlueViolet;
            b2.BackColor = Color.BlueViolet;
            b3.BackColor = Color.BlueViolet;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

            label1.Text = b1.Text + " heeft gewonnen";
        }

        private void Opnieuw_Click(object sender, EventArgs e)
        {
            XofO = 0;
            win = false;
            label1.Text = "Speel";
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.WhiteSmoke;
                    c.ForeColor = Color.DeepSkyBlue;
                }
            }

        }
    }
}
