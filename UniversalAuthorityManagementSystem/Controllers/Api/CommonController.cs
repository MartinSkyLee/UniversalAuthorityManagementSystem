using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommonController : BaseController
    {
        private readonly IMenuService _menuService;
        private readonly IPermissionService _permissionService;
        private readonly IUserService _userService;

        public CommonController(IMenuService menuService, IPermissionService permissionService, IUserService userService)
        {
            _menuService = menuService;
            _permissionService = permissionService;
            _userService = userService;
        }

        /// <summary>
        /// 获取指定App的导航栏树形列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetNavTreeList(int appId)
        {
            var response = ResponseModelFactory.CreateDataInstance;
            try
            {
                LoginUserInfo userInfo = GetUserInfo();
                bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);

                List<NavMenuTreeVM> result = _menuService.GetNavMenuTree(userInfo.UserId, appId, isSuper);
                //_userService.GetAllPermissionUrls(userId);

                response.SetData(result);
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.SetError();
                response.Exception = $"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}";
                return Ok(response);
            }
        }

        /// <summary>
        /// 获取指定页面的按钮权限
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetButtonsPermission(int menuId)
        {
            var response = ResponseModelFactory.CreateDataInstance;
            try
            {

                int? userId = GetLoginUserId();

                if (userId == null)
                {
                    response.SetNoPermission();
                    return Ok(response);
                }

                var result = _permissionService.GetButtonsPermissionByMenuId(menuId, userId);

                response.SetData(result);
                return Ok(response);

            }
            catch (Exception ex)
            {
                response.SetError();
                response.Exception = $"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}";
                return Ok(response);
            }
        }

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetLoginUserInfo", Name = nameof(GetLoginUserInfo))]
        [AllowAnonymous]
        public IActionResult GetLoginUserInfo()
        {
            LoginUserInfo userInfo = new LoginUserInfo();

            if (HttpContext.User.Claims.Count() != 0)
            {
                userInfo = GetUserInfo();
            }

            return Ok(new
            {
                LoginUserInfo = userInfo
            });
        }
    }
}