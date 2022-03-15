using System.IO;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Lab2
{
    class Infoo
    {
        Window window = new();
        TextBox id, name, surname;
        ComboBox pol, spec, iddel;
        ListBox st;
        Button del, add, f;
        public void Info()
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            window.Title = "Про студентиков";
            window.ResizeMode = ResizeMode.NoResize;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = 450;
            window.Width = 900;
            Uri ic = new Uri("D:/Labs/icon.png");
            window.Icon = BitmapFrame.Create(ic);
            Grid grid = new();
            grid.Background = new SolidColorBrush(Color.FromRgb(238, 25, 255));
            Label[] lbl = new Label[6];

            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i] = new Label();
            }
            lbl[0].Content = "Information";
            lbl[1].Content = "ID";
            lbl[2].Content = "Имя";
            lbl[3].Content = "Фамилия";
            lbl[4].Content = "Пол";
            lbl[5].Content = "Спеца";
            lbl[0].FontSize = 30;
            for (int i = 1; i < lbl.Length; i++)
            {
                lbl[i].FontSize = 25;
            }
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].HorizontalAlignment = HorizontalAlignment.Left;
                lbl[i].VerticalAlignment = VerticalAlignment.Top;
                lbl[i].FontFamily = new FontFamily("Segoe Script");
            }

            lbl[0].Height = 52;
            lbl[0].Width = 340;
            lbl[1].Height = 40;
            lbl[1].Width = 40;
            lbl[2].Height = 40;
            lbl[2].Width = 140;
            lbl[3].Height = 40;
            lbl[3].Width = 170;
            lbl[4].Height = 40;
            lbl[4].Width = 65;
            lbl[5].Height = 40;
            lbl[5].Width = 100;

            lbl[0].Margin = new Thickness(12, 9, 0, 0);
            lbl[1].Margin = new Thickness(25, 55, 0, 0);
            lbl[2].Margin = new Thickness(115, 55, 0, 0);
            lbl[3].Margin = new Thickness(290, 55, 0, 0);
            lbl[4].Margin = new Thickness(485, 55, 0, 0);
            lbl[5].Margin = new Thickness(570, 55, 0, 0);

           
            Button exitbtn = new();
            exitbtn.Content = "Back";
            exitbtn.FontFamily = new FontFamily("Segoe Script");
            exitbtn.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            exitbtn.FontSize = 36;
            exitbtn.Height = 63;
            exitbtn.Width = 120;
            exitbtn.HorizontalAlignment = HorizontalAlignment.Left;
            exitbtn.VerticalAlignment = VerticalAlignment.Top;
            exitbtn.Margin = new Thickness(760, 340, 0, 0);

            id = new();
            name = new();
            surname = new();

            id.FontSize = name.FontSize = surname.FontSize = 20;
            id.Height = name.Height = surname.Height = 35;
            id.Width = 90;
            name.Width = 150;
            surname.Width = 190;

            id.HorizontalAlignment = HorizontalAlignment.Left; id.VerticalAlignment = VerticalAlignment.Top;
            name.HorizontalAlignment = HorizontalAlignment.Left; name.VerticalAlignment = VerticalAlignment.Top;
            surname.HorizontalAlignment = HorizontalAlignment.Left; surname.VerticalAlignment = VerticalAlignment.Top;

            id.Margin = new Thickness(20, 100, 0, 0);
            name.Margin = new Thickness(120, 100, 0, 0);
            surname.Margin = new Thickness(280, 100, 0, 0);

            pol = new();
            spec = new();
            iddel = new();

            pol.FontSize = spec.FontSize = iddel.FontSize = 25;
            pol.Height = spec.Height = iddel.Height = 35;
            pol.Width = 80;
            spec.Width = 85;
            iddel.Width = 175;
            pol.HorizontalAlignment = spec.HorizontalAlignment = iddel.HorizontalAlignment = HorizontalAlignment.Left;
            pol.VerticalAlignment = spec.VerticalAlignment = iddel.VerticalAlignment = VerticalAlignment.Top;
            pol.Margin = new Thickness(480, 100, 0, 0);
            spec.Margin = new Thickness(570, 100, 0, 0);
            iddel.Margin = new Thickness(480, 145, 0, 0);

            pol.Items.Add("m");
            pol.Items.Add("w");

            spec.Items.Add("113");
            spec.Items.Add("121");
            spec.Items.Add("123");

            st = new();
            st.Width = 635;
            st.Height = 200;
            st.HorizontalAlignment = HorizontalAlignment.Left;
            st.VerticalAlignment = VerticalAlignment.Top;
            st.Margin = new Thickness(20, 190, 0, 0);

            add = new();
            del = new();
            f = new();
            add.Width = del.Width = f.Width = 150;
            add.Height = del.Height = del.Height = 35;
            add.Content = "ADD";
            add.FontFamily = del.FontFamily = f.FontFamily = new FontFamily("Segoe Script");
            del.Content = "DELETE";
            f.Content = "SHOW File";
            
            del.Click += Delete_Click;
            add.Click += Add_Click;
            f.Click += Show_Click;
            add.FontSize = del.FontSize = f.FontSize = 25;
            f.Background = add.Background = del.Background = new SolidColorBrush(Color.FromRgb(249, 175, 255));
            add.HorizontalAlignment = del.HorizontalAlignment = f.HorizontalAlignment = HorizontalAlignment.Left;
            add.VerticalAlignment = del.VerticalAlignment = f.VerticalAlignment = VerticalAlignment.Top;
            add.Margin = new Thickness(665, 100, 0, 0);
            del.Margin = new Thickness(665, 145, 0, 0);
            f.Margin = new Thickness(665, 190, 0, 0);
            st.FontFamily = new FontFamily("Segoe Script");
            id.FontFamily= name.FontFamily =surname.FontFamily = new FontFamily("Segoe Script");
            grid.Children.Add(exitbtn);
            for (int i = 0; i < lbl.Length; i++)
            {
                grid.Children.Add(lbl[i]);
            }
            exitbtn.Click += exit_Click;
            grid.Children.Add(name);
            grid.Children.Add(id);
            grid.Children.Add(surname);
            grid.Children.Add(pol);
            grid.Children.Add(spec);
            grid.Children.Add(st);
            grid.Children.Add(del);
            grid.Children.Add(add);
            grid.Children.Add(f);
            grid.Children.Add(iddel);
            window.Content = grid;
            window.Show();
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            window.Close();
        }

        public StreamWriter File;
        private List<Base> students = new List<Base>();
        struct Base
        {
            private string ID;
            private string Name;
            private string Surname;
            private string Sex;
            private string Specialization;
            public Base(string ID, string Name, string Surname, string Sex, string Specialization)
            {
                this.ID = ID;
                this.Name = Name;
                this.Surname = Surname;
                this.Sex = Sex;
                this.Specialization = Specialization;
            }
            public string getID() => ID;
            public string getName() => Name;
            public string getSurname() => Surname;
            public string getSex() => Sex;
            public string getSpecialization() => Specialization;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (id.Text.Length == 0 || name.Text.Length == 0 || surname.Text.Length == 0 || pol.Text == null || spec.Text == null)
                MessageBox.Show("You have not added all the items. \nUnable to add student.", "Can not add!");
            else
            {
                if (id.Text.Length < 5)
                {
                    if (id.Text.Length == 5) id.IsEnabled = false;
                    while (id.Text.Length != 5)
                        id.Text = "0" + id.Text;
                    foreach (var el in students)
                    {
                        while (el.getID() == id.Text)
                        {
                            id.Text = (Convert.ToInt32(id.Text) + 1).ToString();
                        }
                        while (id.Text.Length != 5)
                            id.Text = "0" + id.Text;
                    }
                }

                Adding();
                
                id.Text = null;
                name.Text = null;
                surname.Text = null;
                pol.Text = null;
                spec.Text = null;
                id.IsEnabled = true;

            }
        }
        StreamReader FF;
        private void Show_Click(object sender, EventArgs e)
        {
            FF = new StreamReader("D:/Labs/Base.txt");
            Window File = new();
            File.Content = FF.ReadToEnd();
            File.Show();

        }
        private void RemoveT()
        {
            File = new StreamWriter("D:/Labs/Base.txt");
            iddel.Items.Clear();
            st.Items.Clear();
            foreach (Base S in students)
            {
                st.Items.Add(S.getID() + ":  " + S.getName() + "  " + S.getSurname() + " - " + S.getSex() + " - " + S.getSpecialization() + ";");
                iddel.Items.Add(S.getID());
            }
            foreach (object a in st.Items)
                File.WriteLine(a.ToString());
            File.Close();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            students.RemoveAt(iddel.SelectedIndex);
            RemoveT();
        }
        private void Adding()
        {
            students.Add(new Base(id.Text, name.Text, surname.Text, pol.Text, spec.Text)); 
            RemoveT();
        }
    }
}
