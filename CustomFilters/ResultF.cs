using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.CustomFilters
{
    public class ResultF : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ViewResult
            {
                ViewName = "List"
            };
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}
