using ImageMaster.ImageWorker.MetaProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMaster
{
    public partial class ImageMasterMainForm : Form
    {

        private MetaProcessor metaProcessor;

        private string selectedDirectory;

        private int numberOfImages;

        private Size typicalSize;

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
                selectedDirectory = cameraPathFileDialog.SelectedPath;
                txtCameraPath.Text = selectedDirectory;

                IEnumerable<string> paths = new List<string>().AsEnumerable();
                bool wasProcessed = metaProcessor.ScanDirectory(selectedDirectory, ref paths, ref numberOfImages, ref typicalSize);

                if (!wasProcessed)
                { 
                    MessageBox.Show("There was an issue processing that directory or its contents","Danger Will Robinson", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblImages.Text = metaProcessor.GetImageCountText(numberOfImages);
                lblSize.Text = metaProcessor.GetTypicalSizeText(typicalSize);
            }

        }
    }
}
