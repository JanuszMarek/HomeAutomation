using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private IProducerService producerService;

        public ProducerController(IProducerService producerService)
        {
            this.producerService = producerService;
        }

        //[HttpGet()]
        //public async Task<IEnumerable<Producer>> GetListing()
        //{
        //    return await producerService.Get();
        //}
    }
}