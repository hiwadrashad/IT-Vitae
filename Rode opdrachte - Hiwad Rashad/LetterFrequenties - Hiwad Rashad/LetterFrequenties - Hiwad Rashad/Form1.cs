using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace LetterFrequenties___Hiwad_Rashad
{
    public partial class Form1 : Form
    {
        int charcCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

            int a = (Input.Text.Length - Input.Text.Replace("a","").Replace("A","").Length);
            aOutput.Text = "A: " + a.ToString();
            int b = Input.Text.Length - Input.Text.Replace("b", "").Replace("B", "").Length;
            bOutput.Text = "B: " + b.ToString();
            int c = Input.Text.Length - Input.Text.Replace("c", "").Replace("C", "").Length;
            cOutput.Text = "C: " + c.ToString();
            int d = Input.Text.Length - Input.Text.Replace("d", "").Replace("D", "").Length;
            dOutput.Text = "D: " + d.ToString();
            int e1 = Input.Text.Length - Input.Text.Replace("e", "").Replace("E", "").Length;
            eOutput.Text = "E: " + e1.ToString();
            int f = Input.Text.Length - Input.Text.Replace("f", "").Replace("F", "").Length;
            fOutput.Text = "F: " + f.ToString();
            int g = Input.Text.Length - Input.Text.Replace("g", "").Replace("G", "").Length;
            gOutput.Text = "G: " + g.ToString();
            int h = Input.Text.Length - Input.Text.Replace("h", "").Replace("H", "").Length;
            hOutput.Text = "H: " + h.ToString();
            int i = Input.Text.Length - Input.Text.Replace("i", "").Replace("I", "").Length;
            iOutput.Text = "I: " + i.ToString();
            int j = Input.Text.Length - Input.Text.Replace("j", "").Replace("J", "").Length;
            jOutput.Text = "J: " + j.ToString();
            int k = Input.Text.Length - Input.Text.Replace("k", "").Replace("K", "").Length;
            kOutput.Text = "K: " + k.ToString();
            int l = Input.Text.Length - Input.Text.Replace("l", "").Replace("L", "").Length;
            lOutput.Text = "L: " + l.ToString();
            int m = Input.Text.Length - Input.Text.Replace("m", "").Replace("M", "").Length;
            mOutput.Text = "M: " + m.ToString();
            int n = Input.Text.Length - Input.Text.Replace("n", "").Replace("N", "").Length;
            nOutput.Text = "N: " + n.ToString();
            int o = Input.Text.Length - Input.Text.Replace("o", "").Replace("O", "").Length;
            oOutput.Text = "O: " + o.ToString();
            int p = Input.Text.Length - Input.Text.Replace("p", "").Replace("P", "").Length;
            pOutput.Text = "P: " + p.ToString();
            int q = Input.Text.Length - Input.Text.Replace("q", "").Replace("Q", "").Length;
            qOutput.Text = "Q: " + q.ToString();
            int r = Input.Text.Length - Input.Text.Replace("r", "").Replace("R", "").Length;
            rOutput.Text = "R: " + r.ToString();
            int s = Input.Text.Length - Input.Text.Replace("s", "").Replace("S", "").Length;
            sOutput.Text = "S: " + s.ToString();
            int t = Input.Text.Length - Input.Text.Replace("t", "").Replace("T", "").Length;
            tOutput.Text = "T: " + t.ToString();
            int u = Input.Text.Length - Input.Text.Replace("u", "").Replace("U", "").Length;
            uOutput.Text = "U: " + u.ToString();
            int v = Input.Text.Length - Input.Text.Replace("v", "").Replace("V", "").Length;
            vOutput.Text = "V: " + v.ToString();
            int w = Input.Text.Length - Input.Text.Replace("w", "").Replace("W", "").Length;
            wOutput.Text = "W: " + w.ToString();
            int x = Input.Text.Length - Input.Text.Replace("x", "").Replace("X", "").Length;
            xOutput.Text = "X: " + x.ToString();
            int y = Input.Text.Length - Input.Text.Replace("y", "").Replace("Y", "").Length;
            yOutput.Text = "Y: " + y.ToString();
            int z = Input.Text.Length - Input.Text.Replace("z", "").Replace("Z", "").Length;
            zOutput.Text = "Z: " + z.ToString();


        }


    }
}
