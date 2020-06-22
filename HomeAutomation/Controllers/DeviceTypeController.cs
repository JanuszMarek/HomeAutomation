using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.DeviceType;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceTypeController : ControllerBase
    {
        IDeviceTypeService service;
        public DeviceTypeController(IDeviceTypeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<DeviceTypeListingModel>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<DeviceTypeEditModel>(id);
            return Ok(model);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Create(DeviceTypeCreateModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Update([FromRoute] long id, DeviceTypeCreateModel updateModel)
        {
            await service.UpdateAsync(id, updateModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }
    }
}