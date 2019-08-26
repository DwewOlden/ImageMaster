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
            this.btnCameraPath = new System.Windows.Forms.Button();
            this.txtCameraPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCameraPath);
            this.groupBox1.Controls.Add(this.btnCameraPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Of Pictures On Camera";
            // 
            // btnCameraPath
            // 
            this.btnCameraPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraPath.Location = new System.Drawing.Point(524, 29);
            this.btnCameraPath.Name = "btnCameraPath";
            this.btnCameraPath.Size = new System.Drawing.Size(120, 23);
            this.btnCameraPath.TabIndex = 0;
            this.btnCameraPath.Text = "Choose Path";
            this.btnCameraPath.UseVisualStyleBackColor = true;
            // 
            // txtCameraPath
            // 
            this.txtCameraPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraPath.Location = new System.Drawing.Point(19, 31);
            this.txtCameraPath.Name = "txtCameraPath";
            this.txtCameraPath.Size = new System.Drawing.Size(499, 20);
            this.txtCameraPath.TabIndex = 1;
            // 
            // ImageMasterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 297);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageMasterMainForm";
            this.Text = "Image Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCameraPath;
        private System.Windows.Forms.TextBox txtCameraPath;
    }
}

