using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using DHSurvey.Common.Helper;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using UniversalAuthorityManagement.Models.Response;

namespace UniversalAuthorityManagementSystem.Extensions.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public CustomAuthorizeAttribute()
        {
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.Filters.Any(item => item is IAllowAnonymousFilter))
            {
                return;
            }

            if (!(context.ActionDescriptor is ControllerActionDescriptor))
            {
                return;
            }

            var response = ResponseModelFactory.CreateInstance;
            var user = context.HttpContext.User;
            bool isSpuer = Convert.ToBoolean(user.FindFirstValue("is_super"));

            if (isSpuer)
            {
                return;
            }

            if (!user.Identity.IsAuthenticated)
            {
                response.SetForbidden();
                context.Result = new ObjectResult(response)
                {
                    StatusCode = 403
                };
            }
            else
            {
                string requestUrl = context.HttpContext.Request.Path.Value;
                string strUserId = user.FindFirst(JwtClaimTypes.Id).Value;
                //获取Redis缓存内的权限url
                if (!CommonManager.CacheObj.Exists<RedisCacheHelper>(strUserId))
                {
                    response.SetNoPermission("无权限，未发现用户ID");
                    context.Result = new UnauthorizedObjectResult(response);
                }
                else
                {
                    List<string> urls = CommonManager.CacheObj.GetCache<List<string>, RedisCacheHelper>(strUserId);

                    if (!urls.Exists(u => (u != null ? u.ToLower() : "") == requestUrl.ToLower()))
                    {
                        response.SetNoPermission("用户无权限操作");
                        context.Result = new UnauthorizedObjectResult(response);
                    }
                }
            }
        }
    }
}
