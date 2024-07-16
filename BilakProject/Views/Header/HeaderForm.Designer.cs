namespace BilakProject.Views.Header
{
    partial class HeaderForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ExpanPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ClosePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Firebrick;
            this.guna2Panel1.Controls.Add(this.MinimizePictureBox);
            this.guna2Panel1.Controls.Add(this.ExpanPictureBox);
            this.guna2Panel1.Controls.Add(this.ClosePictureBox);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(804, 25);
            this.guna2Panel1.TabIndex = 0;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePictureBox.Image = global::BilakProject.Properties.Resources.window_minimize;
            this.MinimizePictureBox.ImageRotate = 0F;
            this.MinimizePictureBox.Location = new System.Drawing.Point(697, 2);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(12, 12);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 3;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            // 
            // ExpanPictureBox
            // 
            this.ExpanPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpanPictureBox.Image = global::BilakProject.Properties.Resources.expand_arrows;
            this.ExpanPictureBox.ImageRotate = 0F;
            this.ExpanPictureBox.Location = new System.Drawing.Point(738, 7);
            this.ExpanPictureBox.Name = "ExpanPictureBox";
            this.ExpanPictureBox.Size = new System.Drawing.Size(12, 12);
            this.ExpanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpanPictureBox.TabIndex = 2;
            this.ExpanPictureBox.TabStop = false;
            this.ExpanPictureBox.Click += new System.EventHandler(this.ExpanPictureBox_Click);
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosePictureBox.Image = global::BilakProject.Properties.Resources.close;
            this.ClosePictureBox.ImageRotate = 0F;
            this.ClosePictureBox.Location = new System.Drawing.Point(779, 7);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(12, 12);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePictureBox.TabIndex = 1;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // HeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeaderForm";
            this.Text = "HeaderForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox MinimizePictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox ExpanPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox ClosePictureBox;
    }
}