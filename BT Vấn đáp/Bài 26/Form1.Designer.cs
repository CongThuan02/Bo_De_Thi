namespace Bài_26
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPhepTinh = new System.Windows.Forms.GroupBox();
            this.groupBoxKetQua = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPhepTinh.SuspendLayout();
            this.groupBoxKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTu1);
            this.groupBox1.Controls.Add(this.txtMau1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(68, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân số 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTu2);
            this.groupBox2.Controls.Add(this.txtMau2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(489, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân số 2";
            // 
            // groupBoxPhepTinh
            // 
            this.groupBoxPhepTinh.Controls.Add(this.btnChia);
            this.groupBoxPhepTinh.Controls.Add(this.btnNhan);
            this.groupBoxPhepTinh.Controls.Add(this.btnCong);
            this.groupBoxPhepTinh.Controls.Add(this.btnTru);
            this.groupBoxPhepTinh.Location = new System.Drawing.Point(68, 271);
            this.groupBoxPhepTinh.Name = "groupBoxPhepTinh";
            this.groupBoxPhepTinh.Size = new System.Drawing.Size(170, 133);
            this.groupBoxPhepTinh.TabIndex = 1;
            this.groupBoxPhepTinh.TabStop = false;
            this.groupBoxPhepTinh.Text = "Phép tính ";
            this.groupBoxPhepTinh.Enter += new System.EventHandler(this.groupBoxPhepTinh_Enter);
            // 
            // groupBoxKetQua
            // 
            this.groupBoxKetQua.Controls.Add(this.txtTu);
            this.groupBoxKetQua.Controls.Add(this.txtMau);
            this.groupBoxKetQua.Controls.Add(this.label7);
            this.groupBoxKetQua.Controls.Add(this.label6);
            this.groupBoxKetQua.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxKetQua.Location = new System.Drawing.Point(489, 271);
            this.groupBoxKetQua.Name = "groupBoxKetQua";
            this.groupBoxKetQua.Size = new System.Drawing.Size(170, 133);
            this.groupBoxKetQua.TabIndex = 1;
            this.groupBoxKetQua.TabStop = false;
            this.groupBoxKetQua.Text = "Kết quả cộng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phép tính phân số ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tử số ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mẫu số ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tử số ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mẫu số ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tử số ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mẫu số ";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(22, 49);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(68, 27);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Cộng ";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(96, 49);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(68, 27);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "Trừ ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(22, 92);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(68, 27);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Nhân ";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(96, 92);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(68, 27);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "Chia ";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(70, 413);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(68, 27);
            this.btnTiepTuc.TabIndex = 7;
            this.btnTiepTuc.Text = "Tiếp tục ";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(70, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 27);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(65, 48);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(99, 22);
            this.txtTu1.TabIndex = 9;
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(65, 87);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(99, 22);
            this.txtMau1.TabIndex = 10;
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(65, 45);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(99, 22);
            this.txtTu2.TabIndex = 11;
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(65, 87);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(99, 22);
            this.txtMau2.TabIndex = 12;
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(65, 43);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(99, 22);
            this.txtTu.TabIndex = 13;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(65, 97);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(99, 22);
            this.txtMau.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPhepTinh);
            this.Controls.Add(this.groupBoxKetQua);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPhepTinh.ResumeLayout(false);
            this.groupBoxKetQua.ResumeLayout(false);
            this.groupBoxKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxPhepTinh;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.GroupBox groupBoxKetQua;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

