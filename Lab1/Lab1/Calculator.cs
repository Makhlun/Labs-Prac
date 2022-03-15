using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        Double number = 0;
        String Operation_meaning = "";
        bool check = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Backing_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            Hide();
            mm.Show();
        }

        private void N1_Click(object sender, EventArgs e)
        {
            Button N = (Button)sender;
            if (Res.Text == "0" || check)
            {
                Res.Clear();
            }
            check = false;
            if (Res.Text == ",")
                Res.Text = "0,";
            if (N.Text == ",")
            {
                if (!Res.Text.Contains(","))
                    Res.Text += N.Text;
            }
            else Res.Text += N.Text;
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            Res.Text = "0";
        }

        private void Operation(object sender, EventArgs e)
        {
            Button N = (Button)sender;
            if (number != 0)
            {
                result.PerformClick();
                Operation_meaning = N.Text;
                Res.Text += Operation_meaning;
                check = true;
            }
            else
            {
                number = Double.Parse(Res.Text);
                Operation_meaning = N.Text;
                Res.Text += Operation_meaning;
                check = true;
            }

        }

        private void result_Click(object sender, EventArgs e)
        {

            switch (Operation_meaning)
            {
                case "+":
                    Res.Text = (number + Double.Parse(Res.Text)).ToString();
                    break;
                case "-":
                    Res.Text = (number - Double.Parse(Res.Text)).ToString();
                    break;
                case "*":
                    Res.Text = (number * Double.Parse(Res.Text)).ToString();
                    break;
                case "/":
                    Res.Text = (number / Double.Parse(Res.Text)).ToString();
                    break;
                default:
                    break;
            }
            number = Double.Parse(Res.Text);
            Operation_meaning = "";
            check = true;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (Res.Text.Length != 1)
                Res.Text = Res.Text.Remove(Res.Text.Length - 1);
            else Res.Text = "0";
        }

        private void ChangePlM(object sender, EventArgs e)
        {
            Res.Text = (-1* Double.Parse(Res.Text)).ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}