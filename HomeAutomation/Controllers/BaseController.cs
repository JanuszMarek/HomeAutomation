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
    public class BaseController<T, TInput, TUpdate, TService> : ControllerBase
        where T : Entity
        where TInput: IBaseInputModel
        where TUpdate: IBaseUpdateModel
        where TService : IBaseService<T>
    {
        public TService service;
        public BaseController(TService service)
        {
            this.service = service;
        }

        public virtual async Task<IActionResult> Create(TInput inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        public virtual async Task<IActionResult> Update(TUpdate updateModel)
        {
            await service.UpdateAsync(updateModel);
            return Ok();
        }

        public virtual async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }

        public virtual async Task<IActionResult> GetListing<TListing>() where TListing: IBaseModel
        {
            var listing = await service.Get<TListing>();
            return Ok(listing);
        }

        public virtual async Task<IActionResult> GetDetail<TDetail>([FromRoute] long id) where TDetail: IBaseModel
        {
            var model = await service.GetByIdAsync<TDetail>(id);
            return Ok(model);
        }
    }
}