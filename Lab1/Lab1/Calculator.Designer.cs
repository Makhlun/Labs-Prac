
namespace Lab1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.Backing = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.N0 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.N3 = new System.Windows.Forms.Button();
            this.N2 = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.N6 = new System.Windows.Forms.Button();
            this.N5 = new System.Windows.Forms.Button();
            this.N4 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.N9 = new System.Windows.Forms.Button();
            this.N8 = new System.Windows.Forms.Button();
            this.N7 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // Backing
            // 
            this.Backing.BackColor = System.Drawing.Color.LavenderBlush;
            this.Backing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backing.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backing.Location = new System.Drawing.Point(53, 477);
            this.Backing.Name = "Backing";
            this.Backing.Size = new System.Drawing.Size(250, 95);
            this.Backing.TabIndex = 1;
            this.Backing.Text = "Back to Main Menu";
            this.Backing.UseVisualStyleBackColor = false;
            this.Backing.Click += new System.EventHandler(this.Backing_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LavenderBlush;
            this.plus.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(249, 350);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(54, 55);
            this.plus.TabIndex = 51;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Operation);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LavenderBlush;
            this.result.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(249, 411);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(54, 55);
            this.result.TabIndex = 50;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // N0
            // 
            this.N0.BackColor = System.Drawing.Color.LavenderBlush;
            this.N0.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N0.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N0.Location = new System.Drawing.Point(129, 411);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(54, 55);
            this.N0.TabIndex = 49;
            this.N0.Text = "0";
            this.N0.UseVisualStyleBackColor = false;
            this.N0.Click += new System.EventHandler(this.N1_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.LavenderBlush;
            this.minus.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(249, 289);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(54, 55);
            this.minus.TabIndex = 46;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Operation);
            // 
            // N3
            // 
            this.N3.BackColor = System.Drawing.Color.LavenderBlush;
            this.N3.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N3.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3.Location = new System.Drawing.Point(189, 350);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(54, 55);
            this.N3.TabIndex = 45;
            this.N3.Text = "3";
            this.N3.UseVisualStyleBackColor = false;
            this.N3.Click += new System.EventHandler(this.N1_Click);
            // 
            // N2
            // 
            this.N2.BackColor = System.Drawing.Color.LavenderBlush;
            this.N2.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N2.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.Location = new System.Drawing.Point(129, 350);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(54, 55);
            this.N2.TabIndex = 44;
            this.N2.Text = "2";
            this.N2.UseVisualStyleBackColor = false;
            this.N2.Click += new System.EventHandler(this.N1_Click);
            // 
            // N1
            // 
            this.N1.BackColor = System.Drawing.Color.LavenderBlush;
            this.N1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.Location = new System.Drawing.Point(69, 350);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(54, 55);
            this.N1.TabIndex = 43;
            this.N1.Text = "1";
            this.N1.UseVisualStyleBackColor = false;
            this.N1.Click += new System.EventHandler(this.N1_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.LavenderBlush;
            this.multiply.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(249, 228);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(54, 55);
            this.multiply.TabIndex = 41;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Operation);
            // 
            // N6
            // 
            this.N6.BackColor = System.Drawing.Color.LavenderBlush;
            this.N6.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N6.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N6.Location = new System.Drawing.Point(189, 289);
            this.N6.Name = "N6";
            this.N6.Size = new System.Drawing.Size(54, 55);
            this.N6.TabIndex = 40;
            this.N6.Text = "6";
            this.N6.UseVisualStyleBackColor = false;
            this.N6.Click += new System.EventHandler(this.N1_Click);
            // 
            // N5
            // 
            this.N5.BackColor = System.Drawing.Color.LavenderBlush;
            this.N5.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N5.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N5.Location = new System.Drawing.Point(129, 289);
            this.N5.Name = "N5";
            this.N5.Size = new System.Drawing.Size(54, 55);
            this.N5.TabIndex = 39;
            this.N5.Text = "5";
            this.N5.UseVisualStyleBackColor = false;
            this.N5.Click += new System.EventHandler(this.N1_Click);
            // 
            // N4
            // 
            this.N4.BackColor = System.Drawing.Color.LavenderBlush;
            this.N4.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N4.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N4.Location = new System.Drawing.Point(69, 289);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(54, 55);
            this.N4.TabIndex = 38;
            this.N4.Text = "4";
            this.N4.UseVisualStyleBackColor = false;
            this.N4.Click += new System.EventHandler(this.N1_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.LavenderBlush;
            this.divide.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(249, 167);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(54, 55);
            this.divide.TabIndex = 36;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Operation);
            // 
            // N9
            // 
            this.N9.BackColor = System.Drawing.Color.LavenderBlush;
            this.N9.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N9.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N9.Location = new System.Drawing.Point(189, 228);
            this.N9.Name = "N9";
            this.N9.Size = new System.Drawing.Size(54, 55);
            this.N9.TabIndex = 35;
            this.N9.Text = "9";
            this.N9.UseVisualStyleBackColor = false;
            this.N9.Click += new System.EventHandler(this.N1_Click);
            // 
            // N8
            // 
            this.N8.BackColor = System.Drawing.Color.LavenderBlush;
            this.N8.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N8.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N8.Location = new System.Drawing.Point(129, 228);
            this.N8.Name = "N8";
            this.N8.Size = new System.Drawing.Size(54, 55);
            this.N8.TabIndex = 34;
            this.N8.Text = "8";
            this.N8.UseVisualStyleBackColor = false;
            this.N8.Click += new System.EventHandler(this.N1_Click);
            // 
            // N7
            // 
            this.N7.BackColor = System.Drawing.Color.LavenderBlush;
            this.N7.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.N7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N7.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N7.Location = new System.Drawing.Point(69, 228);
            this.N7.Name = "N7";
            this.N7.Size = new System.Drawing.Size(54, 55);
            this.N7.TabIndex = 33;
            this.N7.Text = "7";
            this.N7.UseVisualStyleBackColor = false;
            this.N7.Click += new System.EventHandler(this.N1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LavenderBlush;
            this.delete.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(129, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 55);
            this.delete.TabIndex = 31;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.LavenderBlush;
            this.ButtonC.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC.Location = new System.Drawing.Point(69, 167);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(54, 55);
            this.ButtonC.TabIndex = 29;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // Res
            // 
            this.Res.Font = new System.Drawing.Font("OCR A Extended", 18.2F);
            this.Res.Location = new System.Drawing.Point(69, 111);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(234, 39);
            this.Res.TabIndex = 52;
            this.Res.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 55);
            this.button1.TabIndex = 53;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.N1_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.LavenderBlush;
            this.Change.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(33, 411);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(90, 55);
            this.Change.TabIndex = 54;
            this.Change.Text = "+/-";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.ChangePlM);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(346, 584);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.N0);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.N6);
            this.Controls.Add(this.N5);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.N9);
            this.Controls.Add(this.N8);
            this.Controls.Add(this.N7);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.Backing);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backing;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button N0;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button N3;
        private System.Windows.Forms.Button N2;
        private System.Windows.Forms.Button N1;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button N6;
        private System.Windows.Forms.Button N5;
        private System.Windows.Forms.Button N4;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button N9;
        private System.Windows.Forms.Button N8;
        private System.Windows.Forms.Button N7;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Change;
    }
}

