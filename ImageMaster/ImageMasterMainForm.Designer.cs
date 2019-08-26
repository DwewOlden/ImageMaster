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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCameraPath);
            this.groupBox1.Controls.Add(this.btnCameraPath);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(881, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Of Pictures On Camera";
            // 
            // txtCameraPath
            // 
            this.txtCameraPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraPath.Location = new System.Drawing.Point(25, 38);
            this.txtCameraPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCameraPath.Name = "txtCameraPath";
            this.txtCameraPath.Size = new System.Drawing.Size(664, 22);
            this.txtCameraPath.TabIndex = 1;
            // 
            // btnCameraPath
            // 
            this.btnCameraPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraPath.Location = new System.Drawing.Point(699, 36);
            this.btnCameraPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // ImageMasterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageMasterMainForm";
            this.Text = "Image Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

