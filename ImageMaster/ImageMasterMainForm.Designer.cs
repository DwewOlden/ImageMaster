namespace ImageMaster
{
    partial class ImageMasterMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageMasterMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCameraPath = new System.Windows.Forms.TextBox();
            this.btnCameraPath = new System.Windows.Forms.Button();
            this.cameraPathFileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblImages = new System.Windows.Forms.Label();
            this.initailScanWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblNewTypicalSize = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPerformProcessing = new System.Windows.Forms.Button();
            this.txtJPEGPath = new System.Windows.Forms.TextBox();
            this.btnJPEGPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRAWPath = new System.Windows.Forms.Button();
            this.txtRawPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCameraPath);
            this.groupBox1.Controls.Add(this.btnCameraPath);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(881, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Of Pictures On Camera";
            // 
            // txtCameraPath
            // 
            this.txtCameraPath.Location = new System.Drawing.Point(25, 38);
            this.txtCameraPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCameraPath.Name = "txtCameraPath";
            this.txtCameraPath.Size = new System.Drawing.Size(664, 22);
            this.txtCameraPath.TabIndex = 1;
            // 
            // btnCameraPath
            // 
            this.btnCameraPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraPath.Location = new System.Drawing.Point(699, 36);
            this.btnCameraPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnCameraPath.Name = "btnCameraPath";
            this.btnCameraPath.Size = new System.Drawing.Size(160, 28);
            this.btnCameraPath.TabIndex = 0;
            this.btnCameraPath.Text = "Choose Path";
            this.btnCameraPath.UseVisualStyleBackColor = true;
            this.btnCameraPath.Click += new System.EventHandler(this.BtnCameraPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.lblImages);
            this.groupBox2.Location = new System.Drawing.Point(16, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(881, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Details";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(601, 36);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(88, 17);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Typical Size:";
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Location = new System.Drawing.Point(21, 36);
            this.lblImages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(130, 17);
            this.lblImages.TabIndex = 2;
            this.lblImages.Text = "Number Of Images:";
            // 
            // initailScanWorker
            // 
            this.initailScanWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InitailScanWorker_DoWork);
            this.initailScanWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.InitailScanWorker_RunWorkerCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblNewTypicalSize);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(16, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(881, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images To Be Scaled To This Percentage Of Original Size";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(6, 35);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(853, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 60;
            // 
            // lblNewTypicalSize
            // 
            this.lblNewTypicalSize.AutoSize = true;
            this.lblNewTypicalSize.Location = new System.Drawing.Point(21, 94);
            this.lblNewTypicalSize.Name = "lblNewTypicalSize";
            this.lblNewTypicalSize.Size = new System.Drawing.Size(119, 17);
            this.lblNewTypicalSize.TabIndex = 1;
            this.lblNewTypicalSize.Text = "New Typical Size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnRAWPath);
            this.groupBox4.Controls.Add(this.txtRawPath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnJPEGPath);
            this.groupBox4.Controls.Add(this.txtJPEGPath);
            this.groupBox4.Location = new System.Drawing.Point(16, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(881, 127);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Images Will Be Saved To";
            // 
            // btnPerformProcessing
            // 
            this.btnPerformProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerformProcessing.Location = new System.Drawing.Point(692, 475);
            this.btnPerformProcessing.Name = "btnPerformProcessing";
            this.btnPerformProcessing.Size = new System.Drawing.Size(205, 23);
            this.btnPerformProcessing.TabIndex = 4;
            this.btnPerformProcessing.Text = "Copy and Resize Images";
            this.btnPerformProcessing.UseVisualStyleBackColor = true;
            // 
            // txtJPEGPath
            // 
            this.txtJPEGPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJPEGPath.Location = new System.Drawing.Point(164, 40);
            this.txtJPEGPath.Name = "txtJPEGPath";
            this.txtJPEGPath.Size = new System.Drawing.Size(525, 22);
            this.txtJPEGPath.TabIndex = 0;
            // 
            // btnJPEGPath
            // 
            this.btnJPEGPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJPEGPath.Location = new System.Drawing.Point(699, 40);
            this.btnJPEGPath.Name = "btnJPEGPath";
            this.btnJPEGPath.Size = new System.Drawing.Size(160, 23);
            this.btnJPEGPath.TabIndex = 1;
            this.btnJPEGPath.Text = "Choose Path";
            this.btnJPEGPath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "JPEG Saved To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "RAW Saved To:";
            // 
            // btnRAWPath
            // 
            this.btnRAWPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRAWPath.Location = new System.Drawing.Point(699, 75);
            this.btnRAWPath.Name = "btnRAWPath";
            this.btnRAWPath.Size = new System.Drawing.Size(160, 23);
            this.btnRAWPath.TabIndex = 4;
            this.btnRAWPath.Text = "Choose Path";
            this.btnRAWPath.UseVisualStyleBackColor = true;
            // 
            // txtRawPath
            // 
            this.txtRawPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRawPath.Location = new System.Drawing.Point(164, 75);
            this.txtRawPath.Name = "txtRawPath";
            this.txtRawPath.Size = new System.Drawing.Size(525, 22);
            this.txtRawPath.TabIndex = 3;
            // 
            // ImageMasterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 510);
            this.Controls.Add(this.btnPerformProcessing);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageMasterMainForm";
            this.Text = "Image Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCameraPath;
        private System.Windows.Forms.TextBox txtCameraPath;
        private System.Windows.Forms.FolderBrowserDialog cameraPathFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblImages;
        private System.ComponentModel.BackgroundWorker initailScanWorker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNewTypicalSize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPerformProcessing;
        private System.Windows.Forms.TextBox txtJPEGPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRAWPath;
        private System.Windows.Forms.TextBox txtRawPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJPEGPath;
    }
}

