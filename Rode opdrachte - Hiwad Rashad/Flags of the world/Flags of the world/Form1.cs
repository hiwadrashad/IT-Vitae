using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;


namespace Flags_of_the_world
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string countryname = "";


        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            List<string> paths = Directory.GetFiles((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Flags of the world/flags")).ToList();
            var path = Path.GetFullPath(paths[rand.Next(0, paths.Count)]);
            pictureBox1.Image = new Bitmap(path);
            label1.Visible = false;
            textBox1.Visible = false;
            label3.Visible = true;
            button3.Text = "Next";
            var adress = path.Replace(".png", "");
            var adress2 = Regex.Split(adress, "flags");
            var adress3 = adress2[1];
            var adress4 = adress3.Replace(@"\", "");
            var adress5 = adress4.Replace("-", " ");
            countryname = adress5.Replace("_", " ");
            label3.Text = countryname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            var rand = new Random();
            List<string> paths = Directory.GetFiles((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Flags of the world/flags")).ToList();
            var path = Path.GetFullPath(paths[rand.Next(0, paths.Count)]);
            pictureBox1.Image = new Bitmap(path);
            label1.Visible = true;
            textBox1.Visible = true;
            label3.Visible = false;
            button3.Text = "Enter";
            var adress = path.Replace(".png", "");
            var adress2 = Regex.Split(adress, "flags");
            var adress3 = adress2[1];
            var adress4 = adress3.Replace(@"\", "");
            var adress5 = adress4.Replace("-", " ");
            countryname = adress5.Replace("_", " ");
   
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == "Next")
            {
                var rand = new Random();
                List<string> paths = Directory.GetFiles((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Flags of the world/flags")).ToList();
                var path = Path.GetFullPath(paths[rand.Next(0, paths.Count)]);
                pictureBox1.Image = new Bitmap(path);
                label1.Visible = false;
                textBox1.Visible = false;
                label3.Visible = true;
                button3.Text = "Next";
                var adress = path.Replace(".png", "");
                var adress2 = Regex.Split(adress, "flags");
                var adress3 = adress2[1];
                var adress4 = adress3.Replace(@"\", "");
                var adress5 = adress4.Replace("-", " ");
                countryname = adress5.Replace("_", " ");
                label3.Text = countryname;
            }

            else

            {
       
                {
                    if (textBox1.Text == countryname)
                    {
                        label2.Text = "You got it right!";
                    }
                    else
                    {
                        label2.Text = "Wrong";
                    }
                    var rand = new Random();
                    List<string> paths = Directory.GetFiles((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Flags of the world/flags")).ToList();
                    var path = Path.GetFullPath(paths[rand.Next(0, paths.Count)]);
                    pictureBox1.Image = new Bitmap(path);
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label3.Visible = false;
                    button3.Text = "Enter";
                    var adress = path.Replace(".png", "");
                    var adress2 = Regex.Split(adress, "flags");
                    var adress3 = adress2[1];
                    var adress4 = adress3.Replace(@"\", "");
                    var adress5 = adress4.Replace("-", " ");
                    countryname = adress5.Replace("_", " ");
                 
                }
            }
        }
    }
}
