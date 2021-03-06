﻿using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.Device;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        IDeviceService service;
        public DeviceController(IDeviceService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<DeviceListingModel>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<DeviceEditModel>(id);
            return Ok(model);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Create(DeviceCreateModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Update([FromRoute] long id, DeviceCreateModel updateModel)
        {
            await service.UpdateAsync(id, updateModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Device>))]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }
    }
}