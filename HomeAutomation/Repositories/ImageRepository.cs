using AutoMapper;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;

namespace HomeAutomation.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
