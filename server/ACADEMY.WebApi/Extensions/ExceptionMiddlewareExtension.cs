using System;
using System.Net;
using ACADEMY.Application.ViewModels.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ACADEMY.WebApi.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(
                            new ApiErrorResponse<string>(
                                "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết", HttpStatusCode.InternalServerError).ToString());
                    }
                });
            });
        }
    }
}