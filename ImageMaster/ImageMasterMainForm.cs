using ImageMaster.Forms;
using ImageMaster.ImageWorker.MetaProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMaster
{
    public partial class ImageMasterMainForm : Form
    {

        private MetaProcessor metaProcessor;
        private BaseProgressForm baseProgres;

        private IEnumerable<FileInfo> imageFilePaths;

        private string selectedDirectory;
        private string jpegDirectory;
        private string rawDirectory;

        private int numberOfImages;
        private Size typicalSize;
        private bool metaWasProcessed;

        public ImageMasterMainForm()
        {
            InitializeComponent();
            metaProcessor = new MetaProcessor();
        }

        private void BtnCameraPath_Click(object sender, EventArgs e)
        {
            var outcome = cameraPathFileDialog.ShowDialog();

            if (outcome == DialogResult.OK)
            {

                baseProgres = new BaseProgressForm();
                baseProgres.FormText = "Scanning Selected Location For Images...";
                selectedDirectory = cameraPathFileDialog.SelectedPath;
                txtCameraPath.Text = selectedDirectory;

                initailScanWorker.RunWorkerAsync();
                baseProgres.ShowDialog();

            }
        }

        private void InitailScanWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (baseProgres != null)
                baseProgres.Close();

            if (!metaWasProcessed)
            {
                MessageBox.Show("There was an issue processing that directory or its contents", "Danger Will Robinson", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblImages.Text = metaProcessor.GetImageCountText(numberOfImages);
            lblSize.Text = metaProcessor.GetTypicalSizeText(typicalSize);
        }

        private void InitailScanWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            metaWasProcessed = metaProcessor.ScanDirectory(selectedDirectory, ref imageFilePaths, ref numberOfImages, ref typicalSize);
        }

        private void CBoxCopyRawImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxCopyRawImages.Checked)
            {
                txtRawPath.Enabled = true;
                btnRAWPath.Enabled = true;
            }
            else
            {
                txtRawPath.Enabled = false;
                btnRAWPath.Enabled = false;
            }
        }

        private void BtnJPEGPath_Click(object sender, EventArgs e)
        {
            var reponse = jpgPathFileDialog.ShowDialog();

            if (reponse == DialogResult.OK)
            {
                string path = jpgPathFileDialog.SelectedPath;
                txtJPEGPath.Text = path;
                jpegDirectory = path;
            }
         
        }

        private void BtnPerformProcessing_Click(object sender, EventArgs e)
        {
            string outdir = string.Empty;
            FilenameProcessor f = new FilenameProcessor();
            f.CreateDirectory(jpegDirectory,out outdir);
        }
    }
}
