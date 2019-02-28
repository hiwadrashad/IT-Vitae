using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox6.Visible = false;
        }

        Image image1 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice1.png"));
        Image image2 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice2.png"));
        Image image3 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice3.png"));
        Image image4 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice4.png"));
        Image image5 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice5.png"));
        Image image6 = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Yahtzee\Nieuwe map\Dice6.png"));
        int player = 1;
        bool allowed = false;
        int upper1 = 0;
        int lower1 = 0;
        int upper2 = 0;
        int lower2 = 0;
        int upper3 = 0;
        int lower3 = 0;
        int total1 = 0;
        int total2 = 0;
        int total3 = 0;
        bool box1 = true;
        bool box2 = true;
        bool box3 = true;
        bool box4 = true;
        bool box5 = true;
        bool box6 = true;
        bool box8 = true;
        bool box9 = true;
        bool box10 = true;
        bool box11 = true;
        bool box12 = true;
        bool box13 = true;
        bool box14 = true;
        bool box15 = true;
        bool box18 = true;
        bool box19 = true;
        bool box20 = true;
        bool box21 = true;
        bool box22 = true;
        bool box23 = true;
        bool box25 = true;
        bool box26 = true;
        bool box27 = true;
        bool box28 = true;
        bool box29 = true;
        bool box30 = true;
        bool box31 = true;
        bool box32 = true;
        bool box35 = true;
        bool box36 = true;
        bool box37 = true;
        bool box38 = true;
        bool box39 = true;
        bool box40 = true;
        bool box42 = true;
        bool box43 = true;
        bool box44 = true;
        bool box45 = true;
        bool box46 = true;
        bool box47 = true;
        bool box48 = true;
        bool box49 = true;
        bool yahtzee = false;








        private void button1_Click(object sender, EventArgs e)
        {
            allowed = true;
            List<Image> images = new List<Image>();
            images.Add(image1);
            images.Add(image2);
            images.Add(image3);
            images.Add(image4);
            images.Add(image5);
            images.Add(image6);


            Random rand = new Random();
            pictureBox1.Image = images[rand.Next(0, images.Count)];
            pictureBox2.Image = images[rand.Next(0, images.Count)];
            pictureBox3.Image = images[rand.Next(0, images.Count)];
            pictureBox4.Image = images[rand.Next(0, images.Count)];
            pictureBox5.Image = images[rand.Next(0, images.Count)];
            pictureBox6.Image = images[rand.Next(0, images.Count)];

            if (textBox1.Text != "" && box1 == true)
            {
                upper1 = upper1 + int.Parse(textBox1.Text);
                box1 = false;
            }
            if (textBox2.Text != "" && box2 == true)
            {
                upper1 = upper1 + int.Parse(textBox2.Text);
                box2 = false;
            }
            if (textBox3.Text != "" && box3 == true)
            {
                upper1 = upper1 + int.Parse(textBox3.Text);
                box3 = false;
            }
            if (textBox4.Text != "" && box4 == true)
            {
                upper1 = upper1 + int.Parse(textBox4.Text);
                box4 = false;
            }
            if (textBox5.Text != "" && box5 == true)
            {
                upper1 = upper1 + int.Parse(textBox5.Text);
                box5 = false;
            }
            if (textBox6.Text != "" && box6 == true)
            {
                upper1 = upper1 + int.Parse(textBox6.Text);
                box6 = false;
            }
            textBox7.Text = upper1.ToString();

            if (textBox8.Text != "" && box8 == true)
            {
                lower1 = lower1 + int.Parse(textBox8.Text);
                box8 = false;
            }
            if (textBox9.Text != "" && box9 == true)
            {
                lower1 = lower1 + int.Parse(textBox9.Text);
                box9 = false;
            }
            if (textBox10.Text != "" && box10 == true)
            {
                lower1 = lower1 + int.Parse(textBox10.Text);
                box10 = false;
            }
            if (textBox13.Text != "" && box13 == true)
            {
                lower1 = lower1 + int.Parse(textBox13.Text);
                box13 = false;
            }
            if (textBox14.Text != "" && box14 == true)
            {
                lower1 = lower1 + int.Parse(textBox14.Text);
                box14 = false;
            }
            if (textBox15.Text != "" && box15 == true)
            {
                lower1 = lower1 + int.Parse(textBox15.Text);
                box15 = false;
            }
            textBox16.Text = lower1.ToString();
            textBox17.Text = (lower1 + upper1).ToString();


            if (textBox18.Text != "" && box18 == true)
            {
                upper2 = upper2 + int.Parse(textBox18.Text);
                box18 = false;
            }
            if (textBox19.Text != "" && box19 == true)
            {
                upper2 = upper2 + int.Parse(textBox19.Text);
                box19 = false;
            }
            if (textBox20.Text != "" && box20 == true)
            {
                upper2 = upper2 + int.Parse(textBox20.Text);
                box20 = false;
            }
            if (textBox21.Text != "" && box21 == true)
            {
                upper2 = upper2 + int.Parse(textBox21.Text);
                box21 = false;
            }
            if (textBox22.Text != "" && box22 == true)
            {
                upper2 = upper2 + int.Parse(textBox22.Text);
                box22 = false;
            }
            if (textBox23.Text != "" && box23 == true)
            {
                upper2 = upper2 + int.Parse(textBox23.Text);
                box23 = false;
            }
            textBox24.Text = upper2.ToString();

            if (textBox25.Text != "" && box25 == true)
            {
                lower2 = lower2 + int.Parse(textBox25.Text);
                box25 = false;
            }
            if (textBox26.Text != "" && box26 == true)
            {
                lower2 = lower2 + int.Parse(textBox26.Text);
                box26 = false;
            }
            if (textBox27.Text != "" && box27 == true)
            {
                lower2 = lower2 + int.Parse(textBox27.Text);
                box27 = false;
            }
            if (textBox30.Text != "" && box30 == true)
            {
                lower2 = lower2 + int.Parse(textBox30.Text);
                box30 = false;
            }
            if (textBox31.Text != "" && box31 == true)
            {
                lower2 = lower2 + int.Parse(textBox31.Text);
                box31 = false;
            }
            if (textBox32.Text != "" && box32 == true)
            {
                lower2 = lower2 + int.Parse(textBox32.Text);
                box32 = false;
            }
            textBox33.Text = lower2.ToString();
            textBox34.Text = (lower2 + upper2).ToString();

            if (textBox35.Text != "" && box35 == true)
            {
                upper3 = upper3 + int.Parse(textBox35.Text);
                box35 = false;
            }
            if (textBox36.Text != "" && box36 == true)
            {
                upper3 = upper3 + int.Parse(textBox36.Text);
                box36 = false;
            }
            if (textBox37.Text != "" && box37 == true)
            {
                upper3 = upper3 + int.Parse(textBox37.Text);
                box37 = false;
            }
            if (textBox38.Text != "" && box38 == true)
            {
                upper3 = upper3 + int.Parse(textBox38.Text);
                box38 = false;
            }
            if (textBox39.Text != "" && box39 == true)
            {
                upper3 = upper3 + int.Parse(textBox39.Text);
                box39 = false;
            }
            if (textBox40.Text != "" && box40 == true)
            {
                upper3 = upper3 + int.Parse(textBox40.Text);
                box40 = false;
            }
            textBox41.Text = upper1.ToString();

            if (textBox42.Text != "" && box42 == true)
            {
                lower3 = lower3 + int.Parse(textBox42.Text);
                box42 = false;
            }
            if (textBox43.Text != "" && box43 == true)
            {
                lower3 = lower3 + int.Parse(textBox43.Text);
                box43 = false;
            }
            if (textBox44.Text != "" && box44 == true)
            {
                lower3 = lower3 + int.Parse(textBox44.Text);
                box44 = false;
            }
            if (textBox47.Text != "" && box47 == true)
            {
                lower3 = lower3 + int.Parse(textBox47.Text);
                box47 = false;
            }
            if (textBox48.Text != "" && box48 == true)
            {
                lower3 = lower3 + int.Parse(textBox48.Text);
                box48 = false;
            }
            if (textBox49.Text != "" && box49 == true)
            {
                lower3 = lower3 + int.Parse(textBox49.Text);
                box49 = false;
            }
            textBox50.Text = lower3.ToString();
            textBox51.Text = (lower3 + upper3).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (allowed == true)
            {
                int i = 0;
                if (pictureBox1.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i = i + 1;
                }
                if (player == 1 && textBox1.Text == "")
                {
                    textBox1.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox18.Text == "")
                {
                    textBox18.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox35.Text == "")
                {
                    textBox35.Text = Convert.ToString(i);
                }
                allowed = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = player + 1;
            allowed = true;
            yahtzee = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;

                if (pictureBox1.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox2.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox3.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox4.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox5.Image == image2)
                {
                    i = i + 2;
                }
                if (player == 1 && textBox2.Text == "")
                {
                    textBox2.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox19.Text == "")
                {
                    textBox19.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox36.Text == "")
                {
                    textBox36.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;
                if (pictureBox1.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox2.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox3.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox4.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox5.Image == image3)
                {
                    i = i + 3;
                }
                if (player == 1 && textBox3.Text == "")
                {
                    textBox3.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox20.Text == "")
                {
                    textBox20.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox37.Text == "")
                {
                    textBox37.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;
                if (pictureBox1.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox2.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox3.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox4.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox5.Image == image4)
                {
                    i = i + 4;
                }
                if (player == 1 && textBox4.Text == "")
                {
                    textBox4.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox21.Text == "")
                {
                    textBox21.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox38.Text == "")
                {
                    textBox38.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;
                if (pictureBox1.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox2.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox3.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox4.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox5.Image == image5)
                {
                    i = i + 5;
                }
                if (player == 1 && textBox5.Text == "")
                {
                    textBox5.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox22.Text == "")
                {
                    textBox22.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox39.Text == "")
                {
                    textBox39.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;
                if (pictureBox1.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox2.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox3.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox4.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox5.Image == image6)
                {
                    i = i + 6;
                }
                if (player == 1 && textBox6.Text == "")
                {
                    textBox6.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox23.Text == "")
                {
                    textBox23.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox40.Text == "")
                {
                    textBox40.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            { textBox.Text = ""; }
            upper1 = 0;
            lower1 = 0;
            upper2 = 0;
            lower2 = 0;
            upper3 = 0;
            lower3 = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int amount1 = 0;
                int amount2 = 0;
                int amount3 = 0;
                int amount4 = 0;
                int amount5 = 0;
                int amount6 = 0;
                int i = 0;
                int i1 = 0;
                int i2 = 0;
                int i3 = 0;
                int i4 = 0;
                int i5 = 0;
                int i6 = 0;

                if (pictureBox1.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }

                if (pictureBox1.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox2.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox3.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox4.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox5.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }

                if (pictureBox1.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox2.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox3.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox4.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox5.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }

                if (pictureBox1.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox2.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox3.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox4.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox5.Image == image4)
                {
                    i4 = i4 + 4;
                    amount5 = amount5 + 1;
                }

                if (pictureBox1.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox2.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox3.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox4.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox5.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }


                if (pictureBox1.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox2.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox3.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox4.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox5.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }

                if (amount6 >= 3)
                { i = i6; }
                else
                if (amount5 >= 3)
                { i = i5; }
                else
                if (amount4 >= 3)
                { i = i4; }
                else
                if (amount3 >= 3)
                { i = i3; }
                else
                if (amount2 >= 3)
                { i = i2; }
                else
                if (amount1 >= 3)
                { i = i1; }
                else
                { i = 0; }


                if (player == 1 && textBox8.Text == "")
                {
                    textBox8.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox25.Text == "")
                {
                    textBox25.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox42.Text == "")
                {
                    textBox42.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int amount1 = 0;
                int amount2 = 0;
                int amount3 = 0;
                int amount4 = 0;
                int amount5 = 0;
                int amount6 = 0;
                int i = 0;
                int i1 = 0;
                int i2 = 0;
                int i3 = 0;
                int i4 = 0;
                int i5 = 0;
                int i6 = 0;

                if (pictureBox1.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }

                if (pictureBox1.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox2.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox3.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox4.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox5.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }

                if (pictureBox1.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox2.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox3.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox4.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox5.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }

                if (pictureBox1.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox2.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox3.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox4.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox5.Image == image4)
                {
                    i4 = i4 + 4;
                    amount5 = amount5 + 1;
                }

                if (pictureBox1.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox2.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox3.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox4.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox5.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }


                if (pictureBox1.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox2.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox3.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox4.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox5.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }

                if (amount6 >= 4)
                { i = i6; }
                else
                if (amount5 >= 4)
                { i = i5; }
                else
                if (amount4 >= 4)
                { i = i4; }
                else
                if (amount3 >= 4)
                { i = i3; }
                else
                if (amount2 >= 4)
                { i = i2; }
                else
                if (amount1 >= 4)
                { i = i1; }
                else
                { i = 0; }


                if (player == 1 && textBox9.Text == "")
                {
                    textBox9.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox26.Text == "")
                {
                    textBox26.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox43.Text == "")
                {
                    textBox43.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int amount1 = 0;
                int amount2 = 0;
                int amount3 = 0;
                int amount4 = 0;
                int amount5 = 0;
                int amount6 = 0;
                int i = 0;
                int i1 = 0;
                int i2 = 0;
                int i3 = 0;
                int i4 = 0;
                int i5 = 0;
                int i6 = 0;

                if (pictureBox1.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }

                if (pictureBox1.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox2.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox3.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox4.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox5.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }

                if (pictureBox1.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox2.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox3.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox4.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox5.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }

                if (pictureBox1.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox2.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox3.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox4.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox5.Image == image4)
                {
                    i4 = i4 + 4;
                    amount5 = amount5 + 1;
                }

                if (pictureBox1.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox2.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox3.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox4.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox5.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }


                if (pictureBox1.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox2.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox3.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox4.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox5.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }

                if (amount6 == 3 && amount1 == 2)
                { i = i6 + i1; }
                else
                if (amount6 == 3 && amount2 == 2)
                { i = i6 + i2; }
                else
                if (amount6 == 3 && amount3 == 2)
                { i = i6 + i3; }
                else
                if (amount6 == 3 && amount4 == 2)
                { i = i6 + i4; }
                else
                if (amount6 == 3 && amount5 == 2)
                { i = i6 + i5; }
                else
                if (amount5 == 3 && amount1 == 2)
                {
                    i = i5 + i1;
                }
                else
                if (amount5 == 3 && amount2 == 2)
                {
                    i = i5 + i2;
                }
                else
                if (amount5 == 3 && amount3 == 2)
                {
                    i = i5 + i3;
                }
                else
                if (amount5 == 3 && amount4 == 2)
                {
                    i = i5 + i4;
                }
                else
                if (amount5 == 3 && amount6 == 2)
                {
                    i = i5 + i6;
                }
                else
                  if (amount4 == 3 && amount1 == 2)
                {
                    i = i4 + i1;
                }
                else
                if (amount4 == 3 && amount2 == 2)
                {
                    i = i4 + i2;
                }
                else
                if (amount4 == 3 && amount3 == 2)
                {
                    i = i4 + i3;
                }
                else
                if (amount4 == 3 && amount5 == 2)
                {
                    i = i4 + i5;
                }
                else
                if (amount4 == 3 && amount6 == 2)
                {
                    i = i4 + i6;
                }
                else
                  if (amount3 == 3 && amount1 == 2)
                {
                    i = i3 + i1;
                }
                else
                if (amount3 == 3 && amount2 == 2)
                {
                    i = i3 + i2;
                }
                else
                if (amount3 == 3 && amount4 == 2)
                {
                    i = i3 + i4;
                }
                else
                if (amount3 == 3 && amount5 == 2)
                {
                    i = i3 + i5;
                }
                else
                if (amount3 == 3 && amount6 == 2)
                {
                    i = i3 + i6;
                }
                else

                if (amount2 == 3 && amount1 == 2)
                {
                    i = i2 + i1;
                }
                else
                if (amount2 == 3 && amount3 == 2)
                {
                    i = i2 + i3;
                }
                else
                if (amount2 == 3 && amount4 == 2)
                {
                    i = i2 + i4;
                }
                else
                if (amount2 == 3 && amount5 == 2)
                {
                    i = i2 + i5;
                }
                else
                if (amount2 == 3 && amount6 == 2)
                {
                    i = i2 + i6;
                }
                else


                if (amount1 == 3 && amount2 == 2)
                {
                    i = i1 + i2;
                }
                else
                if (amount1 == 3 && amount3 == 2)
                {
                    i = i1 + i3;
                }
                else
                if (amount1 == 3 && amount4 == 2)
                {
                    i = i1 + i4;
                }
                else
                if (amount1 == 3 && amount5 == 2)
                {
                    i = i1 + i5;
                }
                else
                if (amount1 == 3 && amount6 == 2)
                {
                    i = i1 + i6;
                }
                else

                { i = 0; }

                if (i > 0)
                { i = 25; }




                if (player == 1 && textBox10.Text == "")
                {
                    textBox10.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox27.Text == "")
                {
                    textBox27.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox44.Text == "")
                {
                    textBox44.Text = Convert.ToString(i);
                }

                allowed = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int amount1 = 0;
                int amount2 = 0;
                int amount3 = 0;
                int amount4 = 0;
                int amount5 = 0;
                int amount6 = 0;
                int i = 0;
                int i1 = 0;
                int i2 = 0;
                int i3 = 0;
                int i4 = 0;
                int i5 = 0;
                int i6 = 0;

                if (pictureBox1.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i1 = i1 + 1;
                    amount1 = amount1 + 1;
                }

                if (pictureBox1.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox2.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox3.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox4.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }
                if (pictureBox5.Image == image2)
                {
                    i2 = i2 + 2;
                    amount2 = amount2 + 1;
                }

                if (pictureBox1.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox2.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox3.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox4.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }
                if (pictureBox5.Image == image3)
                {
                    i3 = i3 + 3;
                    amount3 = amount3 + 1;
                }

                if (pictureBox1.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox2.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox3.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox4.Image == image4)
                {
                    i4 = i4 + 4;
                    amount4 = amount4 + 1;
                }
                if (pictureBox5.Image == image4)
                {
                    i4 = i4 + 4;
                    amount5 = amount5 + 1;
                }

                if (pictureBox1.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox2.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox3.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox4.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }
                if (pictureBox5.Image == image5)
                {
                    i5 = i5 + 5;
                    amount5 = amount5 + 1;
                }


                if (pictureBox1.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox2.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox3.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox4.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }
                if (pictureBox5.Image == image6)
                {
                    i6 = i6 + 6;
                    amount6 = amount6 + 1;
                }

                if (amount6 == 5)
                { i = i6; }
                else
                if (amount5 == 5)
                { i = i5; }
                else
                if (amount4 == 5)
                { i = i4; }
                else
                if (amount3 == 5)
                { i = i3; }
                else
                if (amount2 == 5)
                { i = i2; }
                else
                if (amount1 == 5)
                { i = i1; }
                else
                { i = 0; }

                if (i > 0)
                { i = 50; }


                if (player == 1 && textBox13.Text == "")
                {
                    textBox13.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox30.Text == "")
                {
                    textBox30.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox47.Text == "")
                {
                    textBox47.Text = Convert.ToString(i);
                }
                allowed = false;
                yahtzee = true;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (allowed == true)
            {
                int i = 0;


                if (pictureBox1.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox2.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox3.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox4.Image == image1)
                {
                    i = i + 1;
                }
                if (pictureBox5.Image == image1)
                {
                    i = i + 1;
                }

                if (pictureBox1.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox2.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox3.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox4.Image == image2)
                {
                    i = i + 2;
                }
                if (pictureBox5.Image == image2)
                {
                    i = i + 2;
                }

                if (pictureBox1.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox2.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox3.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox4.Image == image3)
                {
                    i = i + 3;
                }
                if (pictureBox5.Image == image3)
                {
                    i = i + 3;
                }

                if (pictureBox1.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox2.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox3.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox4.Image == image4)
                {
                    i = i + 4;
                }
                if (pictureBox5.Image == image4)
                {
                    i = i + 4;
                }

                if (pictureBox1.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox2.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox3.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox4.Image == image5)
                {
                    i = i + 5;
                }
                if (pictureBox5.Image == image5)
                {
                    i = i + 5;
                }


                if (pictureBox1.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox2.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox3.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox4.Image == image6)
                {
                    i = i + 6;
                }
                if (pictureBox5.Image == image6)
                {
                    i = i + 6;
                }

                if (player == 1 && textBox14.Text == "")
                {
                    textBox14.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox31.Text == "")
                {
                    textBox31.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox48.Text == "")
                {
                    textBox48.Text = Convert.ToString(i);
                }
                allowed = false;
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (yahtzee == true)
            {
                if (allowed == true)
                {
                    int amount1 = 0;
                    int amount2 = 0;
                    int amount3 = 0;
                    int amount4 = 0;
                    int amount5 = 0;
                    int amount6 = 0;
                    int i = 0;
                    int i1 = 0;
                    int i2 = 0;
                    int i3 = 0;
                    int i4 = 0;
                    int i5 = 0;
                    int i6 = 0;

                    if (pictureBox1.Image == image1)
                    {
                        i1 = i1 + 1;
                        amount1 = amount1 + 1;
                    }
                    if (pictureBox2.Image == image1)
                    {
                        i1 = i1 + 1;
                        amount1 = amount1 + 1;
                    }
                    if (pictureBox3.Image == image1)
                    {
                        i1 = i1 + 1;
                        amount1 = amount1 + 1;
                    }
                    if (pictureBox4.Image == image1)
                    {
                        i1 = i1 + 1;
                        amount1 = amount1 + 1;
                    }
                    if (pictureBox5.Image == image1)
                    {
                        i1 = i1 + 1;
                        amount1 = amount1 + 1;
                    }

                    if (pictureBox1.Image == image2)
                    {
                        i2 = i2 + 2;
                        amount2 = amount2 + 1;
                    }
                    if (pictureBox2.Image == image2)
                    {
                        i2 = i2 + 2;
                        amount2 = amount2 + 1;
                    }
                    if (pictureBox3.Image == image2)
                    {
                        i2 = i2 + 2;
                        amount2 = amount2 + 1;
                    }
                    if (pictureBox4.Image == image2)
                    {
                        i2 = i2 + 2;
                        amount2 = amount2 + 1;
                    }
                    if (pictureBox5.Image == image2)
                    {
                        i2 = i2 + 2;
                        amount2 = amount2 + 1;
                    }

                    if (pictureBox1.Image == image3)
                    {
                        i3 = i3 + 3;
                        amount3 = amount3 + 1;
                    }
                    if (pictureBox2.Image == image3)
                    {
                        i3 = i3 + 3;
                        amount3 = amount3 + 1;
                    }
                    if (pictureBox3.Image == image3)
                    {
                        i3 = i3 + 3;
                        amount3 = amount3 + 1;
                    }
                    if (pictureBox4.Image == image3)
                    {
                        i3 = i3 + 3;
                        amount3 = amount3 + 1;
                    }
                    if (pictureBox5.Image == image3)
                    {
                        i3 = i3 + 3;
                        amount3 = amount3 + 1;
                    }

                    if (pictureBox1.Image == image4)
                    {
                        i4 = i4 + 4;
                        amount4 = amount4 + 1;
                    }
                    if (pictureBox2.Image == image4)
                    {
                        i4 = i4 + 4;
                        amount4 = amount4 + 1;
                    }
                    if (pictureBox3.Image == image4)
                    {
                        i4 = i4 + 4;
                        amount4 = amount4 + 1;
                    }
                    if (pictureBox4.Image == image4)
                    {
                        i4 = i4 + 4;
                        amount4 = amount4 + 1;
                    }
                    if (pictureBox5.Image == image4)
                    {
                        i4 = i4 + 4;
                        amount5 = amount5 + 1;
                    }

                    if (pictureBox1.Image == image5)
                    {
                        i5 = i5 + 5;
                        amount5 = amount5 + 1;
                    }
                    if (pictureBox2.Image == image5)
                    {
                        i5 = i5 + 5;
                        amount5 = amount5 + 1;
                    }
                    if (pictureBox3.Image == image5)
                    {
                        i5 = i5 + 5;
                        amount5 = amount5 + 1;
                    }
                    if (pictureBox4.Image == image5)
                    {
                        i5 = i5 + 5;
                        amount5 = amount5 + 1;
                    }
                    if (pictureBox5.Image == image5)
                    {
                        i5 = i5 + 5;
                        amount5 = amount5 + 1;
                    }


                    if (pictureBox1.Image == image6)
                    {
                        i6 = i6 + 6;
                        amount6 = amount6 + 1;
                    }
                    if (pictureBox2.Image == image6)
                    {
                        i6 = i6 + 6;
                        amount6 = amount6 + 1;
                    }
                    if (pictureBox3.Image == image6)
                    {
                        i6 = i6 + 6;
                        amount6 = amount6 + 1;
                    }
                    if (pictureBox4.Image == image6)
                    {
                        i6 = i6 + 6;
                        amount6 = amount6 + 1;
                    }
                    if (pictureBox5.Image == image6)
                    {
                        i6 = i6 + 6;
                        amount6 = amount6 + 1;
                    }

                    if (amount6 == 5)
                    { i = i6; }
                    else
                    if (amount5 == 5)
                    { i = i5; }
                    else
                    if (amount4 == 5)
                    { i = i4; }
                    else
                    if (amount3 == 5)
                    { i = i3; }
                    else
                    if (amount2 == 5)
                    { i = i2; }
                    else
                    if (amount1 == 5)
                    { i = i1; }
                    else
                    { i = 0; }

                    if (i > 0)
                    { i = 100; }


                    if (player == 1 && textBox13.Text == "")
                    {
                        textBox13.Text = Convert.ToString(i);
                    }
                    if (player == 2 && textBox30.Text == "")
                    {
                        textBox30.Text = Convert.ToString(i);
                    }
                    if (player == 3 && textBox47.Text == "")
                    {
                        textBox47.Text = Convert.ToString(i);
                    }
                    allowed = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (allowed == true)
            {
                if (pictureBox1.Image == image1 && pictureBox2.Image == image2 && pictureBox3.Image == image3 && pictureBox4.Image == image4)
                { i = 30; }
                if (pictureBox2.Image == image2 && pictureBox3.Image == image3 && pictureBox4.Image == image4 && pictureBox5.Image == image5)
                { i = 30; }
                if (pictureBox4.Image == image1 && pictureBox3.Image == image2 && pictureBox2.Image == image3 && pictureBox1.Image == image4)
                { i = 30; }
                if (pictureBox5.Image == image1 && pictureBox4.Image == image2 && pictureBox3.Image == image3 && pictureBox2.Image == image4)
                { i = 30; }


                if (player == 1 && textBox28.Text == "")
                {
                    textBox28.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox12.Text == "")
                {
                    textBox12.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox11.Text == "")
                {
                    textBox11.Text = Convert.ToString(i);
                }
                allowed = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (allowed == true)
            {
                if (pictureBox1.Image == image1 && pictureBox2.Image == image2 && pictureBox3.Image == image3 && pictureBox4.Image == image4 && pictureBox5.Image == image5)
                { i = 40; }
                if (pictureBox5.Image == image5 && pictureBox4.Image == image4 && pictureBox3.Image == image3 && pictureBox2.Image == image2 && pictureBox1.Image == image1)
                { i = 40; }


                if (player == 1 && textBox46.Text == "")
                {
                    textBox46.Text = Convert.ToString(i);
                }
                if (player == 2 && textBox45.Text == "")
                {
                    textBox45.Text = Convert.ToString(i);
                }
                if (player == 3 && textBox29.Text == "")
                {
                    textBox29.Text = Convert.ToString(i);
                }
                allowed = false;
            }

        }
    }
}