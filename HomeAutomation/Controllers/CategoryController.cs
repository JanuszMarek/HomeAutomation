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
    public class CategoryController : BaseController<Category, CategoryInputModel, CategoryUpdateModel, ICategoryService>
    {
        public CategoryController(ICategoryService CategoryService) : base(CategoryService)
        {
        }

        [HttpGet]
        public override async Task<IActionResult> GetListing<T>() => await base.GetListing<CategoryModel>();

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        public override async Task<IActionResult> GetDetail<T>([FromRoute] long id) => await base.GetDetail<CategoryModel>(id);

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Create(CategoryInputModel inputModel) => await base.Create(inputModel);

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Update(CategoryUpdateModel updateModel) => await base.Update(updateModel);

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Category>))]
        public override async Task<IActionResult> Delete([FromRoute] long id) => await base.Delete(id);
    }
}