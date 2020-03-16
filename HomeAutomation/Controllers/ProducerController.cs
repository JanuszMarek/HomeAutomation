using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        IProducerService service;
        public ProducerController(IProducerService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<ProducerListingModel>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        public async Task<IActionResult> GetDetail([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<ProducerBaseModel>(id);
            return Ok(model);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Create(ProducerInputModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Update([FromRoute] long id, ProducerInputModel updateModel)
        {
            await service.UpdateAsync(id, updateModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }
    }
}