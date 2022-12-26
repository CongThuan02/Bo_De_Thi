namespace Bài_24
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rMauChu = new System.Windows.Forms.RadioButton();
            this.rMauNen = new System.Windows.Forms.RadioButton();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.paBackground = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rMauNen);
            this.groupBox1.Controls.Add(this.rMauChu);
            this.groupBox1.Location = new System.Drawing.Point(4, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu chữ hoặc màu nền";
            // 
            // rMauChu
            // 
            this.rMauChu.AutoSize = true;
            this.rMauChu.Location = new System.Drawing.Point(20, 39);
            this.rMauChu.Name = "rMauChu";
            this.rMauChu.Size = new System.Drawing.Size(88, 24);
            this.rMauChu.TabIndex = 0;
            this.rMauChu.TabStop = true;
            this.rMauChu.Text = "Màu chữ";
            this.rMauChu.UseVisualStyleBackColor = true;
            // 
            // rMauNen
            // 
            this.rMauNen.AutoSize = true;
            this.rMauNen.Location = new System.Drawing.Point(20, 91);
            this.rMauNen.Name = "rMauNen";
            this.rMauNen.Size = new System.Drawing.Size(89, 24);
            this.rMauNen.TabIndex = 0;
            this.rMauNen.TabStop = true;
            this.rMauNen.Text = "Màu nền";
            this.rMauNen.UseVisualStyleBackColor = true;
            // 
            // btnChonMau
            // 
            this.btnChonMau.Location = new System.Drawing.Point(493, 57);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(133, 38);
            this.btnChonMau.TabIndex = 1;
            this.btnChonMau.Text = "Chọn màu";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(493, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 38);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnChonMau);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 194);
            this.panel2.TabIndex = 1;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(158, 76);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(327, 31);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Khoa Công nghệ thông tin";
            // 
            // paBackground
            // 
            this.paBackground.Controls.Add(this.lbText);
            this.paBackground.Location = new System.Drawing.Point(-1, -2);
            this.paBackground.Name = "paBackground";
            this.paBackground.Size = new System.Drawing.Size(801, 231);
            this.paBackground.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.paBackground.ResumeLayout(false);
            this.paBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rMauNen;
        private System.Windows.Forms.RadioButton rMauChu;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel paBackground;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

