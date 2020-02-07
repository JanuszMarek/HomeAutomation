using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Repositories
{
    public class ProducerRepository: BaseRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
