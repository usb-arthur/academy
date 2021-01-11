using System.Collections.Generic;
using System.Linq;
using System.Net;
using ACADEMY.Application.ViewModels.Common;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ACADEMY.WebApi.Extensions
{
    public static class ModelStateExtension
    {
        public static ApiResponse<string> GetErrorMessage(this ModelStateDictionary modelState)
        {
            var error = modelState.Values.SelectMany(e => e.Errors).Select(e => e.ErrorMessage).FirstOrDefault();
            return new ApiErrorResponse<string>(error, HttpStatusCode.BadRequest);
        }
    }
}