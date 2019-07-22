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
                PageResult result = _appService.GetResultList(queryParameters);

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
        /// 新增应用程序
        /// </summary>
        /// <param name="appCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateApp([FromBody] AppCreateViewModel appCreate)
        {
            var response = ResponseModelFactory.CreateInstance;
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

            int? LoginUserId = GetLoginUserId();
            appModel.CreateUserId = LoginUserId;
            appModel.UpdateUserId = LoginUserId;


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
            int? LoginUserId = GetLoginUserId();
            existingApp.UpdateUserId = LoginUserId;

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

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingApp = _appService.GetSingle(id);

            if (existingApp == null)
            {
                response.SetNotFound("应用程序不存在");
                return Ok(response);
            }

            existingApp.IsDelete = true;
            existingApp.UpdateTime = DateTime.Now;
            int? LoginUserId = GetLoginUserId();
            existingApp.UpdateUserId = LoginUserId;

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
