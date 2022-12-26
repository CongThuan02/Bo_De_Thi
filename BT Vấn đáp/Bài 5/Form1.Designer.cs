namespace Bài_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rS1 = new System.Windows.Forms.RadioButton();
            this.rS2 = new System.Windows.Forms.RadioButton();
            this.rS3 = new System.Windows.Forms.RadioButton();
            this.rS4 = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TỔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số N:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rS4);
            this.groupBox1.Controls.Add(this.rS3);
            this.groupBox1.Controls.Add(this.rS2);
            this.groupBox1.Controls.Add(this.rS1);
            this.groupBox1.Location = new System.Drawing.Point(25, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // rS1
            // 
            this.rS1.AutoSize = true;
            this.rS1.Location = new System.Drawing.Point(21, 66);
            this.rS1.Name = "rS1";
            this.rS1.Size = new System.Drawing.Size(206, 24);
            this.rS1.TabIndex = 0;
            this.rS1.TabStop = true;
            this.rS1.Text = "S = 1+ 3 + 5 + .... + (2N-1)";
            this.rS1.UseVisualStyleBackColor = true;
            // 
            // rS2
            // 
            this.rS2.AutoSize = true;
            this.rS2.Location = new System.Drawing.Point(21, 109);
            this.rS2.Name = "rS2";
            this.rS2.Size = new System.Drawing.Size(185, 24);
            this.rS2.TabIndex = 0;
            this.rS2.TabStop = true;
            this.rS2.Text = "S= 1 + 4+ 9 + .... + N^2";
            this.rS2.UseVisualStyleBackColor = true;
            // 
            // rS3
            // 
            this.rS3.AutoSize = true;
            this.rS3.Location = new System.Drawing.Point(21, 150);
            this.rS3.Name = "rS3";
            this.rS3.Size = new System.Drawing.Size(208, 24);
            this.rS3.TabIndex = 0;
            this.rS3.TabStop = true;
            this.rS3.Text = "S = 1 + 1/2 + 1/3 + ... +1/N";
            this.rS3.UseVisualStyleBackColor = true;
            // 
            // rS4
            // 
            this.rS4.AutoSize = true;
            this.rS4.Location = new System.Drawing.Point(21, 204);
            this.rS4.Name = "rS4";
            this.rS4.Size = new System.Drawing.Size(220, 24);
            this.rS4.TabIndex = 0;
            this.rS4.TabStop = true;
            this.rS4.Text = "S = 1 + 1/2! + 1/3! + ...+ 1/N!";
            this.rS4.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(566, 194);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(113, 42);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(438, 332);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(113, 42);
            this.btnTiepTuc.TabIndex = 3;
            this.btnTiepTuc.Text = "Tính tiếp";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(665, 332);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(113, 42);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(566, 255);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(113, 26);
            this.txtKetQua.TabIndex = 4;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(186, 95);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(113, 26);
            this.txtN.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rS4;
        private System.Windows.Forms.RadioButton rS3;
        private System.Windows.Forms.RadioButton rS2;
        private System.Windows.Forms.RadioButton rS1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtN;
    }
}

