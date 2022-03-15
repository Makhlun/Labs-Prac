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

namespace Lab2
{
    class WhoIam
    {
        Window window = new();
        public void WIMWin()
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            window.Title = "Хто я?";
            window.ResizeMode = ResizeMode.NoResize;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = 325;
            window.Width = 650;
            Uri ic = new Uri("D:/Labs/icon.png");
            window.Icon = BitmapFrame.Create(ic);
            Grid grid = new(); 
            grid.Background = new SolidColorBrush(Color.FromRgb(238, 25, 255));
            Label[] lbl = new Label[4];

            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i] = new Label();
                lbl[i].FontFamily = new FontFamily("Segoe Script");
            }
            lbl[0].Content = "About Creator";
            lbl[1].Content = "Виконала студентка групи КП-12";
            lbl[2].Content = "Махлун Марія Олександрівна";
            lbl[3].Content = "2022";
            lbl[0].FontSize = 36;
            for (int i = 1; i < lbl.Length; i++)
            {
                lbl[i].FontSize = 30;
            }
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].HorizontalAlignment = HorizontalAlignment.Left;
                lbl[i].VerticalAlignment = VerticalAlignment.Top;
            }

            lbl[0].Height = 52;
            lbl[0].Width = 390;
            lbl[1].Height = 63;
            lbl[1].Width = 788;
            lbl[2].Height = 63;
            lbl[2].Width = 762;
            lbl[3].Height = 63;
            lbl[3].Width = 139;

            lbl[0].Margin = new Thickness(12, 9, 0, 0);
            lbl[1].Margin = new Thickness(12, 75, 0, 0);
            lbl[2].Margin = new Thickness(12, 135, 0, 0);
            lbl[3].Margin = new Thickness(25, 218, 0, 0);
            for (int i = 0; i < lbl.Length; i++)
            {
                grid.Children.Add(lbl[i]);
            }
            Button exitbtn = new();
            exitbtn.Content = "Back";
            exitbtn.FontFamily = new FontFamily("Segoe Script");
            exitbtn.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            exitbtn.FontSize = 36;
            exitbtn.Height = 63;
            exitbtn.Width = 120;
            exitbtn.HorizontalAlignment = HorizontalAlignment.Left;
            exitbtn.VerticalAlignment = VerticalAlignment.Top;
            exitbtn.Margin = new Thickness(450, 210, 0, 0);
            grid.Children.Add(exitbtn);
            exitbtn.Click += exit_Click;
            window.Content = grid;
            window.Show();
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            window.Close();
        }
    }
}
