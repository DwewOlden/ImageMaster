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

            return true;
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
