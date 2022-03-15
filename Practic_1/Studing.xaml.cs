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
    public partial class Training : Window
    {
        int countattempt = 0;
        int countletters;
        double Mi, Si;
        List<double> Periods = new();
        List<double> MathTask = new();
        Stopwatch sw;
        TimeSpan ts;
        double t0, t1;
        const double Tt = 1.896;
        public Training()
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            t0 = 0;
            InputedTXT.IsEnabled = true;
            switch (AttampCount.SelectedIndex)
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
            NumAttemp.Content = countattempt.ToString();
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
                Periods.Clear();
                InputedTXT.Text = "";
            }
            if (countattempt == length)
            {
                sw.Stop();
                InputedTXT.IsEnabled = false;
                FileAdding();
                MessageBox.Show("Обучение пройдено!", "Вы допущены на проверочное испытание!");
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

        private StreamWriter file;
        private void FileAdding()
        {
            file = new("D:/Labs/Practic.txt");
            foreach (double el in MathTask)
            {
                if (el != MathTask[MathTask.Count - 1])
                    file.Write(el + "   ");
                else file.Write(el);
            }
            file.Close();
        }
    }
}
