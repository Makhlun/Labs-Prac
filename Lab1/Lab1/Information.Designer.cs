
namespace Lab1
{
    partial class Information
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.Backing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Specialization = new System.Windows.Forms.ComboBox();
            this.IDdel = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Puples = new System.Windows.Forms.ListBox();
            this.FileAdd = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Backing
            // 
            this.Backing.BackColor = System.Drawing.Color.LavenderBlush;
            this.Backing.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Backing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backing.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backing.Location = new System.Drawing.Point(774, 343);
            this.Backing.Name = "Backing";
            this.Backing.Size = new System.Drawing.Size(250, 95);
            this.Backing.TabIndex = 0;
            this.Backing.Text = "Back to Main Menu";
            this.Backing.UseVisualStyleBackColor = false;
            this.Backing.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Specialization";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(30, 125);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(88, 34);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.NameTextBox.Location = new System.Drawing.Point(124, 125);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(154, 35);
            this.NameTextBox.TabIndex = 8;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.Surname.Location = new System.Drawing.Point(284, 124);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(167, 35);
            this.Surname.TabIndex = 9;
            // 
            // Sex
            // 
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.Sex.Location = new System.Drawing.Point(457, 123);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(108, 37);
            this.Sex.TabIndex = 10;
            // 
            // Specialization
            // 
            this.Specialization.BackColor = System.Drawing.SystemColors.Window;
            this.Specialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Specialization.FormattingEnabled = true;
            this.Specialization.Items.AddRange(new object[] {
            "121",
            "122",
            "123",
            "113",
            "125"});
            this.Specialization.Location = new System.Drawing.Point(571, 123);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(188, 37);
            this.Specialization.TabIndex = 11;
            // 
            // IDdel
            // 
            this.IDdel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.IDdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDdel.FormattingEnabled = true;
            this.IDdel.Location = new System.Drawing.Point(30, 177);
            this.IDdel.Name = "IDdel";
            this.IDdel.Size = new System.Drawing.Size(729, 37);
            this.IDdel.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(774, 178);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(250, 44);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Puples
            // 
            this.Puples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puples.FormattingEnabled = true;
            this.Puples.ItemHeight = 25;
            this.Puples.Location = new System.Drawing.Point(30, 234);
            this.Puples.Name = "Puples";
            this.Puples.Size = new System.Drawing.Size(729, 204);
            this.Puples.TabIndex = 19;
            // 
            // FileAdd
            // 
            this.FileAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FileAdd.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FileAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileAdd.Location = new System.Drawing.Point(774, 120);
            this.FileAdd.Name = "FileAdd";
            this.FileAdd.Size = new System.Drawing.Size(250, 42);
            this.FileAdd.TabIndex = 20;
            this.FileAdd.Text = "ADD";
            this.FileAdd.UseVisualStyleBackColor = false;
            this.FileAdd.Click += new System.EventHandler(this.FileAdd_Click);
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Show.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(774, 234);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(250, 50);
            this.Show.TabIndex = 25;
            this.Show.Text = "Show FILE";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1046, 451);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.FileAdd);
            this.Controls.Add(this.Puples);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.IDdel);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backing);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pupels";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Specialization;
        private System.Windows.Forms.ComboBox IDdel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox Puples;
        private System.Windows.Forms.Button FileAdd;
#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Button Show;
#pragma warning restore CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
    }
}

