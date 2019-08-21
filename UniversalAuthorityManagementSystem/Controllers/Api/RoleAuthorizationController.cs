using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleAuthorizationController : BaseController
    {
        private readonly IRoleService _roleService;

        public RoleAuthorizationController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        /// <summary>
        /// 获取角色授权树形列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPermissionTreeList(int roleId)
        {
            var response = ResponseModelFactory.CreateDataInstance;
            try
            {
                LoginUserInfo userInfo = GetUserInfo();

                List<RoleAuthorizationTreeVM> result = _roleService.GetPermissionByRoleId(roleId, userInfo);

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
        /// 保存角色权限
        /// </summary>
        /// <param name="rolePermission"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveRolePermission([FromBody] RolePermissionViewModel rolePermission)
        {
            var response = ResponseModelFactory.CreateInstance;
            try
            {
                if (!ModelState.IsValid)
                {
                    response.SetBadRequest();
                    return Ok(response);
                }

                LoginUserInfo userInfo = GetUserInfo();
                bool isSuper = _roleService.IsSpuerAdministrator(userInfo.UserId);
                bool isSysAdmin = _roleService.IsSystemAdmin(userInfo.UserId);

                //判断是否为超级管理员或者该系统管理员。
                if (!(isSuper || isSysAdmin))
                {
                    response.SetNoPermission("保存失败，用户无权限保存。");
                    return Ok(response);
                }

                _roleService.UpdateRolePermission(rolePermission, userInfo, ref response);

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.SetError();
                response.Exception = $"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}";
                return Ok(response);
            }
        }
    }
}