
namespace ColorReader
{
    partial class ColorReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorReader));
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.txtDEC = new System.Windows.Forms.TextBox();
            this.btnSelectNewColor = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.pictureBoxSizeDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxSizeUp = new System.Windows.Forms.PictureBox();
            this.picPreviewColor = new System.Windows.Forms.PictureBox();
            this.picCurrentColor = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(67, 19);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(66, 13);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "ColorReader";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(11, 85);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(158, 20);
            this.txtRGB.TabIndex = 4;
            this.txtRGB.Text = "RGB:";
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(11, 113);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.Size = new System.Drawing.Size(158, 20);
            this.txtHEX.TabIndex = 5;
            this.txtHEX.Text = "HEX:";
            // 
            // txtDEC
            // 
            this.txtDEC.Location = new System.Drawing.Point(11, 141);
            this.txtDEC.Name = "txtDEC";
            this.txtDEC.Size = new System.Drawing.Size(158, 20);
            this.txtDEC.TabIndex = 7;
            this.txtDEC.Text = "DEC:";
            // 
            // btnSelectNewColor
            // 
            this.btnSelectNewColor.Location = new System.Drawing.Point(11, 184);
            this.btnSelectNewColor.Name = "btnSelectNewColor";
            this.btnSelectNewColor.Size = new System.Drawing.Size(158, 29);
            this.btnSelectNewColor.TabIndex = 8;
            this.btnSelectNewColor.Text = "Select new color";
            this.btnSelectNewColor.UseVisualStyleBackColor = true;
            this.btnSelectNewColor.Click += new System.EventHandler(this.btnSelectNewColor_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(178, 184);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(83, 29);
            this.btnSaveToFile.TabIndex = 9;
            this.btnSaveToFile.Text = "Save txt";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(175, 64);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Info";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(267, 172);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(30, 13);
            this.labelArea.TabIndex = 14;
            this.labelArea.Text = "Size:";
            // 
            // pictureBoxSizeDown
            // 
            this.pictureBoxSizeDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSizeDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSizeDown.Image = global::ColorReader.Properties.Resources.expand_arrow_64px;
            this.pictureBoxSizeDown.Location = new System.Drawing.Point(278, 192);
            this.pictureBoxSizeDown.Name = "pictureBoxSizeDown";
            this.pictureBoxSizeDown.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSizeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSizeDown.TabIndex = 16;
            this.pictureBoxSizeDown.TabStop = false;
            this.pictureBoxSizeDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSizeDown_MouseDown);
            // 
            // pictureBoxSizeUp
            // 
            this.pictureBoxSizeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSizeUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSizeUp.Image = global::ColorReader.Properties.Resources.collapse_arrow_64px;
            this.pictureBoxSizeUp.Location = new System.Drawing.Point(318, 192);
            this.pictureBoxSizeUp.Name = "pictureBoxSizeUp";
            this.pictureBoxSizeUp.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSizeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSizeUp.TabIndex = 15;
            this.pictureBoxSizeUp.TabStop = false;
            this.pictureBoxSizeUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSizeUp_MouseDown);
            // 
            // picPreviewColor
            // 
            this.picPreviewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewColor.Location = new System.Drawing.Point(270, 85);
            this.picPreviewColor.Name = "picPreviewColor";
            this.picPreviewColor.Size = new System.Drawing.Size(82, 82);
            this.picPreviewColor.TabIndex = 10;
            this.picPreviewColor.TabStop = false;
            // 
            // picCurrentColor
            // 
            this.picCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCurrentColor.Location = new System.Drawing.Point(178, 85);
            this.picCurrentColor.Name = "picCurrentColor";
            this.picCurrentColor.Size = new System.Drawing.Size(82, 82);
            this.picCurrentColor.TabIndex = 6;
            this.picCurrentColor.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ColorReader.Properties.Resources.color_wheel_80px;
            this.picLogo.Location = new System.Drawing.Point(13, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::ColorReader.Properties.Resources.minimize_window_64px;
            this.picMinimize.Location = new System.Drawing.Point(278, 14);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(34, 34);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::ColorReader.Properties.Resources.close_window_64px;
            this.picClose.Location = new System.Drawing.Point(318, 14);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(34, 34);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // ColorReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 235);
            this.Controls.Add(this.pictureBoxSizeDown);
            this.Controls.Add(this.pictureBoxSizeUp);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.picPreviewColor);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnSelectNewColor);
            this.Controls.Add(this.txtDEC);
            this.Controls.Add(this.picCurrentColor);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorReader";
            this.Text = "ColorReader";
            this.Load += new System.EventHandler(this.ColorReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.PictureBox picCurrentColor;
        private System.Windows.Forms.TextBox txtDEC;
        private System.Windows.Forms.Button btnSelectNewColor;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.PictureBox picPreviewColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.PictureBox pictureBoxSizeUp;
        private System.Windows.Forms.PictureBox pictureBoxSizeDown;
    }
}