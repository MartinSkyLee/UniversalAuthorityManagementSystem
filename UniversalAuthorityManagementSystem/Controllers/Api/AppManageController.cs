using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.AppVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppManageController : BaseController
    {
        private readonly IAppService _appService;
        private readonly IMapper _mapper;

        public AppManageController(IMapper mapper, IAppService appService)
        {
            _mapper = mapper;
            _appService = appService;
        }

        /// <summary>
        /// 获取应用程序列表
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAppList([FromQuery] QueryParameters queryParameters)
        {
            var response = ResponseModelFactory.CreateResultInstance;
            try
            {
                LoginUserInfo userInfo = GetUserInfo();
                bool isSuper = _appService.IsSpuerAdministrator(userInfo.UserId);
                PageResult result = new PageResult();
                if (isSuper)
                {
                    result = _appService.GetResultList(queryParameters);
                    response.SetData(result);
                }
                else
                {
                    result = _appService.GetResultList(queryParameters, userInfo.UserId);
                    response.SetData(result);
                }

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
        /// 新增应用程序
        /// </summary>
        /// <param name="appCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateApp([FromBody] AppCreateViewModel appCreate)
        {
            var response = ResponseModelFactory.CreateInstance;
            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _appService.IsSpuerAdministrator(userInfo.UserId);

            //判断是否为超级管理员。若否，则无法创建应用程序
            if (!isSuper)
            {
                response.SetNoPermission("新增失败，用户无权限新增应用程序。");
                return Ok(response);
            }

            if (appCreate == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var appModel = _mapper.Map<TbApplication>(appCreate);
            appModel.IsDelete = false;
            appModel.CreateTime = DateTime.Now;
            appModel.UpdateTime = DateTime.Now;
            appModel.CreateUserId = userInfo.UserId;
            appModel.UpdateUserId = userInfo.UserId;

            //默认创建该应用程序的内置系统管理员
            appModel.TbRoles.Add(new TbRoles
            {
                RoleName = "系统管理员",
                UseYn = true,
                CreateUserId = userInfo.UserId,
                CreateTime = DateTime.Now,
                UpdateUserId = userInfo.UserId,
                UpdateTime = DateTime.Now,
                IsDelete = false,
                Description = "内置系统管理员，不可删除或修改。",
                IsBuiltInRole = true,
                IsSuperAdministrator = false,
                IsSystemAdmin = true
            });

            if (!_appService.Create(appModel))
            {
                response.SetError("新增失败");
                return Ok(response);
            }

            response.SetCreated();
            return Ok(response);
        }


        /// <summary>
        /// 编辑应用程序
        /// </summary>
        /// <param name="appEdit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditApp([FromBody] AppEditViewModel appEdit)
        {
            var response = ResponseModelFactory.CreateInstance;
            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _appService.IsSpuerAdministrator(userInfo.UserId);

            //判断是否为超级管理员。若否，则无法创建应用程序
            if (!isSuper)
            {
                response.SetNoPermission("编辑失败，用户无权限编辑应用程序。");
                return Ok(response);
            }

            if (appEdit == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingApp = _appService.GetSingle(appEdit.AppId);

            if (existingApp == null)
            {
                response.SetNotFound("应用程序不存在");
                return Ok(response);
            }

            _mapper.Map(appEdit, existingApp);

            existingApp.UpdateTime = DateTime.Now;
            existingApp.UpdateUserId = userInfo.UserId;

            if (!_appService.Update(existingApp))
            {
                response.SetError("编辑失败");
                return Ok(response);
            }

            response.SetNoContent("编辑成功");
            return Ok(response);
        }

        /// <summary>
        /// 软删除应用程序
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteApp([FromQuery] int id)
        {
            var response = ResponseModelFactory.CreateInstance;
            LoginUserInfo userInfo = GetUserInfo();
            bool isSuper = _appService.IsSpuerAdministrator(userInfo.UserId);

            //判断是否为超级管理员。若否，则无法创建应用程序
            if (!isSuper)
            {
                response.SetNoPermission("删除失败，用户无权限删除应用程序。");
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            TbApplication existingApp = _appService.GetSingleApp(id);

            if (existingApp == null)
            {
                response.SetNotFound("应用程序不存在");
                return Ok(response);
            }

            existingApp.IsDelete = true;
            existingApp.UpdateTime = DateTime.Now;
            existingApp.UpdateUserId = userInfo.UserId;

            if (existingApp.TbRoles != null && existingApp.TbRoles.Count > 0)
            {
                foreach (var item in existingApp.TbRoles)
                {
                    item.IsDelete = true;
                    item.UpdateTime = DateTime.Now;
                    item.UpdateUserId = userInfo.UserId;
                    if (item.TbRolePermission != null && item.TbRolePermission.Count > 0)
                    {
                        foreach (var rp in item.TbRolePermission)
                        {
                            rp.IsDelete = true;
                            rp.UpdateTime = DateTime.Now;
                            rp.UpdateUserId = userInfo.UserId;
                        }
                    }

                    _appService.RemoveUserRole(item);
                }
            }

            if (existingApp.TbMenu != null && existingApp.TbMenu.Count > 0)
            {
                foreach (var item in existingApp.TbMenu)
                {
                    item.IsDelete = true;
                    item.UpdateTime = DateTime.Now;
                    item.UpdateUserId = userInfo.UserId;
                    if (item.TbPermission != null && item.TbPermission.Count > 0)
                    {
                        foreach (var p in item.TbPermission)
                        {
                            p.IsDelete = true;
                            p.UpdateTime = DateTime.Now;
                            p.UpdateUserId = userInfo.UserId;
                            if (p.TbRolePermission != null && p.TbRolePermission.Count > 0)
                            {
                                foreach (var rp in p.TbRolePermission)
                                {
                                    rp.IsDelete = true;
                                    rp.UpdateTime = DateTime.Now;
                                    rp.UpdateUserId = userInfo.UserId;
                                }
                            }
                        }
                    }
                }
            }

            if (!_appService.Update(existingApp))
            {
                response.SetError("删除失败");
                return Ok(response);
            }

            response.SetNoContent("删除成功");
            return Ok(response);
        }
    }
}
