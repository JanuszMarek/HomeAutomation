using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, Model, InputModel, UpdateModel> : ControllerBase
        where T : Entity
        where Model : IBaseModel
        where InputModel : IBaseInputModel
        where UpdateModel : IBaseUpdateModel
    {
        private IBaseService<T> service;
        public BaseController(IBaseService<T> service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(InputModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateModel updateModel)
        {
            await service.UpdateAsync(updateModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }

        [HttpGet()]
        public async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<Model>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetail([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<Model>(id);
            return Ok(model);
        }
    }
}