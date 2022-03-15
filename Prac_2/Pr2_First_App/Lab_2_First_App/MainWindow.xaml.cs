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
        static DispatcherTimer dT; // для вказування проміжку між змінами
        static int Radius = 25; // Радіус міст
        static int PointCount = 5; //Кількість міст
        static Polygon myPolygon = new Polygon();
        static List<Ellipse> EllipseArray = new List<Ellipse>(); //Список еліпсів
        static PointCollection pC = new PointCollection(); //Коллекція точок

        public MainWindow()  //Головне вікно
        {
            dT = new DispatcherTimer();//Виділення памяті 

            InitializeComponent(); //Ініціалізація змісту
            InitPoints(); //ініціалізація точок
            InitPolygon(); //Ініціалізація полігону

            dT.Tick += new EventHandler(OneStep); //Не дуже зрозуміло. Пише:Виникає при сплиненні інтервала таймеру 
            dT.Interval = new TimeSpan(0, 0, 0, 0, 1000); //Інтервал в мс      
        }

        private void InitPoints() //ініціалізація точок
        {
            Random rnd = new Random(); //Рандом
            pC.Clear(); //Очистка колекції точок 
            EllipseArray.Clear(); //Очистка масиву точок

            for (int i = 0; i < PointCount; i++) //Рандомна поява точок на полігоні
            {
                Point p = new Point(); //Виведення памяті під точку

                p.X = rnd.Next(Radius, (int)(0.75 * MainWin.Width) - 3 * Radius); //Координата Х
                p.Y = rnd.Next(Radius, (int)(0.90 * MainWin.Height - 3 * Radius)); //Координата У
                pC.Add(p); //Додавання точки до загального коллекції точок
            }

            for (int i = 0; i < PointCount; i++) //Ініціалізація точок у вигляді еліпсів
            {
                Ellipse el = new Ellipse();

                el.StrokeThickness = 2; //ширина контура
                el.Height = el.Width = Radius; //утворення кола
                el.Stroke = Brushes.Black; // колір контура
                el.Fill = Brushes.Blue; //колір заповнення
                EllipseArray.Add(el); //Додавання до списку еліпсів
            }
        }

        private void InitPolygon() //Ініціалізація полігону
        {
            myPolygon.Stroke = Brushes.Black; //Задає колір ліній
            myPolygon.StrokeThickness = 2; //ширина ліній
        }

        private void PlotPoints() //Розміщення точок на полігоні
        {
            for (int i = 0; i < PointCount; i++)
            {
                //Додаємо на канвас еліпси та їх центри 
                Canvas.SetLeft(EllipseArray[i], pC[i].X - Radius / 2);
                Canvas.SetTop(EllipseArray[i], pC[i].Y - Radius / 2);
                MyCanvas.Children.Add(EllipseArray[i]);
            }
        }

        private void PlotWay(int[] BestWayIndex) //Шлях між містами
        {
            PointCollection Points = new PointCollection(); //ініціалізація колекції точок

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
            InitPoints();
            InitPolygon();
        }

        private void OneStep(object sender, EventArgs e)
        {
            MyCanvas.Children.Clear();
            PlotPoints();
            PlotWay(GetBestWay(pC));
        }

        int start = 0;

        private int[] GetBestWay(PointCollection pC)
        {
            int[] way = new int[PointCount];
            Dictionary<int, double> LengthList = new Dictionary<int, double>();
            double l;

            for (int i = 0; i < PointCount; i++)
                way[i] = start % pC.Count;

            for (int i1 = 1; i1 < PointCount; i1++)
            {
                LengthList.Clear();
                for (int i2 = 0; i2 < PointCount; i2++)
                {
                    if (!way.Contains(i2))
                    {
                        l = Math.Sqrt(Math.Pow(pC[way[i1 - 1]].X - pC[i2].X, 2) + Math.Pow(pC[way[i1 - 1]].Y - pC[i2].Y, 2));
                        LengthList.Add(i2, l);
                    }
                }
                int i0 = LengthList.OrderBy(t => t.Value).First().Key;
                way[i1] = i0;
            }
            start++;
            return way;
        }
    }
}