using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.UserVM;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IUserService : IService<TbSysUser>
    {
        /// <summary>
        /// 获取用户列表数据
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        PageResult GetResultList(QueryParameters queryParameters);

        /// <summary>
        ///  新增用户时，判断用户是否重名
        /// </summary>
        /// <param name="sysUserName"></param>
        /// <returns></returns>
        bool IsExistingUser(string sysUserName);

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="response"></param>
        void UpdateUser(UserEditViewModel user, ref ResponseModel response);

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="password"></param>
        /// <param name="response"></param>
        void UpdatePassword(PasswordViewModel password, ref ResponseModel response);

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="response"></param>
        void ResetPassword(int id, ref ResponseModel response);

        /// <summary>
        /// 获取用户权限并存入缓存
        /// </summary>
        /// <param name="userId"></param>
        void GetAllPermissionUrls(int? userId);
    }
}
