using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using HomeAutomation.Models.Configuration;
using HomeAutomation.Providers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Providers
{
    public class AzureBlobStorageProvider : IAzureBlobStorageProvider
    {
        private AzureStorageConfig storageConfig;

        public AzureBlobStorageProvider(IOptions<AzureStorageConfig> storageConfig)
        {
            this.storageConfig = storageConfig.Value;
        }

        public async Task<string> UploadFileToStorage(Stream fileStream, string fileName)
        {
            var filePath = storageConfig.LogoContainer + "/" + fileName;
            // Create a URI to the blob
            Uri blobUri = GetUri(filePath);

            // Create StorageSharedKeyCredentials object by reading
            // the values from the configuration (appsettings.json)
            StorageSharedKeyCredential storageCredentials =
                new StorageSharedKeyCredential(storageConfig.AccountName, storageConfig.AccountKey);

            // Create the blob client.
            BlobClient blobClient = new BlobClient(blobUri, storageCredentials);

            // Upload the file
            await blobClient.UploadAsync(fileStream);

            return await Task.FromResult(filePath);
        }

        private Uri GetUri(string filePath = null)
        {
            return new Uri("https://" +
                           storageConfig.AccountName +
                           ".blob.core.windows.net/" +
                           filePath);
        }
    }
}
