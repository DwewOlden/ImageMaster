﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMaster.ImageWorker.MetaProcessing
{
    /// <summary>
    /// A 
    /// </summary>
    public class MetaProcessor
    {
        public bool ScanDirectory(string path,ref List<string> ImagePath,ref int Images,ref Size size)
        {
            if (!System.IO.Directory.Exists(path))
                return false;

            return true;
        }
    }
}