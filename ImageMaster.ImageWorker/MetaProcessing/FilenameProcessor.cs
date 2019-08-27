using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMaster.ImageWorker.MetaProcessing
{
    public class FilenameProcessor
    {
        public  string GetNextFileName(string directory,string baseName)
        {
            string path = System.IO.Path.Combine(directory, baseName);
            if (!System.IO.File.Exists(path))
                return path;

            int index = 1;
            bool isPresent = true;
            string outputPath = string.Empty;

            while (isPresent)
            {
                string fn = string.Format("{0}_{1}", index, baseName);
                string combined = System.IO.Path.Combine(directory, fn);
                if (!System.IO.File.Exists(combined))
                {
                    isPresent = false;
                    outputPath = combined;
                }
            }

            return outputPath;

        }


        public bool CreateDirectory(string path,out string outdir)
        {
            string directoryName = GetDirectoryNameString();
            string completepath = System.IO.Path.Combine(path, directoryName);
            outdir = completepath;

            if (!System.IO.Directory.Exists(completepath))
                System.IO.Directory.CreateDirectory(completepath);

            if (System.IO.Directory.Exists(completepath))
                return true;
            else
                return false;
        }

        private string GetDirectoryNameString()
        {
            DateTime dateTime = DateTime.Now;
            string name = dateTime.ToString("dd MM yyyy");

            return name;
        }
    }
}
