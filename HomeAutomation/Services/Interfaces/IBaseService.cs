﻿using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HomeAutomation.Services.Interfaces
{
    public interface IBaseService<T> where T: Entity
    {
        Task<bool> Exists(long id);
        Task<DTO> GetByIdAsync<DTO>(long id) where DTO : IBaseModel;
        Task<List<DTO>> Get<DTO>(Expression<Func<DTO, bool>> filter = null, Func<DTO, object> orderBy = null) where DTO : IBaseModel;
        Task UpdateAsync(long id, IBaseCreateModel updateModel);
        Task DeleteAsync(long id);
        Task<long> CreateAsync(IBaseCreateModel inputModel);
        Task SaveChangesAsync();
    }
}
