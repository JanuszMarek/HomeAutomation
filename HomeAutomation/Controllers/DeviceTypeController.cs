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
    public class DeviceTypeController : BaseController<DeviceType, DeviceTypeInputModel, DeviceTypeUpdateModel, IDeviceTypeService>
    {
        public DeviceTypeController(IDeviceTypeService DeviceTypeService) : base(DeviceTypeService)
        {
        }

        [HttpGet]
        public override async Task<IActionResult> GetListing<T>() => await base.GetListing<DeviceTypeModel>();

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        public override async Task<IActionResult> GetDetail<T>([FromRoute] long id) => await base.GetDetail<DeviceTypeModel>(id);

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Create(DeviceTypeInputModel inputModel) => await base.Create(inputModel);

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Update(DeviceTypeUpdateModel updateModel) => await base.Update(updateModel);

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<DeviceType>))]
        public override async Task<IActionResult> Delete([FromRoute] long id) => await base.Delete(id);
    }
}