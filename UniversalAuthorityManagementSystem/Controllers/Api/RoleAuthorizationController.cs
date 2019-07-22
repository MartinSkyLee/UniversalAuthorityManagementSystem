using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.Response;
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
                var result = _roleService.GetPermissionByRoleId(roleId);

                response.SetData(result);
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.SetError($"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}");
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

                _roleService.UpdateRolePermission(rolePermission, ref response);

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.SetError($"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}");
                return Ok(response);
            }
        }
    }
}