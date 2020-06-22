using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.Category;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService service;
        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListing()
        {
            var listing = await service.Get<CategoryListingModel>();
            return Ok(listing);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            var model = await service.GetByIdAsync<CategoryEditModel>(id);
            return Ok(model);
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Create(CategoryCreateModel inputModel)
        {
            var createdId = await service.CreateAsync(inputModel);
            return Ok(new { id = createdId });
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public async Task<IActionResult> Update([FromRoute] long id, CategoryCreateModel updateModel)
        {
            await service.UpdateAsync(id, updateModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await service.DeleteAsync(id);
            return Ok();
        }
    }
}