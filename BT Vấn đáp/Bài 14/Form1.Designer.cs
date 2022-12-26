namespace Bài_14
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
            this.Li_DSSanPham = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThemSP = new System.Windows.Forms.TextBox();
            this.txtThemSPViTri = new System.Windows.Forms.TextBox();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaDS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Li_DSSanPham
            // 
            this.Li_DSSanPham.FormattingEnabled = true;
            this.Li_DSSanPham.ItemHeight = 16;
            this.Li_DSSanPham.Location = new System.Drawing.Point(28, 85);
            this.Li_DSSanPham.Name = "Li_DSSanPham";
            this.Li_DSSanPham.Size = new System.Drawing.Size(231, 276);
            this.Li_DSSanPham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sản phẩm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thêm sản phẩm ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thêm sản phẩm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập sản phẩm cần tìm ";
            // 
            // txtThemSP
            // 
            this.txtThemSP.Location = new System.Drawing.Point(480, 85);
            this.txtThemSP.Name = "txtThemSP";
            this.txtThemSP.Size = new System.Drawing.Size(172, 22);
            this.txtThemSP.TabIndex = 5;
            // 
            // txtThemSPViTri
            // 
            this.txtThemSPViTri.Location = new System.Drawing.Point(480, 144);
            this.txtThemSPViTri.Name = "txtThemSPViTri";
            this.txtThemSPViTri.Size = new System.Drawing.Size(172, 22);
            this.txtThemSPViTri.TabIndex = 6;
            // 
            // txtTimSP
            // 
            this.txtTimSP.Location = new System.Drawing.Point(480, 195);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(172, 22);
            this.txtTimSP.TabIndex = 7;
            this.txtTimSP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(658, 81);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Location = new System.Drawing.Point(832, 147);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(78, 23);
            this.btnThemVT.TabIndex = 9;
            this.btnThemVT.Text = "Thêm ";
            this.btnThemVT.UseVisualStyleBackColor = true;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(658, 195);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(78, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(388, 338);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaDS
            // 
            this.btnXoaDS.Location = new System.Drawing.Point(626, 338);
            this.btnXoaDS.Name = "btnXoaDS";
            this.btnXoaDS.Size = new System.Drawing.Size(214, 23);
            this.btnXoaDS.TabIndex = 12;
            this.btnXoaDS.Text = "Xóa danh sách sản phẩm ";
            this.btnXoaDS.UseVisualStyleBackColor = true;
            this.btnXoaDS.Click += new System.EventHandler(this.btnXoaDS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vị trí thêm ";
            // 
            // cboViTri
            // 
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(734, 144);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(92, 24);
            this.cboViTri.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.cboViTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaDS);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.txtThemSPViTri);
            this.Controls.Add(this.txtThemSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Li_DSSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Li_DSSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThemSP;
        private System.Windows.Forms.TextBox txtThemSPViTri;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboViTri;
    }
}

