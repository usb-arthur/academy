using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ACADEMY.WebApi.Extensions
{
    public static class ModelStateExtension
    {
        public static ICollection<string> GetErrorMessage(this ModelStateDictionary modelState)
        {
            return modelState.Values.SelectMany(e => e.Errors).Select(e => e.ErrorMessage).ToList();
        }
    }
}