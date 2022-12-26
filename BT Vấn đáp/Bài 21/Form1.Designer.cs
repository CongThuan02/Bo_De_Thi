namespace Bài_21
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(154, 38);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(454, 214);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.AutoScroll = true;
            this.myFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(154, 295);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(453, 100);
            this.myFlowLayoutPanel.TabIndex = 1;
            this.myFlowLayoutPanel.WrapContents = false;
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "1.png");
            this.myImageList.Images.SetKeyName(1, "2.png");
            this.myImageList.Images.SetKeyName(2, "3.png");
            this.myImageList.Images.SetKeyName(3, "4.png");
            this.myImageList.Images.SetKeyName(4, "Ảnh1.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Controls.Add(this.myPictureBox);
            this.Name = "Form1";
            this.Text = "FlowLayoutPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
        private System.Windows.Forms.ImageList myImageList;
    }
}

