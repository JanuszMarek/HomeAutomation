using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Filters;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T, Model, InputModel, UpdateModel, TService> : ControllerBase
        where T : Entity
        where Model : IBaseModel
        where InputModel : IBaseInputModel
        where UpdateModel : IBaseUpdateModel
        where TService : IBaseService<T>
    {
        public TService service;
        public BaseController(TService service)
        {
            this.service = service;
        }

        public virtual async Task<IActionResult> Create(InputModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        public virtual async Task<IActionResult> Update(UpdateModel updateModel)
        {
            await service.UpdateAsync(updateModel);
            return Ok();
        }

        public virtual async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<Model>();
            return Ok(listing);
        }

        public virtual async Task<IActionResult> GetDetail([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<Model>(id);
            return Ok(model);
        }
    }
}