using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class MenuService : BaseService<TbMenu>, IMenuService
    {
        public MenuService(UniversalAuthorityManagementContext context) : base(context)
        {

        }

        public void AddRolePermission(TbMenu menuModel)
        {
            var role = _dbContext.TbRoles
                .Include(r => r.TbUserRole)
                .Where(r => r.IsDelete == false && r.AppId == menuModel.AppId).ToList();

            List<TbRolePermission> rolePermissions = new List<TbRolePermission>();

            role.ForEach(r =>
            {
                //本用户创建的菜单默认开启
                if (r.TbUserRole.Any(u => u.UserId == menuModel.CreateUserId))
                {
                    rolePermissions.Add(new TbRolePermission
                    {
                        RoleId = r.RoleId,
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        CreateUserId = menuModel.CreateUserId,
                        UpdateUserId = menuModel.UpdateUserId,
                        UseYn = true,
                        IsDelete = false
                    });
                }
                else
                {
                    rolePermissions.Add(new TbRolePermission
                    {
                        RoleId = r.RoleId,
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        CreateUserId = menuModel.CreateUserId,
                        UpdateUserId = menuModel.UpdateUserId,
                        UseYn = false,
                        IsDelete = false
                    });
                }
            });

            menuModel.TbPermission.Add(new TbPermission
            {
                PermissionName = "查看页面",
                IsDelete = false,
                TbRolePermission = rolePermissions,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                CreateUserId = menuModel.CreateUserId,
                UpdateUserId = menuModel.UpdateUserId,
                PermissionType = "menu",
                Description = $"查看\"{menuModel.MenuName}\"页面权限"
            });
        }

        public TbMenu GetSingleMenu(int id)
        {
            var existingMenu = _dbContext.TbMenu.
                Include(m => m.TbPermission)
                    .ThenInclude(p => p.TbRolePermission)
                .AsNoTracking()
                .SingleOrDefault(m => m.MenuId == id && m.IsDelete == false);

            return existingMenu;
        }


        public List<MenuResource> GetTreeList(int? userId, int appId)
        {
            var sysUser = _dbContext.TbSysUser
               .Where(x => x.UserId == userId && x.IsDelete == false);

            if (sysUser == null || sysUser.Count() == 0)
            {
                return null;
            }

            var userWithPermissions = sysUser.Include(user => user.TbUserRole)
                                                .ThenInclude(userRole => userRole.Role)
                                                .ThenInclude(role => role.TbRolePermission)
                                                .ThenInclude(rolePermission => rolePermission.Permission)
                                                .ThenInclude(permission => permission.Menu)
                                             .SingleOrDefault();

            var permissions = userWithPermissions.TbUserRole
                .Select(p => p.Role.TbRolePermission
                    .Where(r => r.Permission.IsDelete == false && r.IsDelete == false)
                    .Select(r => r.Permission).ToList()
                ).ToList();

            //获取所有权限
            List<TbPermission> allPermissions = new List<TbPermission>();
            permissions.ForEach(p =>
            {
                allPermissions.AddRange(p);
            });

            //对于所有权限去重
            List<TbPermission> finalPermissions = new List<TbPermission>();
            allPermissions.ForEach(p =>
            {
                if (finalPermissions.Find(per => per.MenuId == p.MenuId && per.PermissionName == p.PermissionName) == null)
                {
                    finalPermissions.Add(p);
                }
            });

            //按照appId筛选属于该app的所有权限
            finalPermissions = finalPermissions.Where(p => p.Menu.AppId == appId).ToList();

            //获取一级菜单
            var FirstMenu = finalPermissions.Where(r => r.Menu.Level == 1)
                .Distinct(new DHSurvey.Common.Helper.ListCompare<TbPermission>((x, y) => x.MenuId == y.MenuId))
                .OrderBy(r => r.Menu.MenuOrder)
                .ToList();
            //获取二级菜单
            var SecondMenu = finalPermissions.Where(r => r.Menu.Level == 2).ToList()
                .Distinct(new DHSurvey.Common.Helper.ListCompare<TbPermission>((x, y) => x.MenuId == y.MenuId))
                .OrderBy(r => r.Menu.MenuOrder)
                .ToList();
            //构造菜单管理列表
            var result = FirstMenu.Select(f => new MenuResource
            {
                MenuId = f.Menu.MenuId,
                MenuName = f.Menu.MenuName,
                Url = f.Menu.Url,
                Level = f.Menu.Level,
                ParentMenuId = f.Menu.ParentMenuId,
                Description = f.Menu.Description,
                Icon = f.Menu.Icon,
                MenuOrder = f.Menu.MenuOrder,
                Children = SecondMenu.Where(s => s.Menu.ParentMenuId == f.Menu.MenuId)
                    .Select(p => new ChildrenMenus
                    {
                        MenuId = p.Menu.MenuId,
                        MenuName = p.Menu.MenuName,
                        Url = p.Menu.Url,
                        Level = p.Menu.Level,
                        ParentMenuId = p.Menu.ParentMenuId,
                        Description = p.Menu.Description,
                        Icon = p.Menu.Icon,
                        MenuOrder = p.Menu.MenuOrder,
                        Children = finalPermissions.Where(g => g.MenuId == p.MenuId)
                            .Select(m => new ChildrenButtons
                            {
                                PermissionId = m.PermissionId,
                                PermissionName = m.PermissionName,
                                MenuId = m.MenuId,
                                Description = m.Description
                            })
                            .ToList()
                    })
                    .ToList()
            })
            .ToList();

            return result;
        }


        public List<NavMenuModel> GetNavTreeJson(int? userId, int appId)
        {
            List<NavMenuModel> result = new List<NavMenuModel>();

            List<int> roleIds = _dbContext.TbSysUser
                                    .Include(u => u.TbUserRole)
                                        .ThenInclude(r => r.Role)
                                    .Where(u => u.UserId == userId)
                                    .Select(u => u.TbUserRole.Where(r => r.Role.AppId == appId)
                                                .Select(r => Convert.ToInt32(r.RoleId)).ToList())
                                    .FirstOrDefault();

            //获取用户所有角色可以访问的一级菜单和二级菜单
            List<TbMenu> allMenus = new List<TbMenu>();
            foreach (var roleId in roleIds)
            {
                var roleWithMenu = _dbContext.TbRoles.Where(r => r.RoleId == roleId)
                    .Include(role => role.TbRolePermission)
                        .ThenInclude(rolePermission => rolePermission.Permission)
                        .ThenInclude(permission => permission.Menu)
                    .SingleOrDefault();

                List<TbMenu> menus = roleWithMenu.TbRolePermission
                    .Where(r => (r.Permission.Menu.Level == 1 || r.Permission.Menu.Level == 2) && r.Permission.Menu.IsDelete == false && r.Permission.IsDelete == false && r.IsDelete == false && r.UseYn == true)
                    .Select(p => p.Permission.Menu)
                    .ToList();

                allMenus.AddRange(menus);
            }

            //通过遍历集合处理，获取不重复的菜单列表
            List<TbMenu> finalMenus = new List<TbMenu>();
            allMenus.ForEach(m =>
            {
                if (finalMenus.Find(p => p.MenuName == m.MenuName && p.DeviceTypeId == m.DeviceTypeId) == null)
                {
                    finalMenus.Add(m);
                }
            });

            //按照appId筛选属于该app的所有权限
            finalMenus = finalMenus.Where(m => m.AppId == appId).ToList();

            //获取一级菜单
            var FirstMenu = finalMenus.Where(r => r.Level == 1).OrderBy(r => r.MenuOrder).ToList();
            //获取二级菜单
            var SecondMenu = finalMenus.Where(r => r.Level == 2).OrderBy(r => r.MenuOrder).ToList();
            //构造菜单列表
            result = FirstMenu.Select(f => new NavMenuModel
            {
                FullName = f.MenuName,
                Icon = string.IsNullOrEmpty(f.Icon) ? "" : f.Icon,
                Children = SecondMenu.Where(s => s.ParentMenuId == f.MenuId)
                      .Select(p => new ChildrenMenu
                      {
                          MenuId = p.MenuId,
                          FullName = p.MenuName,
                          Icon = string.IsNullOrEmpty(p.Icon) ? "" : p.Icon,
                          Router = p.Url,
                          QueryParams = p.DeviceTypeId > 0 ? new QueryParamsModel { DeviceTypeId = p.DeviceTypeId } : null
                      })
                      .ToList()
            })
            .ToList();

            return result;
        }

    }
}
