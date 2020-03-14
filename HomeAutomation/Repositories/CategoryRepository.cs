using AutoMapper;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;

namespace HomeAutomation.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
