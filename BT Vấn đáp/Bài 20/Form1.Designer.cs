namespace Bài_20
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
            this.TV_Test = new System.Windows.Forms.TreeView();
            this.btnThemGoc = new System.Windows.Forms.Button();
            this.btnThemCon = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoRong = new System.Windows.Forms.Button();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treeview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề node";
            // 
            // TV_Test
            // 
            this.TV_Test.Location = new System.Drawing.Point(73, 98);
            this.TV_Test.Name = "TV_Test";
            this.TV_Test.Size = new System.Drawing.Size(196, 258);
            this.TV_Test.TabIndex = 2;
            // 
            // btnThemGoc
            // 
            this.btnThemGoc.Location = new System.Drawing.Point(482, 108);
            this.btnThemGoc.Name = "btnThemGoc";
            this.btnThemGoc.Size = new System.Drawing.Size(117, 23);
            this.btnThemGoc.TabIndex = 3;
            this.btnThemGoc.Text = "Thêm node gốc ";
            this.btnThemGoc.UseVisualStyleBackColor = true;
            this.btnThemGoc.Click += new System.EventHandler(this.btnThemGoc_Click);
            // 
            // btnThemCon
            // 
            this.btnThemCon.Location = new System.Drawing.Point(482, 153);
            this.btnThemCon.Name = "btnThemCon";
            this.btnThemCon.Size = new System.Drawing.Size(117, 23);
            this.btnThemCon.TabIndex = 4;
            this.btnThemCon.Text = "Thêm node con tại vị trí chọn";
            this.btnThemCon.UseVisualStyleBackColor = true;
            this.btnThemCon.Click += new System.EventHandler(this.btnThemCon_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(482, 196);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(117, 23);
            this.btnXoaTatCa.TabIndex = 5;
            this.btnXoaTatCa.Text = "Xóa tất cả các node";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(482, 237);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(117, 23);
            this.btnXoaChon.TabIndex = 6;
            this.btnXoaChon.Text = "Xóa node đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(482, 278);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoRong
            // 
            this.btnMoRong.Location = new System.Drawing.Point(65, 390);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(117, 23);
            this.btnMoRong.TabIndex = 8;
            this.btnMoRong.Text = "+";
            this.btnMoRong.UseVisualStyleBackColor = true;
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Location = new System.Drawing.Point(188, 390);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(117, 23);
            this.btnThuNho.TabIndex = 9;
            this.btnThuNho.Text = "-";
            this.btnThuNho.UseVisualStyleBackColor = true;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(482, 76);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(178, 22);
            this.txtTieuDe.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.btnThuNho);
            this.Controls.Add(this.btnMoRong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnThemCon);
            this.Controls.Add(this.btnThemGoc);
            this.Controls.Add(this.TV_Test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TV_Test;
        private System.Windows.Forms.Button btnThemGoc;
        private System.Windows.Forms.Button btnThemCon;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoRong;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.TextBox txtTieuDe;
    }
}

