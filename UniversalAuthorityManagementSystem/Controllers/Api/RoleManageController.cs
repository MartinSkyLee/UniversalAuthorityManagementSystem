using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleManageController : BaseController
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public RoleManageController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetRoleList([FromQuery] QueryRoleParameters queryParameters)
        {
            var response = ResponseModelFactory.CreateResultInstance;
            try
            {
                LoginUserInfo userInfo = GetUserInfo();
                bool isSuper = _roleService.IsSpuerAdministrator(userInfo.UserId);
                bool isSysAdmin = _roleService.IsSystemAdmin(userInfo.UserId, queryParameters.AppId);

                PageResult result = _roleService.GetResultList(queryParameters, isSuper, isSysAdmin);

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
        /// 新增角色
        /// </summary>
        /// <param name="roleCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateRole([FromBody] RoleCreateViewModel roleCreate)
        {
            var response = ResponseModelFactory.CreateInstance;
            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _roleService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _roleService.IsSystemAdmin(userInfo.UserId, roleCreate.AppId);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("新增失败，用户无权限新增角色。");
                return Ok(response);
            }

            if (roleCreate == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (_roleService.IsExistingRole(roleCreate))
            {
                response.SetBadRequest("角色名已存在！请重新输入。");
                return Ok(response);
            }

            var roleModel = _mapper.Map<TbRoles>(roleCreate);

            roleModel.CreateTime = DateTime.Now;
            roleModel.UpdateTime = DateTime.Now;
            roleModel.CreateUserId = userInfo.UserId;
            roleModel.UpdateUserId = userInfo.UserId;
            roleModel.IsDelete = false;
            roleModel.UseYn = true;

            _roleService.AddRolePermission(roleModel);

            if (!_roleService.Create(roleModel))
            {
                response.SetError("新增失败");
                return Ok(response);
            }

            response.SetNoContent("新增成功");
            return Ok(response);
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="roleEdit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditRole([FromBody] RoleEditViewModel roleEdit)
        {
            var response = ResponseModelFactory.CreateInstance;
            if (roleEdit == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingRole = _roleService.GetSingle(roleEdit.RoleId);

            if (existingRole == null)
            {
                response.SetNotFound("角色不存在");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _roleService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _roleService.IsSystemAdmin(userInfo.UserId, existingRole.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("编辑失败，用户无权限编辑角色。");
                return Ok(response);
            }

            _mapper.Map(roleEdit, existingRole);

            existingRole.UpdateTime = DateTime.Now;
            existingRole.UpdateUserId = userInfo.UserId;

            if (!_roleService.Update(existingRole))
            {
                response.SetError("编辑失败");
                return Ok(response);
            }

            response.SetNoContent("编辑成功");
            return Ok(response);
        }

        /// <summary>
        /// 软删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteRole([FromQuery] int id)
        {
            var response = ResponseModelFactory.CreateInstance;

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingRole = _roleService.GetSingleRole(id);

            if (existingRole == null)
            {
                response.SetNotFound("角色不存在");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _roleService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _roleService.IsSystemAdmin(userInfo.UserId, existingRole.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("删除失败，用户无权限删除角色。");
                return Ok(response);
            }

            existingRole.IsDelete = true;
            existingRole.UpdateTime = DateTime.Now;
            existingRole.UpdateUserId = userInfo.UserId;

            if (existingRole.TbRolePermission != null)
            {
                foreach (var item in existingRole.TbRolePermission)
                {
                    item.IsDelete = true;
                    item.UpdateTime = DateTime.Now;
                    item.UpdateUserId = userInfo.UserId;
                }
            }

            if (!_roleService.Update(existingRole))
            {
                response.SetError("删除失败");
                return Ok(response);
            }

            response.SetNoContent("删除成功");
            return Ok(response);
        }
    }
}