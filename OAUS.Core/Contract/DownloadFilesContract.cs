﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Innov.Core
{
    public class DownloadFileContract
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }
}
