using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface IImageService
    {
        Task<long> CreateAsync(IFormFile imageFile);
    }
}
