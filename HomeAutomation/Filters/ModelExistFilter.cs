using HomeAutomation.Controllers;
using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Filters
{
    public class ModelExistFilter<T> : IAsyncActionFilter
        where T : Entity
    {
        private IBaseService<T> service;
        public ModelExistFilter(IBaseService<T> service)
        {
            this.service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id;
            if (context.ActionArguments.ContainsKey("id"))
            {
                if(!long.TryParse(context.ActionArguments["id"].ToString(), out id))
                {
                    string msg = "Wrong Id format";
                    context.Result = new BadRequestObjectResult(msg);
                    return;
                }
            }
            else
            {
                string msg = "Id could not be found in parameters";
                context.Result = new BadRequestObjectResult(msg);
                return;
            }

            var enityExists = await service.Exists(id);
            if (!enityExists)
            {
                string msg = $"Data with id {id} can not be found.";
                context.Result = new NotFoundObjectResult(msg);
            }
            await next();
        }
    }
}
