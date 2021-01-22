using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFileUpload.Shared
{
    public class UploadedFileRequest
    {

        /// <summary>
        /// where this file should be saved.  Default is "attachments"
        /// </summary>
        public string ServerRelativeFileNameAndPath { get; set; } 

        public string ClientSideFileName { get; set; }

        public byte[] FileContent { get; set; }
        public string FileDescription { get; set; }
    }
}
