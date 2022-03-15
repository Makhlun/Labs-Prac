
namespace Lab1
{
    partial class AboutMe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            this.Backing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.describing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Backing
            // 
            this.Backing.BackColor = System.Drawing.Color.LavenderBlush;
            this.Backing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backing.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backing.Location = new System.Drawing.Point(615, 218);
            this.Backing.Name = "Backing";
            this.Backing.Size = new System.Drawing.Size(250, 95);
            this.Backing.TabIndex = 2;
            this.Backing.Text = "Back to Main Menu";
            this.Backing.UseVisualStyleBackColor = false;
            this.Backing.Click += new System.EventHandler(this.Backing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "About Creator";
            // 
            // describing
            // 
            this.describing.AutoSize = true;
            this.describing.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describing.Location = new System.Drawing.Point(12, 71);
            this.describing.Name = "describing";
            this.describing.Size = new System.Drawing.Size(788, 63);
            this.describing.TabIndex = 4;
            this.describing.Text = "Виконала студентка групи КП-12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "Махлун Марія Олександрівна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "2022";
            // 
            // AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(877, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.describing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label describing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}