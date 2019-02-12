using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morse_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add(" ", "/");
            dictionary.Add("A", ".-|");
            dictionary.Add("a", ".-|");
            dictionary.Add("B", "-...|");
            dictionary.Add("b", "-...|");
            dictionary.Add("C", "-.-.|");
            dictionary.Add("c", "-.-.|");
            dictionary.Add("D", "-..|");
            dictionary.Add("d", "-..|");
            dictionary.Add("E", ".|");
            dictionary.Add("e", ".|");
            dictionary.Add("F", "..-.|");
            dictionary.Add("f", "..-.|");
            dictionary.Add("G", "--.|");
            dictionary.Add("g", "--.|");
            dictionary.Add("H", "....|");
            dictionary.Add("h", "....|");
            dictionary.Add("I", "..|");
            dictionary.Add("i", "..|");
            dictionary.Add("J", ".---|");
            dictionary.Add("j", ".---|");
            dictionary.Add("K", "-.-|");
            dictionary.Add("k", "-.-|");
            dictionary.Add("L", ".-..|");
            dictionary.Add("l", ".-..|");
            dictionary.Add("M", "--|");
            dictionary.Add("m", "--|");
            dictionary.Add("N", "-.|");
            dictionary.Add("n", "-.|");
            dictionary.Add("O", "---|");
            dictionary.Add("o", "---|");
            dictionary.Add("P", ".--.|");
            dictionary.Add("p", ".--.|");
            dictionary.Add("Q", "--.-|");
            dictionary.Add("q", "--.-|");
            dictionary.Add("R", ".-.|");
            dictionary.Add("r", ".-.|");
            dictionary.Add("S", "...|");
            dictionary.Add("s", "...|");
            dictionary.Add("T", "-|");
            dictionary.Add("t", "-|");
            dictionary.Add("U", "..-|");
            dictionary.Add("u", "..-|");
            dictionary.Add("V", "...-|");
            dictionary.Add("v", "...-|");
            dictionary.Add("W", ".--|");
            dictionary.Add("w", ".--|");
            dictionary.Add("X", "-..-|");
            dictionary.Add("x", "-..-|");
            dictionary.Add("Y", "-.--|");
            dictionary.Add("y", "-.--|");
            dictionary.Add("Z", "--..|");
            dictionary.Add("z", "--..|");

            dictionary.Add("1", ".----|");
            dictionary.Add("2", "..---|");
            dictionary.Add("3", "...--|");
            dictionary.Add("4", "....-|");
            dictionary.Add("5", ".....|");
            dictionary.Add("6", "-....|");
            dictionary.Add("7", "--...|");
            dictionary.Add("8", "---..|");
            dictionary.Add("9", "----.|");
            dictionary.Add("0", "-----|");

            



            var text = textBox1.Text;
            var morse = string.Empty;

            foreach (var c in text)
            {
                morse += dictionary[c.ToString().ToUpper()] + "";
            }

            textBox2.Text = morse;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string morse = textBox2.Text;

            string morseConverted = morse.Replace("/", " ").Replace("-----|", "0").Replace("----.|", "9").Replace("---..|", "8").Replace(".----|", "1").Replace("..---|", "2").Replace("...--|", "3").Replace("....-|", "4").Replace(".....|", "5").Replace("-....|", "6").Replace("--...|", "7").Replace("-..-|", "x").Replace("...-|", "v").Replace("-.--|", "y").Replace("--..|", "z").Replace("--.-|", "q").Replace(".--.|", "p").Replace("-...|", "b").Replace("-.-.|", "c").Replace(".-..|", "l").Replace(".---|", "j").Replace("....|", "h").Replace("..-.|", "f").Replace("---|", "o").Replace("...|", "s").Replace("..-|", "u")
                .Replace(".-.|", "r").Replace("-..|", "d").Replace("--.|", "g").Replace("-.-|", "k").Replace(".--|", "w").Replace("..|", "i").Replace("--|", "m").Replace(" -.|", "n").Replace(".-|", "a")
            .Replace(".|", "e").Replace("-|", "t");
               

            textBox1.Text = morseConverted;
        }
    }
}
