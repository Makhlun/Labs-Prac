using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lab_2_First_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DispatcherTimer dT;
        static int Radius = 30;
        static int PointCount = 5;
        static Polygon myPolygon = new Polygon();
        static List<Ellipse> EllipseArray = new List<Ellipse>();
        static PointCollection pC = new PointCollection();
        const int Popul = 30;
        int[] BestWay;
        Random rnd = new Random();

        public MainWindow()
        {
            dT = new DispatcherTimer();

            InitializeComponent();
            InitPoints();
            InitPolygon();

            dT = new DispatcherTimer();
            dT.Tick += new EventHandler(OneStep);
            dT.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }

        private void InitPoints()
        {
            Random rnd = new Random();
            pC.Clear();
            EllipseArray.Clear();
            
            for (int i = 0; i < PointCount; i++)
            {
                Point p = new Point();

                p.X = rnd.Next(Radius, (int)(0.75 * MainWin.Width) - 3 * Radius);
                p.Y = rnd.Next(Radius, (int)(0.90 * MainWin.Height - 3 * Radius));
                pC.Add(p);
            }

            for (int i = 0; i < PointCount; i++)
            {
                Ellipse el = new Ellipse();

                el.StrokeThickness = 2;
                el.Height = el.Width = Radius;
                el.Stroke = Brushes.Black;
                el.Fill = Brushes.LightBlue;
                EllipseArray.Add(el);
            }
        }

        private void InitPolygon()
        {
            myPolygon.Stroke = System.Windows.Media.Brushes.Black;
            myPolygon.StrokeThickness = 2;
        }

        private void PlotPoints()
        {
            for (int i = 0; i < PointCount; i++)
            {
                Canvas.SetLeft(EllipseArray[i], pC[i].X - Radius / 2);
                Canvas.SetTop(EllipseArray[i], pC[i].Y - Radius / 2);
                MyCanvas.Children.Add(EllipseArray[i]);
            }
        }


        private void PlotWay(int[] BestWayIndex)
        {
            PointCollection Points = new PointCollection();

            for (int i = 0; i < BestWayIndex.Length; i++)
                Points.Add(pC[BestWayIndex[i]]);

            myPolygon.Points = Points;
            MyCanvas.Children.Add(myPolygon);
        }

        private void VelCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox CB = (ComboBox)e.Source;
            ListBoxItem item = (ListBoxItem)CB.SelectedItem;

            dT.Interval = new TimeSpan(0, 0, 0, 0, Convert.ToInt16(item.Content));
        }

        private void StopStart_Click(object sender, RoutedEventArgs e)
        {
            if (dT.IsEnabled)
            {
                dT.Stop();
                NumElemCB.IsEnabled = true;
            }
            else
            {
                NumElemCB.IsEnabled = false;
                dT.Start();
            }
        }

        private void NumElemCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox CB = (ComboBox)e.Source;
            ListBoxItem item = (ListBoxItem)CB.SelectedItem;

            PointCount = Convert.ToInt32(item.Content);
            BestWay = null;
            InitPoints();
            InitPolygon();
        }
        private void OneStep(object sender, EventArgs e)
        {
            MyCanvas.Children.Clear();
            PlotPoints();
            PlotWay(GetBestWay());
        }

        private int[] GetBestWay()
        {
            List<int[]> ways = new List<int[]>();
            List<int> count = new List<int>();
            List<double> length = new List<double>();

            for (int i = 0; i < Popul; i++)
            {
                int[] way = new int[PointCount];
                for (int k = 0; k < PointCount; k++)
                {
                    count.Add(k);
                }
                for (int j = 0; j < PointCount; j++)
                {
                    way[j] = count[rnd.Next(count.Count)];
                    count.Remove(way[j]);
                }
                ways.Add(way);
            }
            if (BestWay == null)
            {
                BestWay = ways[0];
                return BestWay;
            }
            for (int i = 0; i < PointCount * PointCount; i++)
            {
                ways = Crossing(ways).OrderBy(d => LENGTH(d)).Take(Popul).ToList();
            }
            if (LENGTH(BestWay)> LENGTH(ways[0]))
            {
                BestWay = ways[0];
            }
            return BestWay;
        }

        private double LENGTH(int[] way)
        {
            double L = 0;
            for (int i1 = 1; i1 < PointCount; i1++)
            {
                L += Math.Sqrt(Math.Pow(pC[way[i1]].X - pC[way[i1 - 1]].X, 2) + Math.Pow(pC[way[i1]].Y - pC[way[i1 - 1]].Y, 2));
            }
            L += Math.Sqrt(Math.Pow(pC[way[0]].X - pC[way[PointCount - 1]].X, 2) + Math.Pow(pC[0].Y - pC[PointCount - 1].Y, 2));
            return L;
        }

        private List<int[]> Crossing(List<int[]> ways)
        {
            int i1, i2, cr;
            List<int> temp1, temp2;
            int[] t1, t2, t3, t4;
            for (int i = 0; i < Popul; i++)
            {
                i1 = rnd.Next(Popul);
                i2 = rnd.Next(Popul);
                cr = rnd.Next(2, PointCount - 2);

                t1 = ways[i1].ToList().GetRange(0, cr).ToArray();
                t2 = ways[i1].ToList().GetRange(cr, PointCount - cr).ToArray();
                t3 = ways[i2].ToList().GetRange(0, cr).ToArray();
                t4 = ways[i2].ToList().GetRange(cr, PointCount - cr).ToArray();
                temp1 = t1.ToList(); temp1.AddRange(t4);
                temp2 = t3.ToList(); temp2.AddRange(t2);
                IEnumerable<int> ch;
                if (rnd.NextDouble() >= 0.5)
                    ch = temp1.Union(temp2);
                else
                    ch = temp2.Union(temp1);

                if (rnd.NextDouble() < 0.7)
                {
                    i1 = rnd.Next(PointCount);
                    i2 = rnd.Next(PointCount);
                    var temp = ch.ToList();
                    if (i1 > i2)
                        temp.Reverse(i2, i1 - i2);
                    else
                        temp.Reverse(i1, i2 - i1);
                    ch = temp;
                }
                ways.Add(ch.ToArray());
            }
            return ways;
        }
    }
}