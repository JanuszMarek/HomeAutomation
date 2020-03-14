using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Models.DTO;
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
    public class ProducerController : BaseController<Producer, ProducerModel, ProducerInputModel, ProducerUpdateModel>
    {
        public ProducerController(IProducerService producerService): base(producerService)
        {
        }
    }
}