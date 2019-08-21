using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.AppVM;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IAppService : IService<TbApplication>
    {
        /// <summary>
        /// 获取应用程序列表数据
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        PageResult GetResultList(QueryParameters queryParameters);

        /// <summary>
        /// 通过用户ID获取应用程序列表数据
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        PageResult GetResultList(QueryParameters queryParameters, int userId);

        /// <summary>
        /// 获取选择角色时的下拉树形表数据
        /// </summary>
        /// <returns></returns>
        List<AppWithRoleTreeViewModel> GetRolesWithAppTreeJson(LoginUserInfo userInfo);

        TbApplication GetSingleApp(int id);
        void RemoveUserRole(TbRoles item);
    }
}
