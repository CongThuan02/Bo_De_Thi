namespace Bài_25
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
            this.btnMoTapTin = new System.Windows.Forms.Button();
            this.btnLuTepTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoanThao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnMoTapTin
            // 
            this.btnMoTapTin.Location = new System.Drawing.Point(42, 71);
            this.btnMoTapTin.Name = "btnMoTapTin";
            this.btnMoTapTin.Size = new System.Drawing.Size(121, 30);
            this.btnMoTapTin.TabIndex = 0;
            this.btnMoTapTin.Text = "Mở tập tin";
            this.btnMoTapTin.UseVisualStyleBackColor = true;
            this.btnMoTapTin.Click += new System.EventHandler(this.btnMoTapTin_Click);
            // 
            // btnLuTepTin
            // 
            this.btnLuTepTin.Location = new System.Drawing.Point(42, 124);
            this.btnLuTepTin.Name = "btnLuTepTin";
            this.btnLuTepTin.Size = new System.Drawing.Size(121, 30);
            this.btnLuTepTin.TabIndex = 0;
            this.btnLuTepTin.Text = "Lưu tập tin";
            this.btnLuTepTin.UseVisualStyleBackColor = true;
            this.btnLuTepTin.Click += new System.EventHandler(this.btnLuTepTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(42, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 31);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSoanThao
            // 
            this.txtSoanThao.Location = new System.Drawing.Point(298, 94);
            this.txtSoanThao.Multiline = true;
            this.txtSoanThao.Name = "txtSoanThao";
            this.txtSoanThao.Size = new System.Drawing.Size(490, 344);
            this.txtSoanThao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soạn thảo văn bản";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoanThao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuTepTin);
            this.Controls.Add(this.btnMoTapTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoTapTin;
        private System.Windows.Forms.Button btnLuTepTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoanThao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

