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
using System.Timers;



namespace Assenstelsel___Hiwad_Rashad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<UIElement> storetest = new List<UIElement>();
        Line Line = new Line();
        Line Line2 = new Line();
        bool alreadyclicked = false;
        bool clickedtrue = false;
        bool axiscreated = false;
        string store;

   
        

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(100);
            timer.Start();


        }




        private void timer_Tick(object sender, EventArgs e)
        {

            if (clickedtrue == true)
            {

                string storecurrent = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string prexcooridnate = storecurrent.Split(',').First();
                string xcoordinate = prexcooridnate.Split('=').Last();
                string preprepreycoordinate = storecurrent.Split('=').Last();
                string prepreycoordinate = preprepreycoordinate.Split('=').Last();
                string preycoordinate = prepreycoordinate.Split('}').First();
                string ycoordinate = preycoordinate.Split(',').Last();
                int ynumber = Convert.ToInt32(ycoordinate);
                int xnumber = Convert.ToInt32(xcoordinate);
                string storestring = Convert.ToString(store);
                string storex = storestring.Split(',').First();
                string storey = storestring.Split(',').Last();
                int xstorenumber = Convert.ToInt32(storex);
                int ystorenumber = Convert.ToInt32(storey);
                int finalynumber = ystorenumber - ynumber;
                int finalxnumber = (xstorenumber - xnumber);
                string finalystring = Convert.ToString(finalynumber);
                string finalyxstring = Convert.ToString(finalxnumber * -1);
                string mathemeticalanswer = finalyxstring + "," + finalystring;
                Mathemetical.Content = mathemeticalanswer;
            }
        }


    

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Screen.Content = "Screen:" + System.Windows.Forms.Control.MousePosition;
            axiscreated = true;
            clickedtrue = true;
            if (alreadyclicked == false)
            {
                Line.Stroke = Brushes.Black;
                string programposition = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string programyposition = programposition.Split(',').First();
                Line.X1 = Convert.ToDouble(Convert.ToString(programyposition));
                Line.X2 = Convert.ToDouble(Convert.ToString(programyposition));
                Line.Y1 = -10000;
                Line.Y2 = 1000;

                Line2.Stroke = Brushes.Black;
                string programposition2 = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string programxposition = programposition2.Split(',').Last();
                Line2.X1 = -1000;
                Line2.X2 = 1000;
                Line2.Y1 = Convert.ToDouble(Convert.ToString(programxposition));
                Line2.Y2 = Convert.ToDouble(Convert.ToString(programxposition));


                Line.StrokeThickness = 2;
                Line2.StrokeThickness = 2;
                Canvas.Children.Add(Line);
                Canvas.Children.Add(Line2);
                alreadyclicked = true;
                Middle.Content = "{ X = 0,Y = 0}";
                store = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
            }
            else
            {
                Canvas.Children.Clear();

                Line.Stroke = Brushes.Black;
                string programposition = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string programyposition = programposition.Split(',').First();
                Line.X1 = Convert.ToDouble(Convert.ToString(programyposition));
                Line.X2 = Convert.ToDouble(Convert.ToString(programyposition));
                Line.Y1 = -10000;
                Line.Y2 = 1000;

                Line2.Stroke = Brushes.Black;
                string programposition2 = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string programxposition = programposition2.Split(',').Last();
                Line2.X1 = -1000;
                Line2.X2 = 1000;
                Line2.Y1 = Convert.ToDouble(Convert.ToString(programxposition));
                Line2.Y2 = Convert.ToDouble(Convert.ToString(programxposition));


                Line.StrokeThickness = 2;
                Line2.StrokeThickness = 2;
                Canvas.Children.Add(Line);
                Canvas.Children.Add(Line2);
                Middle.Content = "{ X = 0,Y = 0}";
                store = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
            }
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
