using System;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Net.Http;
using BlazorFileUpload.Shared;
using Microsoft.AspNetCore.Hosting;

namespace BlazorFileUpload.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment env;

        public FileUploadController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        /// <summary>
        /// this method only puts a file on the server for the caller.  it creates no db objects
        /// </summary>
        [HttpPost]
        public void Post(UploadedFileRequest uploadedFile)
        {
            try
            {
                //rely on the caller to add a unique identifier to the filename, and to specify the location on the server
                var fullPath = CalcTargetFolderAndFilename(uploadedFile);
                var fs = System.IO.File.Create(fullPath);
                fs.Write(uploadedFile.FileContent, 0, uploadedFile.FileContent.Length);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        private string CalcTargetFolderAndFilename(UploadedFileRequest uploadedFile)
        {
            var fullPath = Path.Combine(GetWebRootPath(), uploadedFile.ServerRelativeFileNameAndPath);
            CreateFolderIfNecessary(fullPath);
            return fullPath;
        }

        private void CreateFolderIfNecessary(string fullPath)
        {
            var dirName = Path.GetDirectoryName(fullPath);
            if (string.IsNullOrEmpty(dirName)) return;
            if (!Directory.Exists(dirName)) Directory.CreateDirectory(dirName);
        }


        private string GetWebRootPath()
        {
            //if running in Dev with IISExpress, this may be empty
            if (string.IsNullOrEmpty(env.WebRootPath)) return "/";
            return env.WebRootPath;
        }

    }

}