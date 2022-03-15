using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lab2
{
    class TicToe
    {
        Window window = new();
        bool Who = true;
        bool WIN = false;
        Label whoesturn = new();
        Label winner = new();

        Button[,] xo = new Button[5, 5];

        public void TicToeShow()
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            window.Title = "Крестики-нолики";
            window.ResizeMode = ResizeMode.NoResize;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = 500;
            window.Width = 600;
            Uri ic = new Uri("D:/Labs/icon.png");
            window.Icon = BitmapFrame.Create(ic);
            Grid grid = new();
            grid.Background = new SolidColorBrush(Color.FromRgb(238, 25, 255));
            Label ttt = new();

            winner.Content = "";
            winner.FontSize = 36;
            winner.Height = 52;
            winner.Width = 315;
            winner.FontFamily = new FontFamily("Segoe Script");
            winner.HorizontalAlignment = HorizontalAlignment.Left;
            winner.VerticalAlignment = VerticalAlignment.Top;
            winner.Margin = new Thickness(420, 130, 0, 0);

            ttt.Content = "Tic-Toc-Toe";
            ttt.FontSize = 40;
            ttt.FontFamily = new FontFamily("Segoe Script");
            ttt.Height = 60;
            ttt.Width = 315;
            ttt.HorizontalAlignment = HorizontalAlignment.Left;
            ttt.VerticalAlignment = VerticalAlignment.Top;
            ttt.Margin = new Thickness(10, 10, 0, 0);

            whoesturn.Content = "X turn";
            whoesturn.FontFamily = new FontFamily("Segoe Script");
            whoesturn.FontSize = 34;
            whoesturn.Height = 60;
            whoesturn.Width = 150;
            whoesturn.HorizontalAlignment = HorizontalAlignment.Left;
            whoesturn.VerticalAlignment = VerticalAlignment.Top;
            whoesturn.Margin = new Thickness(90, 75, 0, 0);

            grid.Children.Add(ttt);
            grid.Children.Add(whoesturn);
            grid.Children.Add(winner);


            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    xo[i, j] = new Button();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    xo[i, j].Width = 55;
                    xo[i, j].Height = 55;
                    xo[i, j].FontSize = 30;
                    xo[i,j].FontFamily = new FontFamily("Segoe Script");
                    xo[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    xo[i, j].VerticalAlignment = VerticalAlignment.Top;
                    xo[i, j].Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
                    xo[i, j].Margin = new Thickness(60 + i * 58, 128 + j * 58, 0, 0);
                }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    xo[i, j].Click += btnClick;
                    grid.Children.Add(xo[i, j]);
                }
            }

            Button exitbtn = new();
            Button Restart = new();

            Restart.Content = "Restart";
            Restart.FontFamily = new FontFamily("Segoe Script");
            Restart.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            Restart.FontSize = 36;
            Restart.Height = 63;
            Restart.Width = 140;
            Restart.HorizontalAlignment = HorizontalAlignment.Left;
            Restart.VerticalAlignment = VerticalAlignment.Top;
            Restart.Margin = new Thickness(420, 315, 0, 0);

            exitbtn.Content = "Back";
            exitbtn.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            exitbtn.FontSize = 36;
            exitbtn.Height = 63;
            exitbtn.Width = 120;
            exitbtn.HorizontalAlignment = HorizontalAlignment.Left;
            exitbtn.VerticalAlignment = VerticalAlignment.Top;
            exitbtn.Margin = new Thickness(440, 390, 0, 0);
            grid.Children.Add(exitbtn);
            grid.Children.Add(Restart);
            exitbtn.Click += exit_Click;
            Restart.Click += Restart_Click;
            window.Content = grid;
            window.Show();
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            window.Close();
        }
        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (Who)
            {
                b.Content = "X";
                whoesturn.Content = "O turn";
            }
            else
            {
                b.Content = "O";
                whoesturn.Content = "X turn";
            }
            Who = !Who;
            b.IsEnabled = false;
            WhoWin();
        }
        private void WhoWin()
        {
            // Ряд 0
            if (xo[0, 0].Content == xo[0, 1].Content && xo[0, 1].Content == xo[0, 2].Content && xo[0, 2].Content == xo[0, 3].Content && !xo[0, 0].IsEnabled)
            {
                //xo[0, 0].Background = xo[0, 1].Background = xo[0, 2].Background = xo[0, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[0, 4].Content == xo[0, 1].Content && xo[0, 1].Content == xo[0, 2].Content && xo[0, 2].Content == xo[0, 3].Content && !xo[0, 1].IsEnabled)
            {
                // xo[0, 4].Background = xo[0, 1].Background = xo[0, 2].Background = xo[0, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            // Ряд 1
            else if (xo[1, 0].Content == xo[1, 1].Content && xo[1, 1].Content == xo[1, 2].Content && xo[1, 2].Content == xo[1, 3].Content && !xo[1, 0].IsEnabled)
            {
                //xo[1, 0].Background = xo[1, 1].Background = xo[1, 2].Background = xo[1, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[1, 4].Content == xo[1, 1].Content && xo[1, 1].Content == xo[1, 2].Content && xo[1, 2].Content == xo[1, 3].Content && !xo[1, 1].IsEnabled)
            {
                //  xo[1, 4].Background = xo[1, 1].Background = xo[1, 2].Background = xo[1, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            // Ряд 2
            else if (xo[2, 0].Content == xo[2, 1].Content && xo[2, 1].Content == xo[2, 2].Content && xo[2, 2].Content == xo[2, 3].Content && !xo[2, 0].IsEnabled)
            {
                //  xo[2, 0].Background = xo[2, 1].Background = xo[2, 2].Background = xo[2, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[2, 4].Content == xo[2, 1].Content && xo[2, 1].Content == xo[2, 2].Content && xo[2, 2].Content == xo[2, 3].Content && !xo[2, 1].IsEnabled)
            {
                // xo[2, 4].Background = xo[2, 1].Background = xo[2, 2].Background = xo[2, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            // Ряд 3
            else if (xo[3, 0].Content == xo[3, 1].Content && xo[3, 1].Content == xo[3, 2].Content && xo[3, 2].Content == xo[3, 3].Content && !xo[3, 0].IsEnabled)
            {
                //xo[3, 0].Background = xo[3, 1].Background = xo[3, 2].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[3, 4].Content == xo[3, 1].Content && xo[3, 1].Content == xo[3, 2].Content && xo[3, 2].Content == xo[3, 3].Content && !xo[3, 1].IsEnabled)
            {
                //xo[3, 4].Background = xo[3, 1].Background = xo[3, 2].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            // Ряд 4
            else if (xo[4, 0].Content == xo[4, 1].Content && xo[4, 1].Content == xo[4, 2].Content && xo[4, 2].Content == xo[4, 3].Content && !xo[4, 0].IsEnabled)
            {
                // xo[4, 0].Background = xo[4, 1].Background = xo[4, 2].Background = xo[4, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 4].Content == xo[4, 1].Content && xo[4, 1].Content == xo[4, 2].Content && xo[4, 2].Content == xo[4, 3].Content && !xo[4, 1].IsEnabled)
            {
                //  xo[4, 4].Background = xo[4, 1].Background = xo[4, 2].Background = xo[4, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Столбец 0
            else if (xo[0, 0].Content == xo[1, 0].Content && xo[1, 0].Content == xo[2, 0].Content && xo[2, 0].Content == xo[3, 0].Content && !xo[0, 0].IsEnabled)
            {
                //xo[0, 0].Background = xo[1, 0].Background = xo[2, 0].Background = xo[3, 0].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 0].Content == xo[1, 0].Content && xo[1, 0].Content == xo[2, 0].Content && xo[2, 0].Content == xo[3, 0].Content && !xo[4, 0].IsEnabled)
            {
                //xo[0, 0].Background = xo[1, 0].Background = xo[2, 0].Background = xo[3, 0].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Столбец 1
            else if (xo[0, 1].Content == xo[1, 1].Content && xo[1, 1].Content == xo[2, 1].Content && xo[2, 0].Content == xo[3, 1].Content && !xo[0, 1].IsEnabled)
            {
                // xo[0, 1].Background = xo[1, 1].Background = xo[2, 1].Background = xo[3, 1].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 1].Content == xo[1, 1].Content && xo[1, 1].Content == xo[2, 1].Content && xo[2, 1].Content == xo[3, 1].Content && !xo[4, 1].IsEnabled)
            {
                //  xo[4, 1].Background = xo[1, 1].Background = xo[2, 1].Background = xo[3, 1].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Столбец 2
            else if (xo[0, 2].Content == xo[1, 2].Content && xo[1, 2].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 2].Content && !xo[0, 2].IsEnabled)
            {
                // xo[0, 2].Background = xo[1, 2].Background = xo[2, 2].Background = xo[3, 2].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 2].Content == xo[1, 2].Content && xo[1, 2].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 2].Content && !xo[4, 2].IsEnabled)
            {
                //  xo[4, 2].Background = xo[1, 2].Background = xo[2, 2].Background = xo[3, 2].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Столбец 3
            else if (xo[0, 3].Content == xo[1, 3].Content && xo[1, 3].Content == xo[2, 3].Content && xo[2, 3].Content == xo[3, 3].Content && !xo[0, 3].IsEnabled)
            {
                //   xo[0, 3].Background = xo[1, 3].Background = xo[2, 3].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 3].Content == xo[1, 3].Content && xo[1, 3].Content == xo[2, 3].Content && xo[2, 3].Content == xo[3, 3].Content && !xo[4, 3].IsEnabled)
            {
                // xo[4, 3].Background = xo[1, 3].Background = xo[2, 3].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Столбец 4
            else if (xo[0, 4].Content == xo[1, 4].Content && xo[1, 4].Content == xo[2, 4].Content && xo[2, 4].Content == xo[3, 4].Content && !xo[0, 4].IsEnabled)
            {
                //  xo[0, 4].Background = xo[1, 4].Background = xo[2, 4].Background = xo[3, 4].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[4, 4].Content == xo[1, 4].Content && xo[1, 4].Content == xo[2, 4].Content && xo[2, 4].Content == xo[3, 4].Content && !xo[4, 4].IsEnabled)
            {
                //   xo[4, 4].Background = xo[1, 4].Background = xo[2, 4].Background = xo[3, 4].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Наискось \1

            else if (xo[1, 0].Content == xo[2, 1].Content && xo[2, 1].Content == xo[3, 2].Content && xo[3, 2].Content == xo[4, 3].Content && !xo[4, 3].IsEnabled)
            {
                //  xo[1, 0].Background = xo[2, 1].Background = xo[3, 2].Background = xo[4, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[0, 1].Content == xo[1, 2].Content && xo[1, 2].Content == xo[2, 3].Content && xo[2, 3].Content == xo[3, 4].Content && !xo[3, 4].IsEnabled)
            {
                //  xo[0, 1].Background = xo[1, 2].Background = xo[3, 4].Background = xo[2, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Наискось \2
            else if (xo[0, 0].Content == xo[1, 1].Content && xo[1, 1].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 3].Content && !xo[3, 3].IsEnabled)
            {
                //  xo[0, 0].Background = xo[1, 1].Background = xo[2, 2].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[1, 1].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 3].Content && xo[3, 3].Content == xo[4, 4].Content && !xo[4, 4].IsEnabled)
            {
                //  xo[1, 1].Background = xo[2, 2].Background = xo[4, 4].Background = xo[3, 3].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Наискось /1
            else if (xo[0, 3].Content == xo[1, 2].Content && xo[1, 2].Content == xo[2, 1].Content && xo[2, 1].Content == xo[3, 0].Content && !xo[3, 0].IsEnabled)
            {
                //  xo[0, 3].Background = xo[1, 2].Background = xo[2, 1].Background = xo[3, 0].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[1, 4].Content == xo[2, 3].Content && xo[2, 3].Content == xo[3, 2].Content && xo[3, 2].Content == xo[4, 1].Content && !xo[4, 1].IsEnabled)
            {
                //xo[1, 4].Background = xo[2, 3].Background = xo[4, 1].Background = xo[3, 2].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            //Наискось /2
            else if (xo[0, 4].Content == xo[1, 3].Content && xo[1, 3].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 1].Content && !xo[3, 1].IsEnabled)
            {
                //  xo[0, 4].Background = xo[1, 3].Background = xo[2, 2].Background = xo[3, 1].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }
            else if (xo[1, 3].Content == xo[2, 2].Content && xo[2, 2].Content == xo[3, 1].Content && xo[3, 1].Content == xo[4, 0].Content && !xo[4, 0].IsEnabled)
            {
                // xo[1, 3].Background = xo[2, 3].Background = xo[3, 1].Background = xo[4, 0].Background = new SolidColorBrush(Color.FromRgb(201, 73, 212));
                If_Possible();
            }

            if (WIN)
            {
                switch (Who)
                {
                    case true:
                        winner.Content = "O WIN!";
                        return;
                    case false:
                        winner.Content = "X WIN!";
                        return;
                }
            }
        }
        private void If_Possible()
        {
            WIN = true;
            whoesturn.Content = "";

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    xo[i, j].IsEnabled = false;
                }
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Who = true;
            WIN = false;
            whoesturn.Content = "X turn";
            winner.Content = "";
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    xo[i, j].IsEnabled = true;
                    xo[i, j].Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
                    xo[i, j].Content = "";
                }
        }
    }
}
