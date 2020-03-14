using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.Device;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : BaseController<Device, DeviceInputModel, DeviceUpdateModel, IDeviceService>
    {
        public DeviceController(IDeviceService DeviceService) : base(DeviceService)
        {
        }

        [HttpGet]
        public override async Task<IActionResult> GetListing<T>() => await base.GetListing<DeviceModel>();

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        public override async Task<IActionResult> GetDetail<T>([FromRoute] long id) => await base.GetDetail<DeviceModel>(id);

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Create(DeviceInputModel inputModel) => await base.Create(inputModel);

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Update(DeviceUpdateModel updateModel) => await base.Update(updateModel);

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        public override async Task<IActionResult> Delete([FromRoute] long id) => await base.Delete(id);
    }
}