using System;
using System.Collections.Generic;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IMenuService : IService<TbMenu>
    {
        /// <summary>
        /// 新增菜单时更新TbRolePermission表
        /// </summary>
        /// <param name="menuModel"></param>
        void AddRolePermission(TbMenu menuModel);

        /// <summary>
        /// 获取加载导航属性的菜单实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TbMenu GetSingleMenu(int id);

        /// <summary>
        /// 获取导航栏树形菜单Json
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<NavMenuModel> GetNavTreeJson(int? userId, int appId);

        /// <summary>
        /// 获取菜单管理树形列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<MenuResource> GetTreeList(int? userId, int appId);
    }
}
