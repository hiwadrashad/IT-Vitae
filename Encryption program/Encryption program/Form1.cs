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

namespace Encryption_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String EncryptPassword(string pass)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            string EncryptPassword = Convert.ToBase64String(bytes);
            return EncryptPassword;

        }

        private string Decryptpassword(string Encryptedpass)
        {
            byte[] bytes = Convert.FromBase64String(Encryptedpass);
            string Decryptpassword = System.Text.Encoding.Unicode.GetString(bytes);
            return Decryptpassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = EncryptPassword(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Decryptpassword(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/EncryptionData.txt"))
            {
                sw.WriteLine(label1.Text);
                sw.WriteLine(label2.Text);
            }
        }
    }
}
