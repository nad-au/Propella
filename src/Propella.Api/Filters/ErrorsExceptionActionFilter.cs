using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Propella.Application.Exceptions;
using Propella.Application.Results;

namespace Propella.Api.Filters
{
    public class ErrorsExceptionActionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is not ErrorsException qe) return;

            if (qe.IsCritical())
            {
                context.Result = new ObjectResult(new Response { Errors = qe.Errors})
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
            else
            {
                context.Result = new BadRequestObjectResult(new Response { Errors = qe.Errors});
            }
            
            context.ExceptionHandled = true;
        }
        
        public int Order => 100;
    }
}