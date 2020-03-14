using HomeAutomation.Filters;
using HomeAutomation.Models.DTO.Producer;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : BaseController<Producer, ProducerInputModel, ProducerUpdateModel, IProducerService>
    {
        public ProducerController(IProducerService producerService): base(producerService)
        {
        }

        [HttpGet]
        public override async Task<IActionResult> GetListing<T>()
        {
            return await base.GetListing<ProducerModel>();
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        public override async Task<IActionResult> GetDetail<T>([FromRoute] long id) => await base.GetDetail<ProducerModel>(id);

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Create(ProducerInputModel inputModel) => await base.Create(inputModel);

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        [ServiceFilter(typeof(ModelValidationFilter))]
        public override async Task<IActionResult> Update(ProducerUpdateModel updateModel) => await base.Update(updateModel);

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ModelExistFilter<Producer>))]
        public override async Task<IActionResult> Delete([FromRoute] long id) => await base.Delete(id);
    }
}