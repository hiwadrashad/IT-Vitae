using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Losgeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] FontNames =
        {
            "Times New Roman",
            "Courier New",
            "Palatino Linotype",
            "Segoe Script",
        };



        private void DrawCharacter(char c)
        {
            const float min_size = 10;
            const float max_size = 30;
            Random Rand = new Random();

            string font_name = FontNames[Rand.Next(0, FontNames.Length)];
            float font_size = (float)(min_size + Rand.NextDouble() *
            (max_size - min_size));
            FontStyle font_style = FontStyle.Regular;
            if (Rand.Next(0, 2) == 1) font_style |= FontStyle.Bold;
            if (Rand.Next(0, 2) == 1) font_style |= FontStyle.Italic;
            if (Rand.Next(0, 2) == 1) font_style |= FontStyle.Strikeout;
            if (Rand.Next(0, 2) == 1) font_style |= FontStyle.Underline;

            richTextBox1.SelectionFont =
            new Font(font_name, font_size, font_style);
            richTextBox1.AppendText(c.ToString());

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (char c in textBox1.Text)
            {
                DrawCharacter(c);
            }
        }
    }
}
