using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Lab2
{
    class Calcul
    {
        Window window = new();
        Button[,] buttons = new Button[4, 5];
        TextBox tb;
        bool check = false;
        Func<double, double, double> does;
        double num1, num2;

        public void Calculator()
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            window.Title = "Calculator";
            window.ResizeMode = ResizeMode.NoResize;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = 550;
            window.Width = 370;
            Uri ic = new Uri("D:/Labs/icon.png");
            window.Icon = BitmapFrame.Create(ic);
            Grid grid = new();
            grid.Background = new SolidColorBrush(Color.FromRgb(238, 25, 255));
            Label name = new Label();
            name.Width = 290; name.Height = 55;
            name.FontSize = 36;
            name.HorizontalAlignment = HorizontalAlignment.Left;
            name.VerticalAlignment = VerticalAlignment.Top;
            name.Margin = new Thickness(12, 9, 0, 0);
            name.Content = "Calculator";
            name.FontFamily = new FontFamily("Segoe Script");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = buttons[i, j].Width = 55;
                    buttons[i, j].FontSize = 25;
                    buttons[i,j].FontFamily = new FontFamily("Segoe Script"); 
                    buttons[i, j].Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
                    buttons[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    buttons[i, j].VerticalAlignment = VerticalAlignment.Top;
                    buttons[i, j].Margin = new Thickness(25 + i * 60, 120 + j * 60, 0, 0);
                }
            }

            buttons[0, 0].Content = "C";
            buttons[0, 0].Click += DelAll_Click;
            buttons[1, 0].Content = "<=";
            buttons[1, 0].Click += delete_Click;
            buttons[2, 0].Content = "+-";
            buttons[2, 0].Click += ChangePlM;
            buttons[3, 0].Content = "/";
            buttons[3, 0].Click += Dooooooo;

            buttons[0, 1].Content = "7";
            buttons[1, 1].Content = "8";
            buttons[2, 1].Content = "9";
            buttons[3, 1].Content = "x";
            buttons[3, 1].Click += Dooooooo;

            buttons[0, 2].Content = "4";
            buttons[1, 2].Content = "5";
            buttons[2, 2].Content = "6";
            buttons[3, 2].Content = "-";
            buttons[3, 2].Click += Dooooooo;

            buttons[0, 3].Content = "1";
            buttons[1, 3].Content = "2";
            buttons[2, 3].Content = "3";
            buttons[3, 3].Content = "+";
            buttons[3, 3].Click += Dooooooo;

            buttons[1, 4].Content = "0";
            buttons[1, 4].Click += Num_Click;
            buttons[2, 4].Content = ",";
            buttons[2, 4].Click += Num_Click;
            buttons[3, 4].Content = "=";
            buttons[3, 4].Click += result;

            for (int i = 0; i < 3; i++)
                for (int j = 1; j < 4; j++)
                    buttons[i, j].Click += Num_Click;

            tb = new();
            tb.Text = "0";
            tb.Width = 235;
            tb.Height = 40;
            tb.VerticalAlignment = VerticalAlignment.Top;
            tb.HorizontalAlignment = HorizontalAlignment.Left;
            tb.Margin = new Thickness(25, 70, 0, 0);
            tb.FontSize = 25;

            Button exitbtn = new();
            exitbtn.Content = "Back";
            exitbtn.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            exitbtn.FontSize = 36;
            exitbtn.Height = 63;
            exitbtn.Width = 90;
            exitbtn.HorizontalAlignment = HorizontalAlignment.Left;
            exitbtn.VerticalAlignment = VerticalAlignment.Top;
            exitbtn.Margin = new Thickness(250, 437, 0, 0);
            grid.Children.Add(exitbtn);
            grid.Children.Add(name);

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 5; j++)
                {
                    grid.Children.Add(buttons[i, j]);
                }
            grid.Children.Remove(buttons[0, 4]);
            grid.Children.Add(tb);
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
        private void ChangePlM(object sender, RoutedEventArgs e)
        {
            tb.Text = (-1 * Convert.ToDouble(tb.Text)).ToString();
        }
        private void Num_Click(object sender, EventArgs e)
        {
            Button N = (Button)sender;
            if (tb.Text == "0" || check)
            {
                tb.Clear();
            }
            check = false;
            if (tb.Text == ",")
                tb.Text = "0,";
            if (N.Content.ToString() == ",")
            {
                if (!tb.Text.Contains(","))
                    tb.Text += N.Content;
            }
            else tb.Text += N.Content.ToString();
        }
        private void DelAll_Click(object sender, EventArgs e)
        {
            tb.Text = null;
            does = null;
            tb.Text = "0";
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (tb.Text.Length != 1)
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            else tb.Text = "0";
        }
        private void Dooooooo(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ("+-x/".Contains(tb.Text.Last()))
            {
                return;
            }


            if (does == null)
            {
                doessetter(b.Content.ToString());
                num1 = double.Parse(tb.Text);
            }
            else
            {
                num2 = double.Parse(tb.Text.Split(new char[] { '+', '-', 'x', '/' }, StringSplitOptions.RemoveEmptyEntries)[1]);

                num1 = does(num1, num2);
                tb.Text = num1.ToString();
            }

            doessetter(b.Content.ToString());
            tb.Text += b.Content.ToString();
        }

        private void result(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num2 = Double.Parse(tb.Text.Split(new char[] { '+', '-', 'x', '/' }, StringSplitOptions.RemoveEmptyEntries)[1]);
            tb.Text = does.Invoke(num1, num2).ToString();
            does = null;
        }

        private void doessetter(string c)
        {
            switch (c)
            {
                case "+":
                    does = (a, b) => a + b;
                    break;
                case "-":
                    does = (a, b) => a - b;
                    break;
                case "x":
                    does = (a, b) => a * b;
                    break;
                case "/":
                    does = (a, b) => a / b;
                    break;
            }
        }
    }
}
