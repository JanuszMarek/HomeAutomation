using AutoMapper;
using AutoMapper.QueryableExtensions;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HomeAutomation.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected ApplicationDbContext dbContext;
        protected DbSet<T> dbSet;
        protected IMapper mapper;

        public BaseRepository(ApplicationDbContext dbContext, IMapper mapper) 
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<T>();
        }

        public async Task<bool> SaveChanges()
        {
            var result = await dbContext.SaveChangesAsync();
            return (result >= 0);
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public async Task<bool> Exists(long id)
        {
            return await dbSet.AnyAsync(x => x.Id == id);
        }

        public async Task<T> GetEntityById(long id)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<DTO> GetById<DTO>(long id) where DTO : IBaseModel
        {
            return await dbSet.Where(x => x.Id == id).ProjectTo<DTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<List<DTO>> Get<DTO>(Expression<Func<DTO, bool>> filter = null,Func<DTO, object> orderBy = null) where DTO : IBaseModel
        {
            var query = dbSet.ProjectTo<DTO>(mapper.ConfigurationProvider).AsQueryable();

            if(filter != null)
            {
                query = query.Where(filter);
            }
            if(orderBy != null)
            {
                query = query.OrderBy(orderBy).AsQueryable();
            }

            return await query.ToListAsync();
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
