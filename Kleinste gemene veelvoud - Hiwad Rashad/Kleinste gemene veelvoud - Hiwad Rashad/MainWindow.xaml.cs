using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kleinste_gemene_veelvoud___Hiwad_Rashad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int firstnumber = Convert.ToInt32(NumberOne.Text);
            int secondnumber = Convert.ToInt32(NumberTwo.Text);
            int i = 0;
            bool found = false;
    

            while (found == false)
            {
                i++;

  
                if (firstnumber%i == 0 && secondnumber%i == 0)
                {
                    Answer.Content = (firstnumber * secondnumber) / i;
                    found = true;
                }

            }

        }
    }
}
