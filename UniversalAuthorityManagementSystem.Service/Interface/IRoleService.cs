using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IRoleService : IService<TbRoles>
    {
        /// <summary>
        /// 获取角色列表数据
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        PageResult GetResultList(QueryRoleParameters queryParameters);

        /// <summary>
        /// 判断角色名称是否重名
        /// </summary>
        /// <param name="roleCreate"></param>
        /// <returns></returns>
        bool IsExistingRole(RoleCreateViewModel roleCreate);
        /// <summary>
        /// 获取加载导航属性的角色实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TbRoles GetSingleRole(int id);

        /// <summary>
        /// 新增角色时更新TbRolePermission
        /// </summary>
        /// <param name="roleModel"></param>
        void AddRolePermission(TbRoles roleModel);

        /// <summary>
        /// 获取角色授权列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<RolePermissionTreeData> GetPermissionByRoleId(int roleId);

        /// <summary>
        /// 更新角色授权
        /// </summary>
        /// <param name="rolePermission"></param>
        /// <param name="response"></param>
        void UpdateRolePermission(RolePermissionViewModel rolePermission, ref ResponseModel response);
    }
}
