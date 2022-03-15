using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Lab1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Выход
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Крестики нолики
            TicTacToe ttt = new TicTacToe();
            Hide();
            ttt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Калькулятор
            Calculator c = new Calculator();
            Hide();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Про меня
            AboutMe ac = new AboutMe();
            Hide();
            ac.Show();
        }

        private void Information_Click(object sender, EventArgs e)
        {
            // Информация 
            Information inf = new Information();
            Hide();
            inf.Show();
        }
    }
}
