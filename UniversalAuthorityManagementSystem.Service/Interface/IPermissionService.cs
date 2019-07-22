using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.PermissionVM;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IPermissionService : IService<TbPermission>
    {
        /// <summary>
        /// 新增权限时更新TbRolePermission表
        /// </summary>
        /// <param name="permissionModel"></param>
        void AddRolePermission(TbPermission permissionModel);

        /// <summary>
        /// 获取加载导航属性的权限实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TbPermission GetSinglePermission(int id);

        /// <summary>
        /// 按照menuId和loginName获取单个页面的按钮权限
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<PermissionResource> GetButtonsPermissionByMenuId(int menuId, int? userId);
    }
}
