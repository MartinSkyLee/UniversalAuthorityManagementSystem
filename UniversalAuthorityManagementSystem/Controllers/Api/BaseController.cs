using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using DHSurvey.Common.Helper;
using IdentityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.ViewModels;
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

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <returns></returns>
        protected LoginUserInfo GetUserInfo()
        {
            LoginUserInfo userInfo = new LoginUserInfo();

            if (HttpContext.User.Claims.Count() != 0)
            {
                userInfo.UserName = HttpContext.User.FindFirstValue(JwtClaimTypes.Name);
                userInfo.DisplayName = HttpContext.User.FindFirstValue("displayname") ?? "";
                userInfo.UserId = Convert.ToInt32(HttpContext.User.FindFirstValue(JwtClaimTypes.Subject));
                userInfo.Email = HttpContext.User.FindFirstValue(JwtClaimTypes.Email);
                userInfo.IsSuper = Convert.ToBoolean(HttpContext.User.FindFirstValue("is_super"));

                string strRole = HttpContext.User.FindFirstValue(JwtClaimTypes.Role);
                userInfo.RoleIds = JsonConvertor.Deserialize<List<int>>(strRole);
            }

            return userInfo;
        }
    }
}