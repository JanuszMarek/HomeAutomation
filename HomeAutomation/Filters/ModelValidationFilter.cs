using HomeAutomation.Models.DTO.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Filters
{
    public class ModelValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            KeyValuePair<string, object> param = context.ActionArguments.SingleOrDefault(p => p.Value is IBusinessInputModel);
            if (param.Value == null)
            {
                string msg = "Input data is null";
                context.Result = new BadRequestObjectResult(msg);
                return;
            }

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);

                //get all errors from model state
                string msg = string.Empty;
                context.ModelState.Values.SelectMany(v => v.Errors).ToList().ForEach(e => msg += e.ErrorMessage + " ");
            }
        }
    }
}
