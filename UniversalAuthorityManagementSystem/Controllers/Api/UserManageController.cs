using System;
using AutoMapper;
using DHSurvey.Common.Helper;
using Microsoft.AspNetCore.Mvc;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.UserVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagementSystem.Controllers.Api
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserManageController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IAppService _appService;
        private readonly IMapper _mapper;

        public UserManageController(IUserService userService,IAppService appService, IMapper mapper)
        {
            _userService = userService;
            _appService = appService;
            _mapper = mapper;
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetUserList([FromQuery] QueryParameters queryParameters)
        {
            var response = ResponseModelFactory.CreateResultInstance;
            try
            {
                PageResult result = _userService.GetResultList(queryParameters);

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
        /// 新增用户
        /// </summary>
        /// <param name="userCreate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserCreateViewModel userCreate)
        {
            var response = ResponseModelFactory.CreateInstance;
            if (userCreate == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (_userService.IsExistingUser(userCreate.SysUserName))
            {
                response.SetBadRequest("用户名已存在！请重新输入。");
                return Ok(response);
            }

            var userModel = _mapper.Map<TbSysUser>(userCreate);
            userModel.IsDelete = false;
            userModel.Password = MD5Helper.MD5Encrypt32(userModel.Password);

            if (userCreate.RoleIds != null && userCreate.RoleIds.Count > 0)
            {
                foreach (var roleId in userCreate.RoleIds)
                {
                    if (roleId != 0)
                    {
                        TbUserRole userRole = new TbUserRole
                        {
                            RoleId = roleId
                        };
                        userModel.TbUserRole.Add(userRole);
                    }
                    else
                    {
                        response.SetBadRequest("新增失败！请重新选择该用户的角色。");
                        return Ok(response);
                    }
                }
            }
            else
            {
                response.SetBadRequest("新增失败！请选择该用户的角色。");
                return Ok(response);
            }

            if (!_userService.Create(userModel))
            {
                response.SetError("新增失败");
                return Ok(response);
            }

            response.SetCreated();
            return Ok(response);
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="userEdit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditUser([FromBody] UserEditViewModel userEdit)
        {
            var response = ResponseModelFactory.CreateInstance;
            if (userEdit == null)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            _userService.UpdateUser(userEdit, ref response);

            return Ok(response);
        }

        /// <summary>
        /// 软删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteUser([FromQuery]int id)
        {
            var response = ResponseModelFactory.CreateInstance;

            if (!ModelState.IsValid)
            {
                response.SetBadRequest();
                return Ok(response);
            }

            var existingUser = _userService.GetSingle(id);

            if (existingUser == null)
            {
                response.SetNotFound("用户不存在");
                return Ok(response);
            }

            existingUser.IsDelete = true;

            if (!_userService.Update(existingUser))
            {
                response.SetError("删除失败");
                return Ok(response);
            }

            response.SetNoContent("删除成功");
            return Ok(response);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ChangePassword([FromBody] PasswordViewModel password)
        {
            var response = ResponseModelFactory.CreateInstance;

            _userService.UpdatePassword(password, ref response);

            return Ok(response);
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="resetPasswordViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ResetUserPassword([FromBody] ResetPasswordViewModel resetPasswordViewModel)
        {
            var response = ResponseModelFactory.CreateInstance;

            _userService.ResetPassword(resetPasswordViewModel.Id, ref response);

            return Ok(response);
        }

        /// <summary>
        /// 获取新增或编辑用户时选择角色的下拉树形表数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetRolesWithAppTree()
        {
            var response = ResponseModelFactory.CreateDataInstance;
            try
            {
                var result = _appService.GetRolesWithAppTreeJson();

                response.SetData(result);
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
