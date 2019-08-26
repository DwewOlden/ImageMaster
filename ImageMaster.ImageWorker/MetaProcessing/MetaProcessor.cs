using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMaster.ImageWorker.MetaProcessing
{
    /// <summary>
    /// A class that will gather a list of images in the path and produce some information for the 
    /// user interface
    /// </summary>
    public class MetaProcessor
    {

        private const string extension = "*.JPG";


        public bool ScanDirectory(string path,ref IEnumerable<string> ImagePath,ref int Images,ref Size size)
        {
            if (!System.IO.Directory.Exists(path))
                return false;

            ImagePath = GetImagePaths(path);
            Images = ImagePath.Count();

            size = GetAverageSize(ImagePath);
            

            return true;
        }

        private Size GetAverageSize(IEnumerable<string> imagePath)
        {
            Size size = new Size();

            foreach (string path in imagePath)
            {
                Size imageSize = GetImageSize(path);
                size = size + imageSize;
            }

            size.Height = size.Height / imagePath.Count();
            size.Width = size.Width / imagePath.Count();

            return size;
        }

        private Size GetImageSize(string path)
        {
            Bitmap b = new Bitmap(path);
            Size s = new Size();


            if (b.Size.Height >= b.Size.Width)
                s = new Size(b.Width, b.Height);
            else
                s = new Size(b.Height, b.Width);

            b.Dispose();

            return s;
        }

        public string GetImageCountText(int numberOfImages)
        {
            return string.Format("Number Of Images: {0}", numberOfImages);
        }

        public string GetTypicalSizeText(Size size)
        {
            return string.Format("Typical Size: {0}W x{1}H", size.Width, size.Height);
        }

        /// <summary>
        /// Gets a list of all jpeg files in the passed directory.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private IEnumerable<string> GetImagePaths(string path)
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(path);
            var files = dirInfo.EnumerateFiles(extension,System.IO.SearchOption.AllDirectories);

            List<string> fileNames = new List<string>();
            foreach (var file in files)
                fileNames.Add(file.FullName);

            return fileNames;

        }
    }
}
