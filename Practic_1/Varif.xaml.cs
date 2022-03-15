using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Practic
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Varification : Window
    {
        int countattempt = 0, N1, N2, N0;
        int countletters, counter = 0;
        double Mi, Si, S;
        List<double> Periods = new();
        List<double> MathInFile = new();
        List<double> MathTask = new();
        List<double> P = new();
        Stopwatch sw;
        TimeSpan ts;
        double t0, t1;
        const double Tt = 1.896, Fp = 2.36;
        public Varification()
        {
            InitializeComponent();
            sw = new Stopwatch();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            Close();
            mw.Show();
        }

        private void InputedTXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            t0 = 0;
            InputedTXT.IsEnabled = true;
            FileReading();
            switch (AttCount.SelectedIndex)
            {
                case 0:
                    PeriodsWrite(3);
                    break;
                case 1:
                    PeriodsWrite(4);
                    break;
                case 2:
                    PeriodsWrite(5);
                    break;
                case 3:
                    PeriodsWrite(6);
                    break;
                case 4:
                    PeriodsWrite(7);
                    break;
                default:
                    break;
            }
        }


        private void PeriodsWrite(int length)
        {
            sw.Start();
            char[] ourword = codeword.Content.ToString().ToCharArray();
            ts = sw.Elapsed;
            countletters = InputedTXT.Text.Length;
            Timing();
            if (countletters > 1 && (ourword[countletters - 1] != InputedTXT.Text[countletters - 1]))
            {
                MessageBox.Show("Попытка не защитана. Попробуйте ещё раз.", "Допущена ошибка в написании");
                Periods.Clear();
                InputedTXT.Text = "";
                t0 = 0;
            }
            if (countletters == codeword.Content.ToString().Length)
            {
                InputUniformity();
                Compare();
                Periods.Clear();
                InputedTXT.Text = "";
            }
            if (countattempt == length)
            {
                sw.Stop();
                InputedTXT.IsEnabled = false;
                OutputtingAll();
            }
        }
        private void Timing()
        {
            lc.Content = countletters;
            if (countletters > 0)
            {
                if (countletters < 9)
                {
                    t1 = ts.TotalSeconds;
                    Periods.Add(t1 - t0);
                    t0 = t1;
                }
                else
                {
                    sw.Restart();
                }
            }
            else t0 = ts.TotalSeconds;
        }
        private void MiSi()
        {
            double a = 0, b = 0;
            foreach (double el in Periods)
            {
                a += el;
            }
            Mi = a / Periods.Count;
            foreach (double el in Periods)
            {
                b += Math.Pow(el - Mi, 2);
            }
            Si = b / (Periods.Count - 1);
            MathTask.Add(Mi);
            MathTask.Add(Si);
        }
        private void InputUniformity()
        {
            double a = 0, b = 0;
            double Tp;

            for (int el = 0; el < Periods.Count; el++)
            {
                List<double> H = Periods;
                H.RemoveAt(el);
                foreach (double time in H)
                {
                    a += time;
                }
                Mi = a / H.Count;
                foreach (double time in H)
                {
                    b += Math.Pow(time - Mi, 2);
                }
                Si = b / (H.Count - 1);
                Tp = Math.Abs(el - Mi) / Math.Sqrt(Si / H.Count);
                if (Tp > Tt)
                {
                    Periods.RemoveAt(el);
                    el--;
                }
            }
            MiSi();
            countattempt++;
        }

        private StreamReader file;
        private void FileReading()
        {
            file = new("D:/Labs/Practic.txt");
            string[] massive = file.ReadLine().Split("   ");
            for (int i = 0; i < massive.Length; i++)
            {
                MathInFile.Add(Convert.ToDouble(massive[i]));
            }
            file.Close();
        }
        private void Compare()
        {
            int index = MathTask.Count - 1, r = 0;
            double Tp;
            for (int i = 1; i < MathInFile.Count; i += 2)
            {
                double Ft;
                Ft = Math.Max(MathTask[index], MathInFile[i]) / Math.Min(MathTask[index], MathInFile[i]);
                if (Ft <= Fp)
                    counter++;
                S = Math.Sqrt((MathInFile[i] + MathTask[index]) * 7 / 15);
                Tp = Math.Abs(MathInFile[i - 1] - MathTask[index - 1]) / (S * Math.Sqrt(1.0 / 4));
                if (Tp <= Tt)
                {
                    r++;
                    N2++;
                }
                else
                {
                    N1++;
                }
                N0++;
            }
            P.Add(r * 2.0 / MathInFile.Count);

        }
        private void OutputtingAll()
        {
            double f = 0;
            MessageBox.Show("Попытки закончились :(", "Упс...");
            mistake1.Content = Math.Round(1.0 * N1 / N0, 3).ToString();
            if (Athor.IsChecked==true)
                mistake2.Content = Math.Round(1.0 * N2 / N0, 3).ToString();
            foreach (double element in P)
            {
                f += element;
            }
            Pinditif.Content = Math.Round(1.0 * f / P.Count, 3).ToString();
            if (counter > (N0 / 2.0))
            {
                dispersii.Content = "однородні";
            }
            else dispersii.Content = "неоднородні";
        }
    }
}
