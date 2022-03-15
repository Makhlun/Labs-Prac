using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            Hide();
            mm.Show();
        }

        private void FileAdd_Click(object sender, EventArgs e)
        {
            if (ID.TextLength == 0 || NameTextBox.TextLength == 0 || Surname.TextLength == 0 || Sex.Text == null || Specialization.Text == null)
                MessageBox.Show("You have not added all the items. \nUnable to add student.", "Can not add!");
            else
            {
                if (ID.Text.Length < 5)
                {
                    while (ID.Text.Length != 5)
                        ID.Text = "0" + ID.Text;
                }
                try
                {
                    File = new StreamWriter("D:/Labs/Base.txt");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Mistake!");
                    return;
                }
                Adding();
                File.Close();
                ID.Text = null;
                NameTextBox.Text = null;
                Surname.Text = null;
                Sex.Text = null;
                Specialization.Text = null;
                ID.Enabled = true;

            }
        }

        public StreamWriter File;

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

        private void Show_Click(object sender, EventArgs e)
        {
            string getfile = "D:/Labs/Base.txt";
            Process.Start(getfile);
        }

        private List<Base> students = new List<Base>();

        private void Adding()
        {
            students.Add(new Base(ID.Text, NameTextBox.Text, Surname.Text, Sex.Text, Specialization.Text));

            RemoveT();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            students.RemoveAt(IDdel.SelectedIndex);
            RemoveT();
        }
        private void RemoveT()
        {
            IDdel.Items.Clear();
            Puples.Items.Clear();

            foreach (Base S in students)
            {
                Puples.Items.Add(S.getID() + ":  " + S.getName() + "  " + S.getSurname() + " - " + S.getSex() + " - " + S.getSpecialization() + ";");
                IDdel.Items.Add(S.getID() + ":  " + S.getName() + "  " + S.getSurname() + " - " + S.getSex() + " - " + S.getSpecialization() + ";");
            }
            foreach (object a in Puples.Items)
                File.WriteLine(a.ToString());
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (ID.Text.Length == 5) ID.Enabled = false;
            foreach (var el in students)
            {
                if (el.getID() == ID.Text) ID.Text = (Convert.ToInt32(ID.Text) + 1).ToString();
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }
    }
}
