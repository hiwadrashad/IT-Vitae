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
        Ellipse InnerCircle = new Ellipse();
        Ellipse OuterCircle = new Ellipse();
        bool gridalreadyclicked = false;
        bool alreadyclicked = false;
        bool clickedtrue = false;
        bool axiscreated = false;
        bool screenboxclicked = false;
        bool checkforgridnotdeleted = false;
        string store;
        public static string setX;
        public static int[][] createmainarrayx;
        public static int[][] createmainarrayy;
        public static int[][] createsidearrayx;
        public static int[][] createsidearrayy;
        public static string setY;
        public static int setXscreen;
        public static int setYscreen;
        public static int setThickness;
        public static int setColor;
        public static int SetBorderColor;
        public static int SetBorderThickness;
        public static string setGridcoordinates;
        public static string setScreencoordinates;
        public static string setGridAndScreenCoordinates;
        DerivedClass x = new DerivedClass();


        abstract class Punt
        {
            public abstract string X { get; }
            public abstract string Y { get; }
            public abstract int Xscreen { get; }
            public abstract int Yscreen { get; }
            public abstract int[][] MainGridx { get; }
            public abstract int[][] MainGridy { get; }
            public abstract int[][] SideGridx { get; }
            public abstract int[][] SideGridy { get; }
            public abstract int Thickness { get; }
            public abstract int Color { get; }
            public abstract int BorderThickness { get; }
            public abstract int BorderColor { get; }

            public abstract string Gridcoordinates { get; }
            public abstract string Screencoordinates { get; }
            public abstract string GridAndScreenCoordinates { get; }
        }



        class DerivedClass : Punt
        {

            public override string X
            {
                get
                {
                    return setX;
                }
            }
            public override string Y
            {
                get
                {
                    return setY;
                }
            }
            public override int Xscreen
            {
                get
                {
                    return setXscreen;
                }
            }
            public override int Yscreen
            {
                get
                {
                    return setYscreen;
                }
            }
            public override int[][] MainGridx
            {
                get
                {
                    return createmainarrayx;
                }
            }
            public override int[][] MainGridy
            {
                get
                {
                    return createmainarrayy;
                }
            }
            public override int[][] SideGridx
            {
                get
                {
                    return createsidearrayx;
                }
            }
            public override int[][] SideGridy
            {
                get
                {
                    return createsidearrayy;
                }
            }


            public override int Thickness
            {
                get
                {
                    return setThickness;
                }
            }
            public override int Color
            {
                get
                {
                    return setColor;
                }
            }
            public override int BorderThickness
            {
                get
                {
                    return SetBorderThickness;
                }
            }
            public override int BorderColor
            {
                get
                {
                    return SetBorderColor;
                }
            }
            public override string Gridcoordinates
            {
                get
                {
                    return setGridcoordinates;
                }
            }
            public override string Screencoordinates
            {
                get
                {
                    return setScreencoordinates;
                }
            }
            public override string GridAndScreenCoordinates
            {
                get
                {
                    return setGridAndScreenCoordinates;
                }
            }


        }


        public MainWindow()
        {
            InitializeComponent();
        }


        public void DrawPoint()
        {
            Screen.Content = "Screen:" + System.Windows.Forms.Control.MousePosition;
            axiscreated = true;
            clickedtrue = true;
            if (alreadyclicked == false)
            {
                string storecurrent = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string storecurrentx = storecurrent.Split(',').First();
                string storecurrenty = storecurrent.Split(',').Last();
                setXscreen = ((Convert.ToInt32(storecurrenty) - (420 / 2)) * -1) - 10;
                setYscreen = Convert.ToInt32(storecurrentx) - (800 / 2);
                setScreencoordinates = Convert.ToString(x.Xscreen) + "," + Convert.ToString(x.Yscreen);
                Mathemetical.Content = "Mathemetical: " + x.Screencoordinates;
                string programposition = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string programyposition = programposition.Split(',').First();
                string programxposition = programposition.Split(',').Last();
                OuterCircle.Stroke = Brushes.Red;
                OuterCircle.Width = Slider2.Value;
                OuterCircle.Height = Slider2.Value;
                OuterCircle.StrokeThickness = 6;
                OuterCircle.Fill = new SolidColorBrush(Colors.Red);
                Canvas.Children.Add(OuterCircle);
                OuterCircle.SetValue(Canvas.LeftProperty, Convert.ToDouble(programyposition) - (Slider2.Value / 2));
                OuterCircle.SetValue(Canvas.TopProperty, Convert.ToDouble(programxposition) - (Slider2.Value / 2));

                InnerCircle.Stroke = Brushes.Black;
                InnerCircle.Width = Slider.Value;
                InnerCircle.Height = Slider.Value;
                InnerCircle.StrokeThickness = 6;
                InnerCircle.Fill = new SolidColorBrush(Colors.Black);
                Canvas.Children.Add(InnerCircle);
                InnerCircle.SetValue(Canvas.LeftProperty, Convert.ToDouble(programyposition) - ((Slider.Value / 2)));
                InnerCircle.SetValue(Canvas.TopProperty, Convert.ToDouble(programxposition) - ((Slider.Value) / 2));





                alreadyclicked = true;
                store = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
            }
            else
            {
                string storecurrent = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                string storecurrentx = storecurrent.Split(',').First();
                string storecurrenty = storecurrent.Split(',').Last();
                double storeynumber = ((Convert.ToDouble(storecurrenty) - (420 / 2)) * -1) - 10;
                double storexnumber = Convert.ToDouble(storecurrentx) - (800 / 2);
                string mathemeticalcoordinates = Convert.ToString(storexnumber) + "," + Convert.ToString(storeynumber);
                Mathemetical.Content = "Mathemetical: " + mathemeticalcoordinates;
                Canvas.Children.Clear();
                string programposition = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
                setY = programposition.Split(',').First();
                setX = programposition.Split(',').Last();
                OuterCircle.Width = Slider2.Value;
                OuterCircle.Height = Slider2.Value;
                OuterCircle.StrokeThickness = 6;
                Canvas.Children.Add(OuterCircle);
                OuterCircle.SetValue(Canvas.LeftProperty, Convert.ToDouble(x.Y) - (Slider2.Value / 2));
                OuterCircle.SetValue(Canvas.TopProperty, Convert.ToDouble(x.X) - (Slider2.Value / 2));


                Canvas.Children.Add(gridnumber1);
                Canvas.Children.Add(gridnumber2);
                Canvas.Children.Add(gridnumber3);
                Canvas.Children.Add(gridnumber4);
                Canvas.Children.Add(gridnumber5);
                Canvas.Children.Add(gridnumber6);
                Canvas.Children.Add(gridnumber7);
                Canvas.Children.Add(gridnumber8);
                Canvas.Children.Add(gridnumber9);
                Canvas.Children.Add(gridnumber10);
                Canvas.Children.Add(gridnumber11);
                Canvas.Children.Add(gridnumber12);




                InnerCircle.Width = Slider.Value;
                InnerCircle.Height = Slider.Value;
                InnerCircle.StrokeThickness = 6;
                Canvas.Children.Add(InnerCircle);
                InnerCircle.SetValue(Canvas.LeftProperty, Convert.ToDouble(x.Y) - (Slider.Value / 2));
                InnerCircle.SetValue(Canvas.TopProperty, Convert.ToDouble(x.X) - (Slider.Value / 2));

                if (checkforgridnotdeleted == true)
                {

                    int xaxissmall = 0;
                    int yaxissmall = 0;
                    int xaxisbig = 0;
                    int yaxisbig = 0;




                    while (yaxisbig < 800)
                    {
                        yaxisbig += 100;
                        Line y = new Line();
                        y.Stroke = Brushes.Black;
                        y.X1 = Convert.ToDouble(yaxisbig);
                        y.X2 = Convert.ToDouble(yaxisbig);
                        y.Y1 = -10000;
                        y.Y2 = 1000;

                        y.StrokeThickness = 1;
                        Canvas.Children.Add(y);

                        gridalreadyclicked = true;
                    }


                    while (xaxisbig < 800)
                    {
                        xaxisbig += 100;
                        Line x = new Line();
                        x.Stroke = Brushes.Black;
                        x.X1 = -1000;
                        x.X2 = 1000;
                        x.Y1 = Convert.ToDouble(xaxisbig);
                        x.Y2 = Convert.ToDouble(xaxisbig);
                        Canvas.Children.Add(x);
                        Canvas.Children.Add(new UIElement() { Uid = "line" });
                        x.StrokeThickness = 1;
                        foreach (UIElement ui in Canvas.Children)
                        {
                            storetest.Add(ui);
                        }
                    }

                    while (xaxissmall < 800)
                    {
                        xaxissmall += 10;
                        Line x2 = new Line();
                        x2.Stroke = Brushes.Black;
                        x2.X1 = Convert.ToDouble(xaxissmall);
                        x2.X2 = Convert.ToDouble(xaxissmall);
                        x2.Y1 = -1000;
                        x2.Y2 = 1000;
                        Canvas.Children.Add(x2);
                        Canvas.Children.Add(new UIElement() { Uid = "Line" });
                        x2.StrokeThickness = 0.5;
                        foreach (UIElement ui in Canvas.Children)
                        {
                            storetest.Add(ui);
                        }
                    }

                    while (yaxissmall < 800)
                    {
                        yaxissmall += 10;
                        Line y2 = new Line();
                        y2.Stroke = Brushes.Black;
                        y2.X1 = -1000;
                        y2.X2 = 1000;
                        y2.Y1 = Convert.ToDouble(yaxissmall);
                        y2.Y2 = Convert.ToDouble(yaxissmall);
                        Canvas.Children.Add(y2);
                        Canvas.Children.Add(new UIElement() { Uid = "Line" });
                        y2.StrokeThickness = 0.5;
                        foreach (UIElement ui in Canvas.Children)
                        {
                            storetest.Add(ui);
                        }
                    }

                }

                store = Convert.ToString(Mouse.GetPosition(Application.Current.MainWindow));
            }
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(100);
            timer.Start();

            Screen.Visibility = Visibility.Hidden;
            Mathemetical.Visibility = Visibility.Hidden;
            gridnumber1.Visibility = Visibility.Hidden;
            gridnumber2.Visibility = Visibility.Hidden;
            gridnumber3.Visibility = Visibility.Hidden;
            gridnumber4.Visibility = Visibility.Hidden;
            gridnumber5.Visibility = Visibility.Hidden;
            gridnumber6.Visibility = Visibility.Hidden;
            gridnumber7.Visibility = Visibility.Hidden;
            gridnumber8.Visibility = Visibility.Hidden;
            gridnumber9.Visibility = Visibility.Hidden;
            gridnumber10.Visibility = Visibility.Hidden;
            gridnumber11.Visibility = Visibility.Hidden;
            gridnumber12.Visibility = Visibility.Hidden;


        }




        private void timer_Tick(object sender, EventArgs e)
        {

           
        }


        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
          
            

        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DrawPoint();
        }


        private void Screenbox_Checked(object sender, RoutedEventArgs e)
        {
            screenboxclicked = true;
            gridnumber1.Visibility = Visibility.Visible;
            gridnumber2.Visibility = Visibility.Visible;
            gridnumber3.Visibility = Visibility.Visible;
            gridnumber4.Visibility = Visibility.Visible;
            gridnumber5.Visibility = Visibility.Visible;
            gridnumber6.Visibility = Visibility.Visible;
            gridnumber7.Visibility = Visibility.Visible;
            gridnumber8.Visibility = Visibility.Visible;
            gridnumber9.Visibility = Visibility.Visible;
            gridnumber10.Visibility = Visibility.Visible;
            gridnumber11.Visibility = Visibility.Visible;
            gridnumber12.Visibility = Visibility.Visible;


        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            int xaxissmall = 0;
            int yaxissmall = 0;
            int xaxisbig = 0;
            int yaxisbig = 0;

            checkforgridnotdeleted = true;


            while (yaxisbig < 800)
            {
                yaxisbig += 100;
                Line y = new Line();
                y.Stroke = Brushes.Black;
                y.X1 = Convert.ToDouble(yaxisbig);
                y.X2 = Convert.ToDouble(yaxisbig);
                y.Y1 = -10000;
                y.Y2 = 1000;

                y.StrokeThickness = 1;
                Canvas.Children.Add(y);

                gridalreadyclicked = true;
            }


            while (xaxisbig < 800)
            {
                xaxisbig += 100;
                Line x = new Line();
                x.Stroke = Brushes.Black;
                x.X1 = -1000;
                x.X2 = 1000;
                x.Y1 = Convert.ToDouble(xaxisbig);
                x.Y2 = Convert.ToDouble(xaxisbig);
                Canvas.Children.Add(x);
                Canvas.Children.Add(new UIElement() { Uid = "line" });
                x.StrokeThickness = 1;
                foreach (UIElement ui in Canvas.Children)
                {
                    storetest.Add(ui);
                }
            }

            while (xaxissmall < 800)
            {
                xaxissmall += 10;
                Line x2 = new Line();
                x2.Stroke = Brushes.Black;
                x2.X1 = Convert.ToDouble(xaxissmall);
                x2.X2 = Convert.ToDouble(xaxissmall);
                x2.Y1 = -1000;
                x2.Y2 = 1000;
                Canvas.Children.Add(x2);
                Canvas.Children.Add(new UIElement() { Uid = "Line" });
                x2.StrokeThickness = 0.5;
                foreach (UIElement ui in Canvas.Children)
                {
                    storetest.Add(ui);
                }
            }

            while (yaxissmall < 800)
            {
                yaxissmall += 10;
                Line y2 = new Line();
                y2.Stroke = Brushes.Black;
                y2.X1 = -1000;
                y2.X2 = 1000;
                y2.Y1 = Convert.ToDouble(yaxissmall);
                y2.Y2 = Convert.ToDouble(yaxissmall);
                Canvas.Children.Add(y2);
                Canvas.Children.Add(new UIElement() { Uid = "Line" });
                y2.StrokeThickness = 0.5;
                foreach (UIElement ui in Canvas.Children)
                {
                    storetest.Add(ui);
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            System.Windows.Forms.ColorDialog MyDialog = new System.Windows.Forms.ColorDialog();
            if (MyDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Media.Color NewColor = System.Windows.Media.Color.FromArgb(MyDialog.Color.A, MyDialog.Color.R, MyDialog.Color.G, MyDialog.Color.B);  
                Brush brush = new SolidColorBrush(NewColor);

                InnerCircle.Stroke = brush;
                InnerCircle.Fill = brush;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog MyDialog = new System.Windows.Forms.ColorDialog();
            if (MyDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Media.Color NewColor = System.Windows.Media.Color.FromArgb(MyDialog.Color.A, MyDialog.Color.R, MyDialog.Color.G, MyDialog.Color.B);
                Brush brush = new SolidColorBrush(NewColor);

                OuterCircle.Stroke = brush;
                OuterCircle.Fill = brush;
            }

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
      
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
        }

        private void Gridbox_Unchecked(object sender, RoutedEventArgs e)
        {
            checkforgridnotdeleted = false;
            if (axiscreated == true)
            {
                Canvas.Children.Clear();
                Canvas.Children.Add(OuterCircle);
                Canvas.Children.Add(InnerCircle);
                if (screenboxclicked == true)
                {

                    Canvas.Children.Add(gridnumber1);
                    Canvas.Children.Add(gridnumber2);
                    Canvas.Children.Add(gridnumber3);
                    Canvas.Children.Add(gridnumber4);
                    Canvas.Children.Add(gridnumber5);
                    Canvas.Children.Add(gridnumber6);
                    Canvas.Children.Add(gridnumber7);
                    Canvas.Children.Add(gridnumber8);
                    Canvas.Children.Add(gridnumber9);
                    Canvas.Children.Add(gridnumber10);
                    Canvas.Children.Add(gridnumber11);
                    Canvas.Children.Add(gridnumber12);

                }
            }
            else
            {
                Canvas.Children.Clear();
                if (screenboxclicked == true)
                {
                    Canvas.Children.Add(gridnumber1);
                    Canvas.Children.Add(gridnumber2);
                    Canvas.Children.Add(gridnumber3);
                    Canvas.Children.Add(gridnumber4);
                    Canvas.Children.Add(gridnumber5);
                    Canvas.Children.Add(gridnumber6);
                    Canvas.Children.Add(gridnumber7);
                    Canvas.Children.Add(gridnumber8);
                    Canvas.Children.Add(gridnumber9);
                    Canvas.Children.Add(gridnumber10);
                    Canvas.Children.Add(gridnumber11);
                    Canvas.Children.Add(gridnumber12);

                }
            }
        }

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            Screen.Visibility = Visibility.Visible;
        }

        private void CheckBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            Screen.Visibility = Visibility.Hidden;
        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            Mathemetical.Visibility = Visibility.Visible;
        }

        private void CheckBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            Mathemetical.Visibility = Visibility.Hidden;
        }

        private void Screenbox_Unchecked(object sender, RoutedEventArgs e)
        {
            screenboxclicked = false;
            gridnumber1.Visibility = Visibility.Hidden;
            gridnumber2.Visibility = Visibility.Hidden;
            gridnumber3.Visibility = Visibility.Hidden;
            gridnumber4.Visibility = Visibility.Hidden;
            gridnumber5.Visibility = Visibility.Hidden;
            gridnumber6.Visibility = Visibility.Hidden;
            gridnumber7.Visibility = Visibility.Hidden;
            gridnumber8.Visibility = Visibility.Hidden;
            gridnumber9.Visibility = Visibility.Hidden;
            gridnumber10.Visibility = Visibility.Hidden;
            gridnumber11.Visibility = Visibility.Hidden;
            gridnumber12.Visibility = Visibility.Hidden;

        }
    }
}