using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class TicTacToe : Form
    {
        bool Who = true;
        bool WIN = false;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Backing_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            Hide();
            mm.Show();
        }

        private void TapAButton(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (Who)
            {
                B.Text = "X";
                Turn.Text = "O turn";
            }
            else
            {
                B.Text = "O";
                Turn.Text = "X turn";
            }
            Who = !Who;
            B.Enabled = false;
            WhoWin();
        }
        private void WhoWin()
        {
            //1 Raw
            if (c11.Text == c12.Text && c12.Text == c13.Text && c13.Text == c14.Text && !c11.Enabled)
            {
                c11.BackColor = c12.BackColor = c13.BackColor = c14.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c12.Text == c13.Text && c13.Text == c14.Text && c14.Text == c15.Text && !c12.Enabled)
            {
                c15.BackColor = c12.BackColor = c13.BackColor = c14.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //2 Raw
            else if (c21.Text == c22.Text && c22.Text == c23.Text && c23.Text == c24.Text && !c21.Enabled)
            {
                c21.BackColor = c22.BackColor = c23.BackColor = c24.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c22.Text == c23.Text && c23.Text == c24.Text && c24.Text == c25.Text && !c22.Enabled)
            {
                c25.BackColor = c22.BackColor = c23.BackColor = c24.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }
            //3 Raw
            else if (c31.Text == c32.Text && c32.Text == c33.Text && c33.Text == c34.Text && !c31.Enabled)
            {
                c31.BackColor = c32.BackColor = c33.BackColor = c34.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c32.Text == c33.Text && c33.Text == c34.Text && c34.Text == c35.Text && !c32.Enabled)
            {
                c35.BackColor = c32.BackColor = c33.BackColor = c34.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //4 Raw
            else if (c41.Text == c42.Text && c42.Text == c43.Text && c43.Text == c44.Text && !c41.Enabled)
            {
                c41.BackColor = c42.BackColor = c43.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c42.Text == c43.Text && c43.Text == c44.Text && c44.Text == c45.Text && !c42.Enabled)
            {
                c45.BackColor = c42.BackColor = c43.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //5 Raw
            else if (c51.Text == c52.Text && c52.Text == c53.Text && c53.Text == c54.Text && !c51.Enabled)
            {
                c51.BackColor = c52.BackColor = c53.BackColor = c54.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c52.Text == c53.Text && c53.Text == c54.Text && c54.Text == c55.Text && !c52.Enabled)
            {
                c55.BackColor = c52.BackColor = c53.BackColor = c54.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //1 Collumb
            else if (c11.Text == c21.Text && c21.Text == c31.Text && c31.Text == c41.Text && !c11.Enabled)
            {
                c21.BackColor = c11.BackColor = c31.BackColor = c41.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c21.Text == c31.Text && c31.Text == c41.Text && c41.Text == c51.Text && !c21.Enabled)
            {
                c51.BackColor = c21.BackColor = c31.BackColor = c41.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //2 Collumb
            else if (c12.Text == c22.Text && c22.Text == c32.Text && c32.Text == c42.Text && !c12.Enabled)
            {
                c12.BackColor = c22.BackColor = c32.BackColor = c42.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c22.Text == c32.Text && c32.Text == c42.Text && c42.Text == c52.Text && !c22.Enabled)
            {
                c52.BackColor = c22.BackColor = c32.BackColor = c42.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //3 Collumb
            else if (c13.Text == c23.Text && c23.Text == c33.Text && c33.Text == c43.Text && !c13.Enabled)
            {
                c13.BackColor = c23.BackColor = c33.BackColor = c43.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c23.Text == c33.Text && c33.Text == c43.Text && c43.Text == c53.Text && !c23.Enabled)
            {
                c53.BackColor = c23.BackColor = c33.BackColor = c43.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //4 Collumb
            else if (c14.Text == c24.Text && c24.Text == c34.Text && c34.Text == c44.Text && !c14.Enabled)
            {
                c14.BackColor = c24.BackColor = c34.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c24.Text == c34.Text && c34.Text == c44.Text && c44.Text == c54.Text && !c24.Enabled)
            {
                c54.BackColor = c24.BackColor = c34.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //5 Collumb
            else if (c15.Text == c25.Text && c25.Text == c35.Text && c35.Text == c45.Text && !c15.Enabled)
            {
                c15.BackColor = c25.BackColor = c35.BackColor = c45.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            else if (c25.Text == c35.Text && c35.Text == c45.Text && c45.Text == c55.Text && !c25.Enabled)
            {
                c55.BackColor = c25.BackColor = c35.BackColor = c45.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            // Horisontal 1
            else if (c14.Text == c23.Text && c23.Text == c32.Text && c32.Text == c41.Text && !c14.Enabled)
            {
                c14.BackColor = c23.BackColor = c32.BackColor = c41.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 1
            else if (c15.Text == c24.Text && c24.Text == c33.Text && c33.Text == c42.Text && !c15.Enabled)
            {
                c15.BackColor = c24.BackColor = c33.BackColor = c42.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 1
            else if (c51.Text == c24.Text && c24.Text == c33.Text && c33.Text == c42.Text && !c51.Enabled)
            {
                c51.BackColor = c24.BackColor = c33.BackColor = c42.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 1
            else if (c25.Text == c34.Text && c34.Text == c43.Text && c43.Text == c52.Text && !c25.Enabled)
            {
                c25.BackColor = c34.BackColor = c43.BackColor = c52.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            // Horisontal 2
            else if (c21.Text == c32.Text && c32.Text == c43.Text && c43.Text == c54.Text && !c21.Enabled)
            {
                c21.BackColor = c32.BackColor = c43.BackColor = c54.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 2
            else if (c11.Text == c22.Text && c22.Text == c33.Text && c33.Text == c44.Text && !c11.Enabled)
            {
                c11.BackColor = c22.BackColor = c33.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 2
            else if (c55.Text == c22.Text && c22.Text == c33.Text && c33.Text == c44.Text && !c55.Enabled)
            {
                c55.BackColor = c22.BackColor = c33.BackColor = c44.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            //Horisontal 2
            else if (c12.Text == c23.Text && c23.Text == c34.Text && c34.Text == c45.Text && !c12.Enabled)
            {
                c12.BackColor = c23.BackColor = c34.BackColor = c45.BackColor = System.Drawing.Color.Violet;
                If_Possible();
            }

            if (WIN)
            {
                switch (Who)
                {
                    case true:
                        WhoWinner.Text = "O WIN!";
                        return;
                    case false:
                        WhoWinner.Text = "X WIN!";
                        return;                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Who = true;
            Turn.Text = "X turn";
            GameRes.Text = ""; 
            WhoWinner.Text = "";

            // Restart colour
            c11.BackColor = c12.BackColor = c13.BackColor = c14.BackColor = c15.BackColor = System.Drawing.Color.LavenderBlush;
            c21.BackColor = c22.BackColor = c23.BackColor = c24.BackColor = c25.BackColor = System.Drawing.Color.LavenderBlush;
            c31.BackColor = c32.BackColor = c33.BackColor = c34.BackColor = c35.BackColor = System.Drawing.Color.LavenderBlush;
            c41.BackColor = c42.BackColor = c43.BackColor = c44.BackColor = c45.BackColor = System.Drawing.Color.LavenderBlush;
            c51.BackColor = c52.BackColor = c53.BackColor = c54.BackColor = c55.BackColor = System.Drawing.Color.LavenderBlush;

            //1x
            c11.Text = c12.Text = c13.Text = c14.Text = c15.Text = "";
            c11.Enabled = c12.Enabled = c13.Enabled = c14.Enabled = c15.Enabled = true;
            //2x
            c21.Text = c22.Text = c23.Text = c24.Text = c25.Text = "";
            c21.Enabled = c22.Enabled = c23.Enabled = c24.Enabled = c25.Enabled = true;
            //3x
            c31.Text = c32.Text = c33.Text = c34.Text = c35.Text = "";
            c31.Enabled = c32.Enabled = c33.Enabled = c34.Enabled = c35.Enabled = true;
            //4x
            c41.Text = c42.Text = c43.Text = c44.Text = c45.Text = "";
            c41.Enabled = c42.Enabled = c43.Enabled = c44.Enabled = c45.Enabled = true;
            //5x
            c51.Text = c52.Text = c53.Text = c54.Text = c55.Text = "";
            c51.Enabled = c52.Enabled = c53.Enabled = c54.Enabled = c55.Enabled = true;
        }
        public void If_Possible()
        {
            WIN = true;
            GameRes.Text = "Restart game\n\nOr back to \nMain Manu ";
            Turn.Text = "";

            c11.Enabled = c12.Enabled = c13.Enabled = c14.Enabled = c15.Enabled = false;
            c21.Enabled = c22.Enabled = c23.Enabled = c24.Enabled = c25.Enabled = false;
            c31.Enabled = c32.Enabled = c33.Enabled = c34.Enabled = c35.Enabled = false;
            c41.Enabled = c42.Enabled = c43.Enabled = c44.Enabled = c45.Enabled = false;
            c51.Enabled = c52.Enabled = c53.Enabled = c54.Enabled = c55.Enabled = false;
        }
    }
}
