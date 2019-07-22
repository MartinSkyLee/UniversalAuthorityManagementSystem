using System;
using System.Linq;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagementSystem.Extensions.Filters;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [CustomAuthorize]
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// 获取登录用户ID
        /// </summary>
        /// <returns></returns>
        protected int? GetLoginUserId()
        {
            int? LoginUserId = null;
            if (HttpContext.User.Claims.Count() != 0)
            {
                LoginUserId = Convert.ToInt32(HttpContext.User.FindFirst(JwtClaimTypes.Subject).Value);
            }

            return LoginUserId;
        }
    }
}