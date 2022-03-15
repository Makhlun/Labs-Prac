
namespace Lab1
{
    partial class AboutCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCreator));
            this.label1 = new System.Windows.Forms.Label();
            this.Backing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "About Creator";
            // 
            // Backing
            // 
            this.Backing.BackColor = System.Drawing.Color.LavenderBlush;
            this.Backing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backing.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backing.Location = new System.Drawing.Point(525, 207);
            this.Backing.Name = "Backing";
            this.Backing.Size = new System.Drawing.Size(250, 95);
            this.Backing.TabIndex = 2;
            this.Backing.Text = "Back to Main Menu";
            this.Backing.UseVisualStyleBackColor = false;
            this.Backing.Click += new System.EventHandler(this.Backing_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Виконала студентка групи КП-12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Махлун Марія Олександрівна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "2022";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "М.";
            // 
            // AboutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(192)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(787, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Backing);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Creator";
            this.Load += new System.EventHandler(this.AboutCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

