using AutoMapper.QueryableExtensions;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.DTO.Interfaces;
using HomeAutomation.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected ApplicationDbContext dbContext;
        protected DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext dbContext) 
        {
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

        public async Task<T> GetById(long id)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
