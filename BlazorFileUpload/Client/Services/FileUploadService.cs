using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorFileUpload.Shared;

namespace BlazorFileUpload.Client
{
    public class FileUploadService : IFileUploadService
    {
        private readonly HttpClient ApiClient;
        private readonly IMessageLogger MsgLogger; 

        public FileUploadService(HttpClient api, IMessageLogger logger)
        {
            MsgLogger = logger;
            ApiClient = api;
        }

        /// <summary>
        /// This service just uploads the file, it creates no DB objects
        /// </summary>
        public async Task UploadAsync(UploadedFileRequest uploadedFile)
        {
            try
            {
                MsgLogger.WriteTrace("FileUploadService Uploading file");
                await ApiClient.PostAsJsonAsync<UploadedFileRequest>("/api/fileupload", uploadedFile);
            }
            catch (Exception e)
            {
                MsgLogger.WriteError($"FileUploadServie exception: {e.Message}");
                throw;
            }
            finally
            {
                MsgLogger.WriteTrace("FileUploadService done Uploading file");
            }
        }
    }

    public interface IFileUploadService
    {
        Task UploadAsync(UploadedFileRequest uploadedFile);
    }
}
