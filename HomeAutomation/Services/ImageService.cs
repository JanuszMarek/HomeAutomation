using AutoMapper;
using HomeAutomation.Models.DTO.Image;
using HomeAutomation.Models.Entities;
using HomeAutomation.Providers.Interfaces;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Services
{
    public class ImageService : IImageService
    {
        private readonly IAzureBlobStorageProvider azureBlobStorageProvider;
        private readonly IBaseRepository<Image> repository;

        public ImageService(IBaseRepository<Image> repository, IAzureBlobStorageProvider azureBlobStorageProvider)
        {
            this.repository = repository;
            this.azureBlobStorageProvider = azureBlobStorageProvider;
        }

        public async Task<ImageUploadReturnModel> CreateAsync(IFormFile imageFile)
        {
            if (IsImage(imageFile) && imageFile.Length > 0)
            {
                var uploadedImage = new Image();

                using (Stream stream = imageFile.OpenReadStream())
                {
                    uploadedImage.FilePath = await azureBlobStorageProvider.UploadFileToStorage(stream, imageFile.FileName);
                }
                repository.Create(uploadedImage);
                await repository.SaveChanges();

                var returnModel = new ImageUploadReturnModel()
                {
                    ImageId = uploadedImage.Id,
                    ImageUrl = uploadedImage.FilePath
                };
                return returnModel;
            }
            throw new Exception("Uploaded file is not a image or is empty");
        }

        private bool IsImage(IFormFile file)
        {
            if (file.ContentType.Contains("image"))
            {
                return true;
            }

            string[] formats = new string[] { ".jpg", ".png", ".gif", ".jpeg" };

            return formats.Any(item => file.FileName.EndsWith(item, StringComparison.OrdinalIgnoreCase));
        }
    }
}
