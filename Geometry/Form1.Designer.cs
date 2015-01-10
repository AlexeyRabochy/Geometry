namespace Geometry
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x11box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.y11box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x12box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.y12box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.x21box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x22box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.y21box = new System.Windows.Forms.TextBox();
            this.y22box = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1146, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Let`s check it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 700);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "x11";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // x11box
            // 
            this.x11box.Location = new System.Drawing.Point(65, 697);
            this.x11box.Name = "x11box";
            this.x11box.Size = new System.Drawing.Size(159, 31);
            this.x11box.TabIndex = 2;
            this.x11box.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 775);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "y11";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // y11box
            // 
            this.y11box.Location = new System.Drawing.Point(65, 772);
            this.y11box.Name = "y11box";
            this.y11box.Size = new System.Drawing.Size(159, 31);
            this.y11box.TabIndex = 2;
            this.y11box.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "x12";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // x12box
            // 
            this.x12box.Location = new System.Drawing.Point(294, 697);
            this.x12box.Name = "x12box";
            this.x12box.Size = new System.Drawing.Size(164, 31);
            this.x12box.TabIndex = 2;
            this.x12box.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 775);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "y12";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // y12box
            // 
            this.y12box.Location = new System.Drawing.Point(294, 772);
            this.y12box.Name = "y12box";
            this.y12box.Size = new System.Drawing.Size(164, 31);
            this.y12box.TabIndex = 2;
            this.y12box.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 700);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "x21";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // x21box
            // 
            this.x21box.Location = new System.Drawing.Point(553, 697);
            this.x21box.Name = "x21box";
            this.x21box.Size = new System.Drawing.Size(154, 31);
            this.x21box.TabIndex = 2;
            this.x21box.Text = "0";
            this.x21box.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "x22";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // x22box
            // 
            this.x22box.Location = new System.Drawing.Point(782, 697);
            this.x22box.Name = "x22box";
            this.x22box.Size = new System.Drawing.Size(162, 31);
            this.x22box.TabIndex = 2;
            this.x22box.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 775);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "y21";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 775);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "y22";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // y21box
            // 
            this.y21box.Location = new System.Drawing.Point(553, 772);
            this.y21box.Name = "y21box";
            this.y21box.Size = new System.Drawing.Size(154, 31);
            this.y21box.TabIndex = 2;
            this.y21box.Text = "0";
            // 
            // y22box
            // 
            this.y22box.Location = new System.Drawing.Point(782, 772);
            this.y22box.Name = "y22box";
            this.y22box.Size = new System.Drawing.Size(162, 31);
            this.y22box.TabIndex = 2;
            this.y22box.Text = "0";
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.res.Location = new System.Drawing.Point(970, 700);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(156, 97);
            this.res.TabIndex = 3;
            this.res.Text = "Enter data";
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 815);
            this.Controls.Add(this.res);
            this.Controls.Add(this.y22box);
            this.Controls.Add(this.y21box);
            this.Controls.Add(this.y12box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.y11box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x22box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.x12box);
            this.Controls.Add(this.x21box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x11box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.LocationChanged += new System.EventHandler(this.Action);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x11box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y11box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x12box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y12box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x21box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x22box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox y21box;
        private System.Windows.Forms.TextBox y22box;
        private System.Windows.Forms.Label res;
    }
}

