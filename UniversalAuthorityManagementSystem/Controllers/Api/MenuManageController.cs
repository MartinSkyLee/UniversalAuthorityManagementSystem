using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;
using UniversalAuthorityManagement.Models.ViewModels.PermissionVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuManageController : BaseController
    {
        private readonly IMenuService _menuService;
        private readonly IPermissionService _permissionService;
        private readonly IMapper _mapper;

        public MenuManageController(IMenuService menuService, IPermissionService permissionService, IMapper mapper)
        {
            _menuService = menuService;
            _permissionService = permissionService;
            _mapper = mapper;
        }

        #region 对菜单进行增删改操作

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="menuCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateMenu([FromBody] MenuCreateViewModel menuCreate)
        {
            var response = ResponseModelFactory.CreateInstance;
            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, menuCreate.AppId);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("新增失败，用户无权限新增菜单。");
                return Ok(response);
            }

            if (menuCreate == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var menuModel = _mapper.Map<TbMenu>(menuCreate);

            menuModel.CreateTime = DateTime.Now;
            menuModel.UpdateTime = DateTime.Now;
            menuModel.CreateUserId = userInfo.UserId;
            menuModel.UpdateUserId = userInfo.UserId;
            menuModel.IsDelete = false;

            _menuService.AddRolePermission(menuModel);

            if (!_menuService.Create(menuModel))
            {
                response.SetError("新增失败");
                return Ok(response);
            }

            response.SetNoContent("新增成功");
            return Ok(response);
        }


        /// <summary>
        /// 编辑菜单
        /// </summary>
        /// <param name="menuEdit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditMenu([FromBody] MenuEditViewModel menuEdit)
        {
            var response = ResponseModelFactory.CreateInstance;

            if (menuEdit == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            TbMenu existingMenu = _menuService.GetSingle(menuEdit.MenuId);
            if (existingMenu == null)
            {
                response.SetNotFound("菜单不存在");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, existingMenu.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("编辑失败，用户无权限编辑菜单。");
                return Ok(response);
            }

            _mapper.Map(menuEdit, existingMenu);
            
            existingMenu.UpdateUserId = userInfo.UserId;
            existingMenu.UpdateTime = DateTime.Now;

            if (!_menuService.Update(existingMenu))
            {
                response.SetError("编辑失败");
                return Ok(response);
            }

            response.SetNoContent("编辑成功");
            return Ok(response);
        }

        /// <summary>
        /// 软删除菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteMenu([FromQuery] int id)
        {
            var response = ResponseModelFactory.CreateInstance;

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            TbMenu existingMenu = _menuService.GetSingleMenu(id);

            if (existingMenu == null)
            {
                response.SetNotFound("菜单不存在");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, existingMenu.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("删除失败，用户无权限删除菜单。");
                return Ok(response);
            }

            existingMenu.UpdateUserId = userInfo.UserId;
            existingMenu.UpdateTime = DateTime.Now;
            existingMenu.IsDelete = true;

            if (existingMenu.TbPermission != null)
            {
                foreach (var permission in existingMenu.TbPermission)
                {
                    permission.IsDelete = true;
                    permission.UpdateTime = DateTime.Now;
                    permission.UpdateUserId = existingMenu.UpdateUserId;
                    if (permission.TbRolePermission != null)
                    {
                        foreach (var rolePermission in permission.TbRolePermission)
                        {
                            rolePermission.IsDelete = true;
                            rolePermission.UpdateTime = DateTime.Now;
                            rolePermission.UpdateUserId = existingMenu.UpdateUserId;
                        }
                    }
                }
            }

            if (!_menuService.Update(existingMenu))
            {
                response.SetError("删除失败");
                return Ok(response);
            }

            response.SetNoContent("删除成功");
            return Ok(response);
        }

        #endregion

        #region 对权限（按钮）进行增删改操作

        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="permissionCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreatePermission([FromBody] PermissionCreateViewModel permissionCreate)
        {
            var response = ResponseModelFactory.CreateInstance;

            TbMenu existingMenu = _menuService.GetSingle(permissionCreate.MenuId ?? 0);
            if (existingMenu == null)
            {
                response.SetBadRequest("请选择所属菜单");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, existingMenu.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("新增失败，用户无权限新增按钮。");
                return Ok(response);
            }

            if (permissionCreate == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var permissionModel = _mapper.Map<TbPermission>(permissionCreate);

            permissionModel.CreateUserId = userInfo.UserId;
            permissionModel.UpdateUserId = userInfo.UserId;
            permissionModel.CreateTime = DateTime.Now;
            permissionModel.UpdateTime = DateTime.Now;
            permissionModel.IsDelete = false;
            permissionModel.PermissionType = "button";

            _permissionService.AddRolePermission(permissionModel);

            if (!_permissionService.Create(permissionModel))
            {
                response.SetError("新增失败");
                return Ok(response);
            }

            response.SetNoContent("新增成功");
            return Ok(response);
        }


        /// <summary>
        /// 编辑权限
        /// </summary>
        /// <param name="permissionEdit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditPermission([FromBody] PermissionEditViewModel permissionEdit)
        {
            var response = ResponseModelFactory.CreateInstance;
            TbMenu existingMenu = _menuService.GetSingle(permissionEdit.MenuId ?? 0);
            if (existingMenu == null)
            {
                response.SetBadRequest("请选择所属菜单");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, existingMenu.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("编辑失败，用户无权限编辑按钮。");
                return Ok(response);
            }

            if (permissionEdit == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingPermission = _permissionService.GetSingle(permissionEdit.PermissionId);

            if (existingPermission == null)
            {
                response.SetNotFound("按钮不存在");
                return Ok(response);
            }

            _mapper.Map(permissionEdit, existingPermission);

            existingPermission.UpdateUserId = userInfo.UserId;
            existingPermission.UpdateTime = DateTime.Now;

            if (!_permissionService.Update(existingPermission))
            {
                response.SetError("编辑失败");
                return Ok(response);
            }

            response.SetNoContent("编辑成功");
            return Ok(response);
        }

        /// <summary>
        /// 软删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeletePermission([FromQuery] int id)
        {
            var response = ResponseModelFactory.CreateInstance;
            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            TbPermission existingPermission = _permissionService.GetSinglePermission(id);

            if (existingPermission == null)
            {
                response.SetNotFound("按钮不存在");
                return Ok(response);
            }

            TbMenu existingMenu = _menuService.GetSingle(existingPermission.MenuId ?? 0);
            if (existingMenu == null)
            {
                response.SetBadRequest("请选择所属菜单");
                return Ok(response);
            }

            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);
            bool isSysAdmin = _menuService.IsSystemAdmin(userInfo.UserId, existingMenu.AppId ?? 0);

            //判断是否为超级管理员或者该系统管理员。
            if (!(isSuper || isSysAdmin))
            {
                response.SetNoPermission("删除失败，用户无权限删除按钮。");
                return Ok(response);
            }

            existingPermission.UpdateUserId = userInfo.UserId;
            existingPermission.UpdateTime = DateTime.Now;
            existingPermission.IsDelete = true;

            if (existingPermission.TbRolePermission != null)
            {
                foreach (var item in existingPermission.TbRolePermission)
                {
                    item.IsDelete = true;
                    item.UpdateTime = DateTime.Now;
                    item.UpdateUserId = existingPermission.UpdateUserId;
                }
            }

            if (!_permissionService.Update(existingPermission))
            {
                response.SetError("删除失败");
                return Ok(response);
            }

            response.SetNoContent("删除成功");
            return Ok(response);
        }

        #endregion

        /// <summary>
        /// 获取菜单管理树形列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMenuTreeList(int appId)
        {
            var response = ResponseModelFactory.CreateDataInstance;
            try
            {
                LoginUserInfo userInfo = GetUserInfo();
                bool isSuper = _menuService.IsSpuerAdministrator(userInfo.UserId);

                List<MenuTreeVM> result = _menuService.GetMenuTree(userInfo.UserId, appId, isSuper);

                response.SetData(result);
                return Ok(result);
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