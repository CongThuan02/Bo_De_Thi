namespace WindowsFormsApp8
{
    partial class Form1
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
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCongTru = new System.Windows.Forms.Button();
            this.btnCham = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(31, 43);
            this.txtManHinh.Multiline = true;
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(650, 22);
            this.txtManHinh.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btnCham);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btnCongTru);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Location = new System.Drawing.Point(25, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numerical";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnC);
            this.groupBox2.Controls.Add(this.btnCong);
            this.groupBox2.Controls.Add(this.btnBang);
            this.groupBox2.Controls.Add(this.btnTru);
            this.groupBox2.Controls.Add(this.btnChia);
            this.groupBox2.Controls.Add(this.btnNhan);
            this.groupBox2.Location = new System.Drawing.Point(481, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 314);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operator";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 40);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(131, 40);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(258, 40);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 102);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(131, 102);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(258, 102);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(131, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(251, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 219);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButtons);
            // 
            // btnCongTru
            // 
            this.btnCongTru.Location = new System.Drawing.Point(131, 219);
            this.btnCongTru.Name = "btnCongTru";
            this.btnCongTru.Size = new System.Drawing.Size(75, 23);
            this.btnCongTru.TabIndex = 8;
            this.btnCongTru.Text = "+/-";
            this.btnCongTru.UseVisualStyleBackColor = true;
            this.btnCongTru.Click += new System.EventHandler(this.btnCongTru_Click);
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(251, 219);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(75, 23);
            this.btnCham.TabIndex = 9;
            this.btnCham.Text = ".";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(61, 40);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 10;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.Operations);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(61, 82);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 11;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.Operations);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(61, 126);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 12;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.Operations);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(61, 173);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 13;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.Operations);
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(61, 219);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 23);
            this.btnBang.TabIndex = 14;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(61, 263);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 15;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtManHinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCongTru;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
    }
}

