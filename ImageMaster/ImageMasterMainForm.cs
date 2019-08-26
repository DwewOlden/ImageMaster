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
        private string selectedDirectory;

        private int numberOfImages;

        private Size typicalSize;

        public ImageMasterMainForm()
        {
            InitializeComponent();
        }

        private void BtnCameraPath_Click(object sender, EventArgs e)
        {
            var outcome = cameraPathFileDialog.ShowDialog();

            if (outcome == DialogResult.OK)
            {
                selectedDirectory = cameraPathFileDialog.SelectedPath;
                txtCameraPath.Text = selectedDirectory;
            }
        }
    }
}
