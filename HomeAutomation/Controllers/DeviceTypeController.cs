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
            var listing = await service.Get<DeviceTypeModel>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        public async Task<IActionResult> GetDetail([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<DeviceTypeModel>(id);
            return Ok(model);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Create(DeviceTypeInputModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Update(DeviceTypeUpdateModel updateModel)
        {
            await service.UpdateAsync(updateModel);
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