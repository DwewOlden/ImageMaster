using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMaster.ImageWorker.MetaProcessing
{
    public class FilenameProcessor
    {
        public bool CreateDirectory(string path,bool includeRaw)
        {
            string directoryName = GetDirectoryNameString();
            string completepath = System.IO.Path.Combine(path, directoryName);

            return true;


        }

        private string GetDirectoryNameString()
        {
            DateTime dateTime = DateTime.Now;
            string name = dateTime.ToString("dd MM yyyy");

            return name;
        }
    }
}
