
namespace Lab1
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если упавляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Information = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.TicTacToe = new System.Windows.Forms.Button();
            this.Calculator = new System.Windows.Forms.Button();
            this.AboutCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Information.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Information.Location = new System.Drawing.Point(449, 84);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(188, 77);
            this.Information.TabIndex = 1;
            this.Information.Text = "Information";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click a button ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(12, 335);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(223, 103);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // TicTacToe
            // 
            this.TicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TicTacToe.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToe.ForeColor = System.Drawing.Color.MediumOrchid;
            this.TicTacToe.Location = new System.Drawing.Point(318, 204);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(188, 77);
            this.TicTacToe.TabIndex = 2;
            this.TicTacToe.Text = "tic-tac-toy";
            this.TicTacToe.UseVisualStyleBackColor = true;
            this.TicTacToe.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculator.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Calculator.Location = new System.Drawing.Point(553, 204);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(188, 77);
            this.Calculator.TabIndex = 3;
            this.Calculator.Text = "Calculator";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.button3_Click);
            // 
            // AboutCreator
            // 
            this.AboutCreator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AboutCreator.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutCreator.ForeColor = System.Drawing.Color.MediumOrchid;
            this.AboutCreator.Location = new System.Drawing.Point(449, 318);
            this.AboutCreator.Name = "AboutCreator";
            this.AboutCreator.Size = new System.Drawing.Size(188, 99);
            this.AboutCreator.TabIndex = 4;
            this.AboutCreator.Text = "About creator";
            this.AboutCreator.UseVisualStyleBackColor = true;
            this.AboutCreator.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lab1.Properties.Resources.icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(771, 453);
            this.Controls.Add(this.AboutCreator);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.TicTacToe);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Information);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button TicTacToe;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button AboutCreator;
    }
}

