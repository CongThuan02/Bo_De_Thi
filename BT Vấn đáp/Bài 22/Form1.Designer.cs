namespace Bài_22
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
            Form1 form11 = this;
            form11.tabControl1 = new System.Windows.Forms.TabControl();
            form11.tabQuanLyNhanVien = new System.Windows.Forms.TabPage();
            form11.listNhanVien = new System.Windows.Forms.ListView();
            form11.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colHeSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colLuongCoBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.btnXoaNV = new System.Windows.Forms.Button();
            form11.btnCapNhatNV = new System.Windows.Forms.Button();
            form11.btnThemNV = new System.Windows.Forms.Button();
            form11.txtHeSoLuongNV = new System.Windows.Forms.TextBox();
            form11.txtChucVuNV = new System.Windows.Forms.TextBox();
            form11.txtLuongCBNV = new System.Windows.Forms.TextBox();
            form11.txtTenNV = new System.Windows.Forms.TextBox();
            form11.label2 = new System.Windows.Forms.Label();
            form11.label3 = new System.Windows.Forms.Label();
            form11.label4 = new System.Windows.Forms.Label();
            form11.label5 = new System.Windows.Forms.Label();
            form11.tabQuanLyGiaoVien = new System.Windows.Forms.TabPage();
            form11.listGV = new System.Windows.Forms.ListView();
            form11.colHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colHocvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colTienday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.colSotietday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            form11.btnXoaGV = new System.Windows.Forms.Button();
            form11.btnCapnhat = new System.Windows.Forms.Button();
            form11.btnThemGV = new System.Windows.Forms.Button();
            form11.textBox4 = new System.Windows.Forms.TextBox();
            form11.txtHocvi = new System.Windows.Forms.TextBox();
            form11.txtTenday = new System.Windows.Forms.TextBox();
            form11.txtHoten = new System.Windows.Forms.TextBox();
            form11.txtSotiet = new System.Windows.Forms.Label();
            form11.label8 = new System.Windows.Forms.Label();
            form11.label7 = new System.Windows.Forms.Label();
            form11.label6 = new System.Windows.Forms.Label();
            form11.label1 = new System.Windows.Forms.Label();
            form11.btnThoat = new System.Windows.Forms.Button();
            form11.tabControl1.SuspendLayout();
            form11.tabQuanLyNhanVien.SuspendLayout();
            form11.tabQuanLyGiaoVien.SuspendLayout();
            form11.SuspendLayout();
            // 
            // tabControl1
            // 
            form11.tabControl1.Controls.Add(form11.tabQuanLyNhanVien);
            form11.tabControl1.Controls.Add(form11.tabQuanLyGiaoVien);
            form11.tabControl1.Location = new System.Drawing.Point(62, 119);
            form11.tabControl1.Name = "tabControl1";
            form11.tabControl1.SelectedIndex = 0;
            form11.tabControl1.Size = new System.Drawing.Size(695, 291);
            form11.tabControl1.TabIndex = 0;
            // 
            // tabQuanLyNhanVien
            // 
            form11.tabQuanLyNhanVien.Controls.Add(form11.listNhanVien);
            form11.tabQuanLyNhanVien.Controls.Add(form11.btnXoaNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.btnCapNhatNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.btnThemNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.txtHeSoLuongNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.txtChucVuNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.txtLuongCBNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.txtTenNV);
            form11.tabQuanLyNhanVien.Controls.Add(form11.label2);
            form11.tabQuanLyNhanVien.Controls.Add(form11.label3);
            form11.tabQuanLyNhanVien.Controls.Add(form11.label4);
            form11.tabQuanLyNhanVien.Controls.Add(form11.label5);
            form11.tabQuanLyNhanVien.Location = new System.Drawing.Point(4, 25);
            form11.tabQuanLyNhanVien.Name = "tabQuanLyNhanVien";
            form11.tabQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(3);
            form11.tabQuanLyNhanVien.Size = new System.Drawing.Size(687, 262);
            form11.tabQuanLyNhanVien.TabIndex = 0;
            form11.tabQuanLyNhanVien.Text = "Quản lí nhân viên ";
            form11.tabQuanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // listNhanVien
            // 
            form11.listNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            form11.colHoTen,
            form11.colChucVu,
            form11.colHeSoLuong,
            form11.colLuongCoBan});
            form11.listNhanVien.FullRowSelect = true;
            form11.listNhanVien.HideSelection = false;
            form11.listNhanVien.Location = new System.Drawing.Point(32, 121);
            form11.listNhanVien.MultiSelect = false;
            form11.listNhanVien.Name = "listNhanVien";
            form11.listNhanVien.Size = new System.Drawing.Size(610, 127);
            form11.listNhanVien.TabIndex = 13;
            form11.listNhanVien.UseCompatibleStateImageBehavior = false;
            form11.listNhanVien.View = System.Windows.Forms.View.Details;
            Form1 form1 = form11;
            form11.listNhanVien.SelectedIndexChanged += new System.EventHandler(form11.listNhanVien);
            // 
            // colHoTen
            // 
            form11.colHoTen.Text = "Họ tên";
            // 
            // colChucVu
            // 
            form11.colChucVu.Text = "Chức vụ ";
            form11.colChucVu.Width = 92;
            // 
            // colHeSoLuong
            // 
            form11.colHeSoLuong.Text = "Hệ số lương ";
            form11.colHeSoLuong.Width = 100;
            // 
            // colLuongCoBan
            // 
            form11.colLuongCoBan.Text = "Lương cơ bản ";
            form11.colLuongCoBan.Width = 124;
            // 
            // btnXoaNV
            // 
            form11.btnXoaNV.Location = new System.Drawing.Point(465, 92);
            form11.btnXoaNV.Name = "btnXoaNV";
            form11.btnXoaNV.Size = new System.Drawing.Size(115, 23);
            form11.btnXoaNV.TabIndex = 12;
            form11.btnXoaNV.Text = "Xóa nhân viên ";
            form11.btnXoaNV.UseVisualStyleBackColor = true;
            form11.btnXoaNV.Click += new System.EventHandler(form11.btnXoaNV_Click);
            // 
            // btnCapNhatNV
            // 
            form11.btnCapNhatNV.Location = new System.Drawing.Point(270, 92);
            form11.btnCapNhatNV.Name = "btnCapNhatNV";
            form11.btnCapNhatNV.Size = new System.Drawing.Size(93, 23);
            form11.btnCapNhatNV.TabIndex = 11;
            form11.btnCapNhatNV.Text = "Cập nhật ";
            form11.btnCapNhatNV.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            form11.btnThemNV.Location = new System.Drawing.Point(106, 92);
            form11.btnThemNV.Name = "btnThemNV";
            form11.btnThemNV.Size = new System.Drawing.Size(118, 23);
            form11.btnThemNV.TabIndex = 10;
            form11.btnThemNV.Text = "Thêm nhân viên ";
            form11.btnThemNV.UseVisualStyleBackColor = true;
            form11.btnThemNV.Click += new System.EventHandler(form11.btnThemNV_Click);
            // 
            // txtHeSoLuongNV
            // 
            form11.txtHeSoLuongNV.Location = new System.Drawing.Point(430, 59);
            form11.txtHeSoLuongNV.Name = "txtHeSoLuongNV";
            form11.txtHeSoLuongNV.Size = new System.Drawing.Size(150, 22);
            form11.txtHeSoLuongNV.TabIndex = 9;
            // 
            // txtChucVuNV
            // 
            form11.txtChucVuNV.Location = new System.Drawing.Point(408, 21);
            form11.txtChucVuNV.Name = "txtChucVuNV";
            form11.txtChucVuNV.Size = new System.Drawing.Size(150, 22);
            form11.txtChucVuNV.TabIndex = 8;
            // 
            // txtLuongCBNV
            // 
            form11.txtLuongCBNV.Location = new System.Drawing.Point(106, 50);
            form11.txtLuongCBNV.Name = "txtLuongCBNV";
            form11.txtLuongCBNV.Size = new System.Drawing.Size(150, 22);
            form11.txtLuongCBNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            form11.txtTenNV.Location = new System.Drawing.Point(106, 18);
            form11.txtTenNV.Name = "txtTenNV";
            form11.txtTenNV.Size = new System.Drawing.Size(150, 22);
            form11.txtTenNV.TabIndex = 6;
            // 
            // label2
            // 
            form11.label2.AutoSize = true;
            form11.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            form11.label2.Location = new System.Drawing.Point(19, 21);
            form11.label2.Name = "label2";
            form11.label2.Size = new System.Drawing.Size(54, 17);
            form11.label2.TabIndex = 2;
            form11.label2.Text = "Họ tên ";
            // 
            // label3
            // 
            form11.label3.AutoSize = true;
            form11.label3.Location = new System.Drawing.Point(19, 50);
            form11.label3.Name = "label3";
            form11.label3.Size = new System.Drawing.Size(91, 16);
            form11.label3.TabIndex = 3;
            form11.label3.Text = "Lương cơ bản ";
            // 
            // label4
            // 
            form11.label4.AutoSize = true;
            form11.label4.Location = new System.Drawing.Point(342, 21);
            form11.label4.Name = "label4";
            form11.label4.Size = new System.Drawing.Size(57, 16);
            form11.label4.TabIndex = 4;
            form11.label4.Text = "Chức vụ ";
            // 
            // label5
            // 
            form11.label5.AutoSize = true;
            form11.label5.Location = new System.Drawing.Point(342, 62);
            form11.label5.Name = "label5";
            form11.label5.Size = new System.Drawing.Size(82, 16);
            form11.label5.TabIndex = 5;
            form11.label5.Text = "Hệ số lương ";
            // 
            // tabQuanLyGiaoVien
            // 
            form11.tabQuanLyGiaoVien.Controls.Add(form11.listGV);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.btnXoaGV);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.btnCapnhat);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.btnThemGV);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.textBox4);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.txtHocvi);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.txtTenday);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.txtHoten);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.txtSotiet);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.label8);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.label7);
            form11.tabQuanLyGiaoVien.Controls.Add(form11.label6);
            form11.tabQuanLyGiaoVien.Location = new System.Drawing.Point(4, 25);
            form11.tabQuanLyGiaoVien.Name = "tabQuanLyGiaoVien";
            form11.tabQuanLyGiaoVien.Padding = new System.Windows.Forms.Padding(3);
            form11.tabQuanLyGiaoVien.Size = new System.Drawing.Size(687, 262);
            form11.tabQuanLyGiaoVien.TabIndex = 1;
            form11.tabQuanLyGiaoVien.Text = "Quản lý giáo viên";
            form11.tabQuanLyGiaoVien.UseVisualStyleBackColor = true;
            // 
            // listGV
            // 
            form11.listGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            form11.colHT,
            form11.colHocvi,
            form11.colTienday,
            form11.colSotietday});
            form11.listGV.FullRowSelect = true;
            form11.listGV.HideSelection = false;
            form11.listGV.Location = new System.Drawing.Point(31, 138);
            form11.listGV.MultiSelect = false;
            form11.listGV.Name = "listGV";
            form11.listGV.Size = new System.Drawing.Size(628, 108);
            form11.listGV.TabIndex = 11;
            form11.listGV.UseCompatibleStateImageBehavior = false;
            form11.listGV.View = System.Windows.Forms.View.Details;
            // 
            // colHT
            // 
            form11.colHT.Text = "Họ tên ";
            // 
            // colHocvi
            // 
            form11.colHocvi.Text = "Học vị ";
            // 
            // colTienday
            // 
            form11.colTienday.Text = "Tiền dạy 1 tiết ";
            form11.colTienday.Width = 114;
            // 
            // colSotietday
            // 
            form11.colSotietday.Text = "Số tiết dạy";
            form11.colSotietday.Width = 97;
            // 
            // btnXoaGV
            // 
            form11.btnXoaGV.Location = new System.Drawing.Point(479, 98);
            form11.btnXoaGV.Name = "btnXoaGV";
            form11.btnXoaGV.Size = new System.Drawing.Size(117, 23);
            form11.btnXoaGV.TabIndex = 10;
            form11.btnXoaGV.Text = "Xóa giáo viên ";
            form11.btnXoaGV.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            form11.btnCapnhat.Location = new System.Drawing.Point(275, 98);
            form11.btnCapnhat.Name = "btnCapnhat";
            form11.btnCapnhat.Size = new System.Drawing.Size(92, 23);
            form11.btnCapnhat.TabIndex = 9;
            form11.btnCapnhat.Text = "Cập nhật";
            form11.btnCapnhat.UseVisualStyleBackColor = true;
            form11.btnCapnhat.Click += new System.EventHandler(form11.btnCapnhat_Click);
            // 
            // btnThemGV
            // 
            form11.btnThemGV.Location = new System.Drawing.Point(37, 98);
            form11.btnThemGV.Name = "btnThemGV";
            form11.btnThemGV.Size = new System.Drawing.Size(115, 23);
            form11.btnThemGV.TabIndex = 8;
            form11.btnThemGV.Text = "Thêm giáo viên ";
            form11.btnThemGV.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            form11.textBox4.Location = new System.Drawing.Point(441, 54);
            form11.textBox4.Name = "textBox4";
            form11.textBox4.Size = new System.Drawing.Size(211, 22);
            form11.textBox4.TabIndex = 7;
            // 
            // txtHocvi
            // 
            form11.txtHocvi.Location = new System.Drawing.Point(419, 23);
            form11.txtHocvi.Name = "txtHocvi";
            form11.txtHocvi.Size = new System.Drawing.Size(211, 22);
            form11.txtHocvi.TabIndex = 6;
            // 
            // txtTenday
            // 
            form11.txtTenday.Location = new System.Drawing.Point(124, 54);
            form11.txtTenday.Name = "txtTenday";
            form11.txtTenday.Size = new System.Drawing.Size(211, 22);
            form11.txtTenday.TabIndex = 5;
            // 
            // txtHoten
            // 
            form11.txtHoten.Location = new System.Drawing.Point(78, 20);
            form11.txtHoten.Name = "txtHoten";
            form11.txtHoten.Size = new System.Drawing.Size(211, 22);
            form11.txtHoten.TabIndex = 4;
            // 
            // txtSotiet
            // 
            form11.txtSotiet.AutoSize = true;
            form11.txtSotiet.Location = new System.Drawing.Point(365, 57);
            form11.txtSotiet.Name = "txtSotiet";
            form11.txtSotiet.Size = new System.Drawing.Size(74, 16);
            form11.txtSotiet.TabIndex = 3;
            form11.txtSotiet.Text = "Số tiền dạy";
            // 
            // label8
            // 
            form11.label8.AutoSize = true;
            form11.label8.Location = new System.Drawing.Point(365, 23);
            form11.label8.Name = "label8";
            form11.label8.Size = new System.Drawing.Size(48, 16);
            form11.label8.TabIndex = 2;
            form11.label8.Text = "Học vị ";
            // 
            // label7
            // 
            form11.label7.AutoSize = true;
            form11.label7.Location = new System.Drawing.Point(28, 57);
            form11.label7.Name = "label7";
            form11.label7.Size = new System.Drawing.Size(90, 16);
            form11.label7.TabIndex = 1;
            form11.label7.Text = "Tên dạy 1 tiết ";
            // 
            // label6
            // 
            form11.label6.AutoSize = true;
            form11.label6.Location = new System.Drawing.Point(28, 23);
            form11.label6.Name = "label6";
            form11.label6.Size = new System.Drawing.Size(49, 16);
            form11.label6.TabIndex = 0;
            form11.label6.Text = "Họ tên ";
            // 
            // label1
            // 
            form11.label1.AutoSize = true;
            form11.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            form11.label1.Location = new System.Drawing.Point(267, 29);
            form11.label1.Name = "label1";
            form11.label1.Size = new System.Drawing.Size(240, 36);
            form11.label1.TabIndex = 1;
            form11.label1.Text = "Quản lý nhân sự ";
            // 
            // btnThoat
            // 
            form11.btnThoat.Location = new System.Drawing.Point(611, 416);
            form11.btnThoat.Name = "btnThoat";
            form11.btnThoat.Size = new System.Drawing.Size(82, 22);
            form11.btnThoat.TabIndex = 2;
            form11.btnThoat.Text = "Thoát ";
            form11.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            form11.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form11.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form11.ClientSize = new System.Drawing.Size(800, 450);
            form11.Controls.Add(form11.btnThoat);
            form11.Controls.Add(form11.label1);
            form11.Controls.Add(form11.tabControl1);
            form11.Name = "Form1";
            form11.Text = "Form1";
            form11.tabControl1.ResumeLayout(false);
            form11.tabQuanLyNhanVien.ResumeLayout(false);
            form11.tabQuanLyNhanVien.PerformLayout();
            form11.tabQuanLyGiaoVien.ResumeLayout(false);
            form11.tabQuanLyGiaoVien.PerformLayout();
            form11.ResumeLayout(false);
            form11.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLyNhanVien;
        private System.Windows.Forms.TabPage tabQuanLyGiaoVien;
        private System.Windows.Forms.ListView listNhanVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colHeSoLuong;
        private System.Windows.Forms.ColumnHeader colLuongCoBan;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtHeSoLuongNV;
        private System.Windows.Forms.TextBox txtChucVuNV;
        private System.Windows.Forms.TextBox txtLuongCBNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listGV;
        private System.Windows.Forms.ColumnHeader colHT;
        private System.Windows.Forms.ColumnHeader colHocvi;
        private System.Windows.Forms.ColumnHeader colTienday;
        private System.Windows.Forms.ColumnHeader colSotietday;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtHocvi;
        private System.Windows.Forms.TextBox txtTenday;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label txtSotiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

