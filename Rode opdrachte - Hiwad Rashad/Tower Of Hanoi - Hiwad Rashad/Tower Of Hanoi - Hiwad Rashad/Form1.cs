using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_Of_Hanoi___Hiwad_Rashad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TransparencyKey = Color.Red;

       
        }
        int position1x = 0;
        int position2x = 0;
        int position3x = 0;
        int position4x = 0;
        int position5x = 0;
        int position6x = 0;
        int position7x = 0;
        int position8x = 0;
        int position9x = 0;
        int position10x = 0;
        int position11x = 0;
        int position12x = 0;
        int position13x = 0;
        int position14x = 0;
        int position15x = 0;
        int position16x = 0;
        int position17x = 0;
        int position18x = 0;
        int position19x = 0;
        int position20x = 0;
        int position21x = 0;
        int position22x = 0;
        int position23x = 0;
        int position24x = 0;
        bool position1 = true;
        bool position2 = true;
        bool position3 = true;
        bool position4 = true;
        bool position5 = true;
        bool position6 = true;
        bool position7 = true;
        bool position8 = true;
        bool position9 = false;
        bool position10 = false;
        bool position11= false;
        bool position12 = false;
        bool position13 = false;
        bool position14 = false;
        bool position15 = false;
        bool position16 = false;
        bool position17 = false;
        bool position18 = false;
        bool position19 = false;
        bool position20 = false;
        bool position21 = false;
        bool position22 = false;
        bool position23 = false;
        bool position24 = false;
        bool select1 = false;
        bool select2 = false;
        bool select3 = false;








        private void Select1_Click(object sender, EventArgs e)
        {
            select1 = true;
        }

        private void Move1_Click(object sender, EventArgs e)
        {
            bool locked9 = true;
            bool locked10 = true;
            bool locked11 = true;
            bool locked12 = true;
            bool locked13 = true;
            bool locked14 = true;
            bool locked15 = true;
            bool locked16 = true;
            bool locked17 = true;
            bool locked18 = true;
            bool locked19 = true;
            bool locked20 = true;
            bool locked21 = true;
            bool locked22 = true;
            bool locked23 = true;
            bool locked24 = true;


            if (select2 == true)
            {
                if (pictureBox1.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked9 = false; }
                else
                if (pictureBox2.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked10 = false; }
                else
                if (pictureBox3.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked11 = false; }
                else
                if (pictureBox4.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked12 = false; }
                else
                if (pictureBox5.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked13 = false; }
                else
                if (pictureBox6.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked14 = false; }
                else
                if (pictureBox7.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked15 = false; }
                else
                if (pictureBox8.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked16 = false; }
            }

            if (select3 == true)
            {
                if (pictureBox1.Location.X > 500)
                { locked17 = false; }
                else
                if (pictureBox2.Location.X > 500)
                { locked18 = false; }
                else
                if (pictureBox3.Location.X > 500)
                { locked19 = false; }
                else
                if (pictureBox4.Location.X > 500)
                { locked20 = false; }
                else
                if (pictureBox5.Location.X > 500)
                { locked21 = false; }
                else
                if (pictureBox6.Location.X > 500)
                { locked22 = false; }
                else
                if (pictureBox7.Location.X > 500)
                { locked23 = false; }
                else
                if (pictureBox8.Location.X > 500)
                { locked24 = false; }
            }

            select1 = false;
            select3 = false;
            select2 = false;





            if (locked9 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position1 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155);
                    pictureBox1.BringToFront();
                    position1 = true;
                    position1x = 8;
                }
                else
                if (position2 == false && position1x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16));
                    pictureBox1.BringToFront();
                    position2 = true;
                    position2x = 8;
                }
                else
                if (position3 == false && position2x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position3 = true;
                    position3x = 8;
                }
                else
                if (position4 == false && position3x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position4 = true;
                    position4x = 8;
                }
                else
                if (position5 == false && position4x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position5 = true;
                    position5x = 8;
                }
                else
                if (position6 == false && position5x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position6 = true;
                    position6x = 8;
                }
                else
                if (position7 == false && position6x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position7 = true;
                    position7x = 8;
                }
                else
                if (position8 == false && position7x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position8 = true;
                    position8x = 8;
                }

            }


            if (locked10 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position1 = true;
                    position1x = 7;
                }
                else
                if (position2 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position2 = true;
                    position2x = 7;
                }
                else
                if (position3 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position3 = true;
                    position3x = 7;
                }
                else
                if (position4 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99  + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position4 = true;
                    position4x = 7;
                }
                else
                if (position5 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position5 = true;
                    position5x = 7;
                }
                else
                if (position6 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position6 = true;
                    position6x = 7;
                }
                else
                if (position7 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position7 = true;
                    position7x = 7;
                }
                else
                if (position8 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position8 = true;
                    position8x = 7;
                }

            }

            if (locked11 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position1 = true;
                    position1x = 6;
                }
                else
                if (position2 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position2 = true;
                    position2x = 6;
                }
                else
                if (position3 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position3 = true;
                    position3x = 6;
                }
                else
                if (position4 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position4 = true;
                    position4x = 6;
                }
                else
                if (position5 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position5 = true;
                    position5x = 6;
                }
                else
                if (position6 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position6 = true;
                    position6x = 6;
                }
                else
                if (position7 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position7 = true;
                    position7x = 6;
                }
                else
                if (position8 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position8 = true;
                    position8x = 6;
                }

            }

            if (locked12 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16= false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position1 = true;
                    position1x = 5;
                }
                else
                if (position2 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position2 = true;
                    position2x = 5;
                }
                else
                if (position3 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position3 = true;
                    position3x = 5;
                }
                else
                if (position4 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position4 = true;
                    position4x = 5;
                }
                else
                if (position5 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position5 = true;
                    position5x = 5;
                }
                else
                if (position6 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position6 = true;
                    position6x = 5;
                }
                else
                if (position7 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position7 = true;
                    position7x = 5;
                }
                else
                if (position8 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position8 = true;
                    position8x = 5;
                }

            }


            if (locked13 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position1 = true;
                    position1x = 4;
                }
                else
                if (position2 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position2 = true;
                    position2x = 4;
                }
                else
                if (position3 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position3 = true;
                    position3x = 4;
                }
                else
                if (position4 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position4 = true;
                    position4x = 4;
                }
                else
                if (position5 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position5 = true;
                    position5x = 4;
                }
                else
                if (position6 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    else
                        pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position6 = true;
                    position6x = 4;
                }
                else
                if (position7 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position7 = true;
                    position7x = 4;
                }
                else
                if (position8 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position8 = true;
                    position8x = 4;
                }

            }


            if (locked14 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position1 = true;
                    position1x = 3;
                }
                else
                if (position2 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position2 = true;
                    position2x = 3;
                }
                else
                if (position3 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position3 = true;
                    position3x = 3;
                }
                else
                if (position4 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position4 = true;
                    position4x = 3;
                }
                else
                if (position5 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position5 = true;
                    position5x = 3;
                }
                else
                if (position6 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position6 = true;
                    position6x = 3;
                }
                else
                if (position7 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position7 = true;
                    position7x = 3;
                }
                else
                if (position8 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position8 = true;
                    position8x = 3;
                }

            }

            if (locked15 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position1 = true;
                    position1x = 2;
                }
                else
                if (position2 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position2 = true;
                    position2x = 2;
                }
                else
                if (position3 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position3 = true;
                    position3x = 2;
                }
                else
                if (position4 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position4 = true;
                    position4x = 2;
                }
                else
                if (position5 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position5 = true;
                    position5x = 2;
                }
                else
                if (position6 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position6 = true;
                    position6x = 2;
                }
                else
                if (position7 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position7 = true;
                    position7x = 2;
                }
                else
                if (position8 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position8 = true;
                    position8x = 2;
                }

            }

            if (locked16 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155);
                    pictureBox8.BringToFront();
                    position1 = true;
                    position1x = 1;
                }
                else
                if (position2 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position2 = true;
                    position2x = 1;
                }
                else
                if (position3 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position3 = true;
                    position3x = 1;
                }
                else
                if (position4 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position4 = true;
                    position4x = 1;
                }
                else
                if (position5 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position5 = true;
                    position5x = 1;
                }
                else
                if (position6 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position6 = true;
                    position6x = 1;
                }
                else
                if (position7 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position7 = true;
                    position7x = 1;
                }
                else
                if (position8 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position8 = true;
                    position8x = 1;
                }

            }


            if (locked17 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position1 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155);
                    pictureBox1.BringToFront();
                    position1 = true;
                    position1x = 8;
                }
                else
                if (position2 == false && position9x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16));
                    pictureBox1.BringToFront();
                    position2 = true;
                    position2x = 8;
                }
                else
                if (position3 == false && position10x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position3 = true;
                    position3x = 8;
                }
                else
                if (position4 == false && position11x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position4 = true;
                    position4x = 8;
                }
                else
                if (position5 == false && position12x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position5 = true;
                    position15x = 8;
                }
                else
                if (position6 == false && position13x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position6 = true;
                    position6x = 8;
                }
                else
                if (position7 == false && position14x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position7 = true;
                    position7x = 8;
                }
                else
                if (position8 == false && position15x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(99, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position8 = true;
                    position8x = 8;
                }

            }


            if (locked18 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position1 = true;
                    position1x = 7;
                }
                else
                if (position2 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position2 = true;
                    position2x = 7;
                }
                else
                if (position3 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position3 = true;
                    position3x = 7;
                }
                else
                if (position4 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position4 = true;
                    position4x = 7;
                }
                else
                if (position5 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position5 = true;
                    position5x = 7;
                }
                else
                if (position6 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position6 = true;
                    position6x = 7;
                }
                else
                if (position7 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position7 = true;
                    position7x = 7;
                }
                else
                if (position8 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(99 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position8 = true;
                    position8x = 7;
                }

            }

            if (locked19 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position1 = true;
                    position1x = 6;
                }
                else
                if (position2 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position2 = true;
                    position2x = 6;
                }
                else
                if (position3 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position3 = true;
                    position3x = 6;
                }
                else
                if (position4 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position4 = true;
                    position4x = 6;
                }
                else
                if (position5 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position5 = true;
                    position5x = 6;
                }
                else
                if (position6 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position6 = true;
                    position6x = 6;
                }
                else
                if (position7 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position7 = true;
                    position7x = 6;
                }
                else
                if (position8 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(99 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position8 = true;
                    position8x = 6;
                }

            }

            if (locked20 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position1 = true;
                    position1x = 5;
                }
                else
                if (position2 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position2 = true;
                    position2x = 5;
                }
                else
                if (position3 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position3 = true;
                    position3x = 5;
                }
                else
                if (position4 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position4 = true;
                    position4x = 5;
                }
                else
                if (position5 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position5 = true;
                    position5x = 5;
                }
                else
                if (position6 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position6 = true;
                    position6x = 5;
                }
                else
                if (position7 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position7 = true;
                    position7x = 5;
                }
                else
                if (position8 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(99 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position8 = true;
                    position8x = 5;
                }

            }


            if (locked21 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position1 = true;
                    position1x = 4;
                }
                else
                if (position2 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position2 = true;
                    position2x = 4;
                }
                else
                if (position3 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position3 = true;
                    position3x = 4;
                }
                else
                if (position4 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position4 = true;
                    position4x = 4;
                }
                else
                if (position5 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position5 = true;
                    position5x = 4;
                }
                else
                if (position6 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position6 = true;
                    position6x = 4;
                }
                else
                if (position7 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position7 = true;
                    position7x = 4;
                }
                else
                if (position8 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(99 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position8 = true;
                    position8x = 4;
                }

            }


            if (locked22 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position1 = true;
                    position1x = 3;
                }
                else
                if (position2 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position2 = true;
                    position2x = 3;
                }
                else
                if (position3 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position3 = true;
                    position3x = 3;
                }
                else
                if (position4 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position4 = true;
                    position4x = 3;
                }
                else
                if (position5 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position5 = true;
                    position5x = 3;
                }
                else
                if (position6 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position6 = true;
                    position6x = 3;
                }
                else
                if (position7 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position7 = true;
                    position7x = 3;
                }
                else
                if (position8 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(99 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position8 = true;
                    position8x = 3;
                }

            }

            if (locked23 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position1 = true;
                    position1x = 2;
                }
                else
                if (position2 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position2 = true;
                    position2x = 2;
                }
                else
                if (position3 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position3 = true;
                    position3x = 2;
                }
                else
                if (position4 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position4 = true;
                    position4x = 2;
                }
                else
                if (position5 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position5 = true;
                    position5x = 2;
                }
                else
                if (position6 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position6 = true;
                    position6x = 2;
                }
                else
                if (position7 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position7 = true;
                    position7x = 2;
                }
                else
                if (position8 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(99 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position8 = true;
                    position8x = 2;
                }

            }

            if (locked24 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155);
                    pictureBox8.BringToFront();
                    position1 = true;
                    position1x = 1;
                }
                else
                if (position2 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position2 = true;
                    position2x = 1;
                }
                else
                if (position3 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position3 = true;
                    position3x = 1;
                }
                else
                if (position4 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position4 = true;
                    position4x = 1;
                }
                else
                if (position5 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position5 = true;
                    position5x = 1;
                }
                else
                if (position6 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position6 = true;
                    position6x = 1;
                }
                else
                if (position7 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position7 = true;
                    position7x = 1;
                }
                else
                if (position8 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position8 = true;
                    position8x = 1;
                }

            }
        }

        private void Select2_Click(object sender, EventArgs e)
        {
            select2 = true;
        }


        private void Move2_Click(object sender, EventArgs e)
        {
            bool locked1 = true;
            bool locked2 = true;
            bool locked3 = true;
            bool locked4 = true;
            bool locked5 = true;
            bool locked6 = true;
            bool locked7 = true;
            bool locked8 = true;
            bool locked17 = true;
            bool locked18 = true;
            bool locked19 = true;
            bool locked20 = true; 
            bool locked21 = true;
            bool locked22 = true;
            bool locked23 = true;
            bool locked24 = true;


            if (select1 == true)
            {
                if (pictureBox1.Location.X < 200)
                { locked1 = false; }
                if (pictureBox2.Location.X < 200)
                { locked2 = false; }
                if (pictureBox3.Location.X < 200)
                { locked3 = false; }
                if (pictureBox4.Location.X < 200)
                { locked4 = false; }
                if (pictureBox5.Location.X < 200)
                { locked5 = false; }
                if (pictureBox6.Location.X < 200)
                { locked6 = false; }
                if (pictureBox7.Location.X < 200)
                { locked7 = false; }
                if (pictureBox8.Location.X < 200)
                { locked8 = false; }
            }

            if (select3 == true)
            {
                if (pictureBox1.Location.X > 500)
                { locked17 = false; }
                if (pictureBox2.Location.X > 500)
                { locked18 = false; }
                if (pictureBox3.Location.X > 500)
                { locked19 = false; }
                if (pictureBox4.Location.X > 500)
                { locked20 = false; }
                if (pictureBox5.Location.X > 500)
                { locked21 = false; }
                if (pictureBox6.Location.X > 500)
                { locked22 = false; }
                if (pictureBox7.Location.X > 500)
                { locked23 = false; }
                if (pictureBox8.Location.X > 500)
                { locked24 = false; }
            }

            select1 = false;
            select3 = false;
            select2 = false;





            if (locked1 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position9 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155);
                    pictureBox1.BringToFront();
                    position9 = true;
                    position9x = 8;
                }
                else
                if (position10 == false && position9x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16));
                    pictureBox1.BringToFront();
                    position10 = true;
                    position10x = 8;
                }
                else
                if (position11 == false && position10x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position11 = true;
                    position11x = 8;
                }
                else
                if (position12 == false && position11x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position12 = true;
                    position12x = 8;
                }
                else
                if (position13 == false && position12x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position13 = true;
                    position13x = 8;
                }
                else
                if (position14 == false && position13x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position14 = true;
                    position14x = 8;
                }
                else
                if (position15 == false && position14x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position15 = true;
                    position15x = 8;
                }
                else
                if (position16 == false && position15x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position16 = true;
                    position16x = 8;
                }

            }


            if (locked2 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position9 = true;
                    position9x = 7;
                }
                else
                if (position10 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position10 = true;
                    position10x = 7;
                }
                else
                if (position11 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position11 = true;
                    position11x = 7;
                }
                else
                if (position12 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position12 = true;
                    position12x = 7;
                }
                else
                if (position13 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position13 = true;
                    position13x = 7;
                }
                else
                if (position14 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position14 = true;
                    position14x = 7;
                }
                else
                if (position15 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position15 = true;
                    position15x = 7;
                }
                else
                if (position16 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position16 = true;
                    position16x = 7;
                }

            }

            if (locked3 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position9 = true;
                    position9x = 6;
                }
                else
                if (position10 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position10 = true;
                    position10x = 6;
                }
                else
                if (position11 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position11 = true;
                    position11x = 6;
                }
                else
                if (position12 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position12 = true;
                    position12x = 6;
                }
                else
                if (position13 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position13 = true;
                    position13x = 6;
                }
                else
                if (position14 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position14 = true;
                    position14x = 6;
                }
                else
                if (position15 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position15 = true;
                    position15x = 6;
                }
                else
                if (position16 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position16 = true;
                    position16x = 6;
                }

            }

            if (locked4 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position9 = true;
                    position9x = 5;
                }
                else
                if (position10 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position10 = true;
                    position10x = 5;
                }
                else
                if (position11 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position11 = true;
                    position11x = 5;
                }
                else
                if (position12 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position12 = true;
                    position12x = 5;
                }
                else
                if (position13 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position13 = true;
                    position13x = 5;
                }
                else
                if (position14 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position14 = true;
                    position14x = 5;
                }
                else
                if (position15 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position15 = true;
                    position15x = 5;
                }
                else
                if (position16 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position16 = true;
                    position16x = 5;
                }

            }


            if (locked5 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position9 = true;
                    position9x = 4;
                }
                else
                if (position10 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position10 = true;
                    position10x = 4;
                }
                else
                if (position11 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position11 = true;
                    position11x = 4;
                }
                else
                if (position12 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position12 = true;
                    position12x = 4;
                }
                else
                if (position13 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position13 = true;
                    position13x = 4;
                }
                else
                if (position14 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position14 = true;
                    position14x = 4;
                }
                else
                if (position15 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position15 = true;
                    position15x = 4;
                }
                else
                if (position16 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position16 = true;
                    position16x = 4;
                }

            }


            if (locked6 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position9 = true;
                    position9x = 3;
                }
                else
                if (position10 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position10 = true;
                    position10x = 3;
                }
                else
                if (position11 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position11 = true;
                    position11x = 3;
                }
                else
                if (position12 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position12 = true;
                    position12x = 3;
                }
                else
                if (position13 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position13 = true;
                    position13x = 3;
                }
                else
                if (position14 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position14 = true;
                    position14x = 3;
                }
                else
                if (position15 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position15 = true;
                    position15x = 3;
                }
                else
                if (position16 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position16 = true;
                    position16x = 3;
                }

            }

            if (locked7 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position9 = true;
                    position9x = 2;
                }
                else
                if (position10 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position10 = true;
                    position10x = 2;
                }
                else
                if (position11 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position11 = true;
                    position11x = 2;
                }
                else
                if (position12 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position12 = true;
                    position12x = 2;
                }
                else
                if (position13 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position13 = true;
                    position13x = 2;
                }
                else
                if (position14 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position14 = true;
                    position14x = 2;
                }
                else
                if (position15 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position15 = true;
                    position15x = 2;
                }
                else
                if (position16 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position16 = true;
                    position16x = 2;
                }

            }

            if (locked8 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155);
                    pictureBox8.BringToFront();
                    position9 = true;
                    position9x = 1;
                }
                else
                if (position10 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position10 = true;
                    position10x = 1;
                }
                else
                if (position11 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position11 = true;
                    position11x = 1;
                }
                else
                if (position12 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position12 = true;
                    position12x = 1;
                }
                else
                if (position13 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position13 = true;
                    position13x = 1;
                }
                else
                if (position14 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position14 = true;
                    position14x = 1;
                }
                else
                if (position15 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position15 = true;
                    position15x = 1;
                }
                else
                if (position16 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position16 = true;
                    position16x = 1;
                }

            }


            if (locked17 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position9 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155);
                    pictureBox1.BringToFront();
                    position9 = true;
                    position9x = 8;
                }
                else
                if (position10 == false && position9x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16));
                    pictureBox1.BringToFront();
                    position10 = true;
                    position10x = 8;
                }
                else
                if (position11 == false && position10x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position11 = true;
                    position11x = 8;
                }
                else
                if (position12 == false && position11x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position12 = true;
                    position12x = 8;
                }
                else
                if (position13 == false && position12x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position13 = true;
                    position13x = 8;
                }
                else
                if (position14 == false && position13x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position14 = true;
                    position14x = 8;
                }
                else
                if (position15 == false && position14x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position15 = true;
                    position15x = 8;
                }
                else
                if (position16 == false && position15x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox1.Location = new Point(372, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position16 = true;
                    position16x = 8;
                }

            }


            if (locked18 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position9 = true;
                    position9x = 7;
                }
                else
                if (position10 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position10 = true;
                    position10x = 7;
                }
                else
                if (position11 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position11 = true;
                    position11x = 7;
                }
                else
                if (position12 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position12 = true;
                    position12x = 7;
                }
                else
                if (position13 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position13 = true;
                    position13x = 7;
                }
                else
                if (position14 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position14 = true;
                    position14x = 7;
                }
                else
                if (position15 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    { position21 = false; }
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position15 = true;
                    position15x = 7;
                }
                else
                if (position16 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox2.Location = new Point(372 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position16 = true;
                    position16x = 7;
                }

            }

            if (locked19 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position9 = true;
                    position9x = 6;
                }
                else
                if (position10 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position10 = true;
                    position10x = 6;
                }
                else
                if (position11 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position11 = true;
                    position11x = 6;
                }
                else
                if (position12 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position12 = true;
                    position12x = 6;
                }
                else
                if (position13 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position13 = true;
                    position13x = 6;
                }
                else
                if (position14 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position14 = true;
                    position14x = 6;
                }
                else
                if (position15 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position15 = true;
                    position15x = 6;
                }
                else
                if (position16 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox3.Location = new Point(372 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position16 = true;
                    position16x = 6;
                }

            }

            if (locked20 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position9 = true;
                    position9x = 5;
                }
                else
                if (position10 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position10 = true;
                    position10x = 5;
                }
                else
                if (position11 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position11 = true;
                    position11x = 5;
                }
                else
                if (position12 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position12 = true;
                    position12x = 5;
                }
                else
                if (position13 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position13 = true;
                    position13x = 5;
                }
                else
                if (position14 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position14 = true;
                    position14x = 5;
                }
                else
                if (position15 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position15 = true;
                    position15x = 5;
                }
                else
                if (position16 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox4.Location = new Point(372 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position16 = true;
                    position16x = 5;
                }

            }


            if (locked21 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position9 = true;
                    position9x = 4;
                }
                else
                if (position10 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position10 = true;
                    position10x = 4;
                }
                else
                if (position11 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position11 = true;
                    position11x = 4;
                }
                else
                if (position12 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position12 = true;
                    position12x = 4;
                }
                else
                if (position13 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position13 = true;
                    position13x = 4;
                }
                else
                if (position14 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position14 = true;
                    position14x = 4;
                }
                else
                if (position15 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position15 = true;
                    position15x = 4;
                }
                else
                if (position16 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox5.Location = new Point(372 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position16 = true;
                    position16x = 4;
                }

            }


            if (locked22 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position9 = true;
                    position9x = 3;
                }
                else
                if (position10 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position10 = true;
                    position10x = 3;
                }
                else
                if (position11 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position11 = true;
                    position11x = 3;
                }
                else
                if (position12 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position12 = true;
                    position12x = 3;
                }
                else
                if (position13 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position13 = true;
                    position13x = 3;
                }
                else
                if (position14 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position14 = true;
                    position14x = 3;
                }
                else
                if (position15 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position15 = true;
                    position15x = 3;
                }
                else
                if (position16 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox6.Location = new Point(372 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position16 = true;
                    position16x = 3;
                }

            }

            if (locked23 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position9 = true;
                    position9x = 2;
                }
                else
                if (position10 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position10 = true;
                    position10x = 2;
                }
                else
                if (position11 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position11 = true;
                    position11x = 2;
                }
                else
                if (position12 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position12 = true;
                    position12x = 2;
                }
                else
                if (position13 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position13 = true;
                    position13x = 2;
                }
                else
                if (position14 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position14 = true;
                    position14x = 2;
                }
                else
                if (position15 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position15 = true;
                    position15x = 2;
                }
                else
                if (position16 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox7.Location = new Point(372 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position16 = true;
                    position16x = 2;
                }

            }

            if (locked24 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155);
                    pictureBox8.BringToFront();
                    position9 = true;
                    position9x = 1;
                }
                else
                if (position10 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position10 = true;
                    position10x = 1;
                }
                else
                if (position11 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position11 = true;
                    position11x = 1;
                }
                else
                if (position12 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position12 = true;
                    position12x = 1;
                }
                else
                if (position13 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position13 = true;
                    position13x = 1;
                }
                else
                if (position14 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position14 = true;
                    position14x = 1;
                }
                else
                if (position15 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position15 = true;
                    position15x = 1;
                }
                else
                if (position16 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position17 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position18 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position19 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position20 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position21 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position22 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position23 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position24 = false; }
                    pictureBox8.Location = new Point(372 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position16 = true;
                    position16x = 1;
                }

            }






        }

        private void Select3_Click(object sender, EventArgs e)
        {
            select3 = true;
        }

        private void Move3_Click(object sender, EventArgs e)
        {
            bool locked1 = true;
            bool locked2 = true;
            bool locked3 = true;
            bool locked4 = true;
            bool locked5 = true;
            bool locked6 = true;
            bool locked7 = true;
            bool locked8 = true;
            bool locked9 = true;
            bool locked10 = true;
            bool locked11 = true;
            bool locked12 = true;
            bool locked13 = true;
            bool locked14 = true;
            bool locked15 = true;
            bool locked16 = true;


            if (select2 == true)
            {
                if (pictureBox1.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked9 = false; }
                if (pictureBox2.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked10 = false; }
                if (pictureBox3.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked11 = false; }
                if (pictureBox4.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked12 = false; }
                if (pictureBox5.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked13 = false; }
                if (pictureBox6.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked14 = false; }
                if (pictureBox7.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked15 = false; }
                if (pictureBox8.Location.X > 200 && pictureBox1.Location.X < 500)
                { locked16 = false; }
            }

            if (select1 == true)
            {
                if (pictureBox1.Location.X < 200)
                { locked1 = false; }
                if (pictureBox2.Location.X < 200)
                { locked2 = false; }
                if (pictureBox3.Location.X < 200)
                { locked3 = false; }
                if (pictureBox4.Location.X < 200)
                { locked4 = false; }
                if (pictureBox5.Location.X < 200)
                { locked5 = false; }
                if (pictureBox6.Location.X < 200)
                { locked6 = false; }
                if (pictureBox7.Location.X < 200)
                { locked7 = false; }
                if (pictureBox8.Location.X < 200)
                { locked8 = false; }
            }

            select1 = false;
            select3 = false;
            select2 = false;




            if (locked1 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position9 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155);
                    pictureBox1.BringToFront();
                    position9 = true;
                    position9x = 8;
                }
                else
                if (position10 == false && position9x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16));
                    pictureBox1.BringToFront();
                    position10 = true;
                    position10x = 8;
                }
                else
                if (position11 == false && position10x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position11 = true;
                    position11x = 8;
                }
                else
                if (position12 == false && position11x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position12 = true;
                    position12x = 8;
                }
                else
                if (position13 == false && position12x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position13 = true;
                    position13x = 8;
                }
                else
                if (position14 == false && position13x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position14 = true;
                    position14x = 8;
                }
                else
                if (position15 == false && position14x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position15 = true;
                    position15x = 8;
                }
                else
                if (position16 == false && position15x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position16 = true;
                    position16x = 8;
                }

            }


            if (locked2 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position9 = true;
                    position9x = 7;
                }
                else
                if (position10 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position10 = true;
                    position10x = 7;
                }
                else
                if (position11 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position11 = true;
                    position11x = 7;
                }
                else
                if (position12 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position12 = true;
                    position12x = 7;
                }
                else
                if (position13 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position13 = true;
                    position13x = 7;
                }
                else
                if (position14 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position14 = true;
                    position14x = 7;
                }
                else
                if (position15 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position15 = true;
                    position15x = 7;
                }
                else
                if (position16 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position16 = true;
                    position16x = 7;
                }

            }

            if (locked3 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position9 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position9 = true;
                    position9x = 6;
                }
                else
                if (position10 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position10 = true;
                    position10x = 6;
                }
                else
                if (position11 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position11 = true;
                    position11x = 6;
                }
                else
                if (position12 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position12 = true;
                    position12x = 6;
                }
                else
                if (position13 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position13 = true;
                    position13x = 6;
                }
                else
                if (position14 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position14 = true;
                    position14x = 6;
                }
                else
                if (position15 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position15 = true;
                    position15x = 6;
                }
                else
                if (position16 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position16 = true;
                    position16x = 6;
                }

            }

            if (locked4 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position9 = true;
                    position9x = 5;
                }
                else
                if (position10 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position10 = true;
                    position10x = 5;
                }
                else
                if (position11 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position11 = true;
                    position11x = 5;
                }
                else
                if (position12 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position12 = true;
                    position12x = 5;
                }
                else
                if (position13 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position13 = true;
                    position13x = 5;
                }
                else
                if (position14 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position14 = true;
                    position14x = 5;
                }
                else
                if (position15 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position15 = true;
                    position15x = 5;
                }
                else
                if (position16 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position16 = true;
                    position16x = 5;
                }

            }


            if (locked5 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position9 = true;
                    position9x = 4;
                }
                else
                if (position10 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position10 = true;
                    position10x = 4;
                }
                else
                if (position11 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position11 = true;
                    position11x = 4;
                }
                else
                if (position12 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position12 = true;
                    position12x = 4;
                }
                else
                if (position13 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position13 = true;
                    position13x = 4;
                }
                else
                if (position14 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position14 = true;
                    position14x = 4;
                }
                else
                if (position15 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position15 = true;
                    position15x = 4;
                }
                else
                if (position16 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position16 = true;
                    position16x = 4;
                }

            }


            if (locked6 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position9 = true;
                    position9x = 3;
                }
                else
                if (position10 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position10 = true;
                    position10x = 3;
                }
                else
                if (position11 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position11 = true;
                    position11x = 3;
                }
                else
                if (position12 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position12 = true;
                    position12x = 3;
                }
                else
                if (position13 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position13 = true;
                    position13x = 3;
                }
                else
                if (position14 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position14 = true;
                    position14x = 3;
                }
                else
                if (position15 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position15 = true;
                    position15x = 3;
                }
                else
                if (position16 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position16 = true;
                    position16x = 3;
                }

            }

            if (locked7 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position9 = true;
                    position9x = 2;
                }
                else
                if (position10 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position10 = true;
                    position10x = 2;
                }
                else
                if (position11 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position11 = true;
                    position11x = 2;
                }
                else
                if (position12 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position12 = true;
                    position12x = 2;
                }
                else
                if (position13 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position13 = true;
                    position13x = 2;
                }
                else
                if (position14 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position14 = true;
                    position14x = 2;
                }
                else
                if (position15 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position15 = true;
                    position15x = 2;
                }
                else
                if (position16 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position16 = true;
                    position16x = 2;
                }

            }

            if (locked8 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position9 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155);
                    pictureBox8.BringToFront();
                    position9 = true;
                    position9x = 1;
                }
                else
                if (position10 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position10 = true;
                    position10x = 1;
                }
                else
                if (position11 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position11 = true;
                    position11x = 1;
                }
                else
                if (position12 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position12 = true;
                    position12x = 1;
                }
                else
                if (position13 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position13 = true;
                    position13x = 1;
                }
                else
                if (position14 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position14 = true;
                    position14x = 1;
                }
                else
                if (position15 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position15 = true;
                    position15x = 1;
                }
                else
                if (position16 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position1 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position2 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position3 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position4 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position5 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position6 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position7 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position8 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position16 = true;
                    position16x = 1;


                }

            }



            if (locked9 == false && pictureBox1.Location.Y < pictureBox2.Location.Y && pictureBox1.Location.Y < pictureBox3.Location.Y && pictureBox1.Location.Y < pictureBox4.Location.Y && pictureBox1.Location.Y < pictureBox5.Location.Y && pictureBox1.Location.Y < pictureBox6.Location.Y && pictureBox1.Location.Y < pictureBox7.Location.Y && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {





                if (position1 == false)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155);
                    pictureBox1.BringToFront();
                    position1 = true;
                    position1x = 8;
                }
                else
                if (position2 == false && position1x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16));
                    pictureBox1.BringToFront();
                    position2 = true;
                    position2x = 8;
                }
                else
                if (position3 == false && position2x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 2));
                    pictureBox1.BringToFront();
                    position3 = true;
                    position3x = 8;
                }
                else
                if (position4 == false && position3x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 3));
                    pictureBox1.BringToFront();
                    position4 = true;
                    position4x = 8;
                }
                else
                if (position5 == false && position4x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 4));
                    pictureBox1.BringToFront();
                    position5 = true;
                    position5x = 8;
                }
                else
                if (position6 == false && position5x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 5));
                    pictureBox1.BringToFront();
                    position6 = true;
                    position6x = 8;
                }
                else
                if (position7 == false && position6x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 6));
                    pictureBox1.BringToFront();
                    position7 = true;
                    position7x = 8;
                }
                else
                if (position8 == false && position7x >= 8)
                {
                    if (pictureBox1.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox1.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox1.Location = new Point(646, 155 + (16 * 7));
                    pictureBox1.BringToFront();
                    position8 = true;
                    position8x = 8;
                }

            }


            if (locked10 == false && pictureBox2.Location.Y < pictureBox1.Location.Y && pictureBox2.Location.Y < pictureBox3.Location.Y && pictureBox2.Location.Y < pictureBox4.Location.Y && pictureBox2.Location.Y < pictureBox5.Location.Y && pictureBox2.Location.Y < pictureBox6.Location.Y && pictureBox2.Location.Y < pictureBox7.Location.Y && pictureBox2.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155);
                    pictureBox2.BringToFront();
                    position1 = true;
                    position1x = 7;
                }
                else
                if (position2 == false && position9x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16));
                    pictureBox2.BringToFront();
                    position2 = true;
                    position2x = 7;
                }
                else
                if (position3 == false && position10x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 2));
                    pictureBox2.BringToFront();
                    position3 = true;
                    position3x = 7;
                }
                else
                if (position4 == false && position11x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 3));
                    pictureBox2.BringToFront();
                    position4 = true;
                    position4x = 7;
                }
                else
                if (position5 == false && position12x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 4));
                    pictureBox2.BringToFront();
                    position5 = true;
                    position5x = 7;
                }
                else
                if (position6 == false && position13x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 5));
                    pictureBox2.BringToFront();
                    position6 = true;
                    position6x = 7;
                }
                else
                if (position7 == false && position14x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 6));
                    pictureBox2.BringToFront();
                    position7 = true;
                    position7x = 7;
                }
                else
                if (position8 == false && position15x >= 7)
                {
                    if (pictureBox2.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox2.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox2.Location = new Point(646 + (32 - 29), 155 + (16 * 7));
                    pictureBox2.BringToFront();
                    position8 = true;
                    position8x = 7;
                }

            }

            if (locked11 == false && pictureBox3.Location.Y < pictureBox1.Location.Y && pictureBox3.Location.Y < pictureBox2.Location.Y && pictureBox3.Location.Y < pictureBox4.Location.Y && pictureBox3.Location.Y < pictureBox5.Location.Y && pictureBox3.Location.Y < pictureBox6.Location.Y && pictureBox3.Location.Y < pictureBox7.Location.Y && pictureBox3.Location.Y < pictureBox8.Location.Y)
            {

                if (position1 == false)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155);
                    pictureBox3.BringToFront();
                    position1 = true;
                    position1x = 6;
                }
                else
                if (position2 == false && position9x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16));
                    pictureBox3.BringToFront();
                    position2 = true;
                    position2x = 6;
                }
                else
                if (position3 == false && position10x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 2));
                    pictureBox3.BringToFront();
                    position3 = true;
                    position3x = 6;
                }
                else
                if (position4 == false && position11x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 3));
                    pictureBox3.BringToFront();
                    position4 = true;
                    position4x = 6;
                }
                else
                if (position5 == false && position12x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 4));
                    pictureBox3.BringToFront();
                    position5 = true;
                    position5x = 6;
                }
                else
                if (position6 == false && position13x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 5));
                    pictureBox3.BringToFront();
                    position6 = true;
                    position6x = 6;
                }
                else
                if (position7 == false && position14x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 6));
                    pictureBox3.BringToFront();
                    position7 = true;
                    position7x = 6;
                }
                else
                if (position8 == false && position15x >= 6)
                {
                    if (pictureBox3.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox3.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox3.Location = new Point(646 + (32 - 25), 155 + (16 * 7));
                    pictureBox3.BringToFront();
                    position8 = true;
                    position8x = 6;
                }

            }

            if (locked12 == false && pictureBox4.Location.Y < pictureBox1.Location.Y && pictureBox4.Location.Y < pictureBox2.Location.Y && pictureBox4.Location.Y < pictureBox3.Location.Y && pictureBox4.Location.Y < pictureBox5.Location.Y && pictureBox4.Location.Y < pictureBox6.Location.Y && pictureBox4.Location.Y < pictureBox7.Location.Y && pictureBox4.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155);
                    pictureBox4.BringToFront();
                    position1 = true;
                    position1x = 5;
                }
                else
                if (position2 == false && position9x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16));
                    pictureBox4.BringToFront();
                    position2 = true;
                    position2x = 5;
                }
                else
                if (position3 == false && position10x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 2));
                    pictureBox4.BringToFront();
                    position3 = true;
                    position3x = 5;
                }
                else
                if (position4 == false && position11x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 3));
                    pictureBox4.BringToFront();
                    position4 = true;
                    position4x = 5;
                }
                else
                if (position5 == false && position12x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 4));
                    pictureBox4.BringToFront();
                    position5 = true;
                    position5x = 5;
                }
                else
                if (position6 == false && position13x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 5));
                    pictureBox4.BringToFront();
                    position6 = true;
                    position6x = 5;
                }
                else
                if (position7 == false && position14x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 6));
                    pictureBox4.BringToFront();
                    position7 = true;
                    position7x = 5;
                }
                else
                if (position8 == false && position15x >= 5)
                {
                    if (pictureBox4.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox4.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox4.Location = new Point(646 + (32 - 20), 155 + (16 * 7));
                    pictureBox4.BringToFront();
                    position8 = true;
                    position8x = 5;
                }

            }


            if (locked13 == false && pictureBox5.Location.Y < pictureBox1.Location.Y && pictureBox5.Location.Y < pictureBox2.Location.Y && pictureBox5.Location.Y < pictureBox3.Location.Y && pictureBox5.Location.Y < pictureBox4.Location.Y && pictureBox5.Location.Y < pictureBox6.Location.Y && pictureBox5.Location.Y < pictureBox7.Location.Y && pictureBox5.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155);
                    pictureBox5.BringToFront();
                    position1 = true;
                    position1x = 4;
                }
                else
                if (position2 == false && position9x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16));
                    pictureBox5.BringToFront();
                    position2 = true;
                    position2x = 4;
                }
                else
                if (position3 == false && position10x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 2));
                    pictureBox5.BringToFront();
                    position3 = true;
                    position3x = 4;
                }
                else
                if (position4 == false && position11x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 3));
                    pictureBox5.BringToFront();
                    position4 = true;
                    position4x = 4;
                }
                else
                if (position5 == false && position12x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 4));
                    pictureBox5.BringToFront();
                    position5 = true;
                    position5x = 4;
                }
                else
                if (position6 == false && position13x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 5));
                    pictureBox5.BringToFront();
                    position6 = true;
                    position6x = 4;
                }
                else
                if (position7 == false && position14x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 6));
                    pictureBox5.BringToFront();
                    position7 = true;
                    position7x = 4;
                }
                else
                if (position8 == false && position15x >= 4)
                {
                    if (pictureBox5.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox5.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox5.Location = new Point(646 + (32 - 15), 155 + (16 * 7));
                    pictureBox5.BringToFront();
                    position8 = true;
                    position8x = 4;
                }

            }


            if (locked14 == false && pictureBox6.Location.Y < pictureBox1.Location.Y && pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y < pictureBox3.Location.Y && pictureBox6.Location.Y < pictureBox4.Location.Y && pictureBox6.Location.Y < pictureBox5.Location.Y && pictureBox6.Location.Y < pictureBox7.Location.Y && pictureBox6.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155);
                    pictureBox6.BringToFront();
                    position1 = true;
                    position1x = 3;
                }
                else
                if (position2 == false && position9x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16));
                    pictureBox6.BringToFront();
                    position2 = true;
                    position2x = 3;
                }
                else
                if (position3 == false && position10x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 2));
                    pictureBox6.BringToFront();
                    position3 = true;
                    position3x = 3;
                }
                else
                if (position4 == false && position11x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 3));
                    pictureBox6.BringToFront();
                    position4 = true;
                    position4x = 3;
                }
                else
                if (position5 == false && position12x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 4));
                    pictureBox6.BringToFront();
                    position5 = true;
                    position5x = 3;
                }
                else
                if (position6 == false && position13x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }       else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 5));
                    pictureBox6.BringToFront();
                    position6 = true;
                    position6x = 3;
                }
                else
                if (position7 == false && position14x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 6));
                    pictureBox6.BringToFront();
                    position7 = true;
                    position7x = 3;
                }
                else
                if (position8 == false && position15x >= 3)
                {
                    if (pictureBox6.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox6.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox6.Location = new Point(646 + (32 - 10), 155 + (16 * 7));
                    pictureBox6.BringToFront();
                    position8 = true;
                    position8x = 3;
                }

            }

            if (locked15 == false && pictureBox7.Location.Y < pictureBox1.Location.Y && pictureBox7.Location.Y < pictureBox2.Location.Y && pictureBox7.Location.Y < pictureBox3.Location.Y && pictureBox7.Location.Y < pictureBox4.Location.Y && pictureBox7.Location.Y < pictureBox5.Location.Y && pictureBox7.Location.Y < pictureBox6.Location.Y && pictureBox7.Location.Y < pictureBox8.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155);
                    pictureBox7.BringToFront();
                    position1 = true;
                    position1x = 2;
                }
                else
                if (position2 == false && position9x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16));
                    pictureBox7.BringToFront();
                    position2 = true;
                    position2x = 2;
                }
                else
                if (position3 == false && position10x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 2));
                    pictureBox7.BringToFront();
                    position3 = true;
                    position3x = 2;
                }
                else
                if (position4 == false && position11x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 3));
                    pictureBox7.BringToFront();
                    position4 = true;
                    position4x = 2;
                }
                else
                if (position5 == false && position12x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 4));
                    pictureBox7.BringToFront();
                    position5 = true;
                    position5x = 2;
                }
                else
                if (position6 == false && position13x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 5));
                    pictureBox7.BringToFront();
                    position6 = true;
                    position6x = 2;
                }
                else
                if (position7 == false && position14x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 6));
                    pictureBox7.BringToFront();
                    position7 = true;
                    position7x = 2;
                }
                else
                if (position8 == false && position15x >= 2)
                {
                    if (pictureBox7.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox7.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox7.Location = new Point(646 + (32 - 5), 155 + (16 * 7));
                    pictureBox7.BringToFront();
                    position8 = true;
                    position8x = 2;
                }

            }

            if (locked16 == false && pictureBox8.Location.Y < pictureBox1.Location.Y && pictureBox8.Location.Y < pictureBox2.Location.Y && pictureBox8.Location.Y < pictureBox3.Location.Y && pictureBox8.Location.Y < pictureBox4.Location.Y && pictureBox8.Location.Y < pictureBox5.Location.Y && pictureBox8.Location.Y < pictureBox6.Location.Y && pictureBox8.Location.Y < pictureBox7.Location.Y)
            {
                if (position1 == false)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155);
                    pictureBox8.BringToFront();
                    position1 = true;
                    position1x = 1;
                }
                else
                if (position2 == false && position9x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16));
                    pictureBox8.BringToFront();
                    position2 = true;
                    position2x = 1;
                }
                else
                if (position3 == false && position10x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 2));
                    pictureBox8.BringToFront();
                    position3 = true;
                    position3x = 1;
                }
                else
                if (position4 == false && position11x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 3));
                    pictureBox8.BringToFront();
                    position4 = true;
                    position4x = 1;
                }
                else
                if (position5 == false && position12x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 4));
                    pictureBox8.BringToFront();
                    position5 = true;
                    position5x = 1;
                }
                else
                if (position6 == false && position13x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 5));
                    pictureBox8.BringToFront();
                    position6 = true;
                    position6x = 1;
                }
                else
                if (position7 == false && position14x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(646 + 32, 155 + (16 * 6));
                    pictureBox8.BringToFront();
                    position7 = true;
                    position7x = 1;
                }
                else
                if (position8 == false && position15x >= 1)
                {
                    if (pictureBox8.Location.Y == 155)
                    { position9 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16))
                    { position10 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 2))
                    { position11 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 3))
                    { position12 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 4))
                    { position13 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 5))
                    { position14 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 6))
                    { position15 = false; }
                    else
                    if (pictureBox8.Location.Y == 155 + (16 * 7))
                    { position16 = false; }
                    pictureBox8.Location = new Point(99 + 32, 155 + (16 * 7));
                    pictureBox8.BringToFront();
                    position8 = true;
                    position8x = 1;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
