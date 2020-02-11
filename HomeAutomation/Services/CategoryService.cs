using AutoMapper;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services.Interfaces;

namespace HomeAutomation.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IBaseRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        { }
    }
}
