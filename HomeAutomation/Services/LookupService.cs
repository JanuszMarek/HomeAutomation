using AutoMapper;
using AutoMapper.QueryableExtensions;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.DTO;
using HomeAutomation.Repositories;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Services
{
    public class LookupService: ILookupService
    {
        private ApplicationDbContext dbContext;
        private IMapper mapper;

        public LookupService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<LookupModel>> GetEntityToLookupAsync<T>() where T: Entity
        {
            var collection = await dbContext.Set<T>().ProjectTo<LookupModel>(mapper.ConfigurationProvider).ToListAsync();
            return collection;
        }
    }
}
