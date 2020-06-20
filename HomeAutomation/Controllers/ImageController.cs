using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService uploadedImageService;
 
        public ImageController(IImageService uploadedImageService)
        {
            this.uploadedImageService = uploadedImageService;
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm] IFormFile logoFile)
        {
            var resultId = uploadedImageService.CreateAsync(logoFile);

            return Ok(resultId);
        }
    }
}