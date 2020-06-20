using HomeAutomation.Models.DTO.Image;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface IImageService
    {
        Task<ImageUploadReturnModel> CreateAsync(IFormFile imageFile);
    }
}
