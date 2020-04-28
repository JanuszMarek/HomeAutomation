using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.DTO;
using HomeAutomation.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadedImageController : ControllerBase
    {
        private ApplicationDbContext appContext;
 
        public UploadedImageController(ApplicationDbContext appContext)
        {
            this.appContext = appContext;
        }


        [HttpPost("upload")]
        public IActionResult Upload([FromForm] IFormFile logoFile)
        {


            return Ok();
        }
    }
}