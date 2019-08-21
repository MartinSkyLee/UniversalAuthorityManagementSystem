using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.MenuVM;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;
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
            //本系统的所有角色
            var roles = _dbContext.TbRoles
                .Include(r => r.TbUserRole)
                .Where(r => r.IsDelete == false && r.AppId == menuModel.AppId).ToList();

            //创建者的角色ID
            var rolesLoginUser = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                .Where(u => u.IsDelete == false && u.UserId == menuModel.CreateUserId)
                .Select(u => u.TbUserRole.Select(r => r.Role.RoleId).ToList()).ToList();

            List<int> roleIdsLoginUser = new List<int>();

            foreach (var roleIds in rolesLoginUser)
            {
                foreach (var roleId in roleIds)
                {
                    roleIdsLoginUser.Add(roleId);
                }
            }

            List<TbRolePermission> rolePermissions = new List<TbRolePermission>();

            //为本系统的所有角色添加菜单权限，本用户拥有的角色默认开启，否则不开启
            foreach (var r in roles)
            {
                TbRolePermission rolePermission = new TbRolePermission
                {
                    RoleId = r.RoleId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CreateUserId = menuModel.CreateUserId,
                    UpdateUserId = menuModel.UpdateUserId,
                    UseYn = false,
                    IsDelete = false
                };

                if (roleIdsLoginUser.Contains(r.RoleId))
                {
                    rolePermission.UseYn = true;
                }

                rolePermissions.Add(rolePermission);
            }

            //超级管理员默认开启菜单
            rolePermissions.Add(new TbRolePermission
            {
                RoleId = 1, //超级管理员ID
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                CreateUserId = menuModel.CreateUserId,
                UpdateUserId = menuModel.UpdateUserId,
                UseYn = true,
                IsDelete = false
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

        public List<MenuTreeVM> GetMenuTree(int userId, int appId, bool isSuper)
        {
            List<MenuTreeVM> result = new List<MenuTreeVM>();

            string strSql = "SELECT DISTINCT M.* FROM tb_role_permission AS RP " +
                "LEFT JOIN tb_permission AS P ON P.permission_id = RP.permission_id " +
                "INNER JOIN tb_menu AS M ON M.menu_id = P.menu_id " +
                "WHERE P.is_delete = false AND M.app_id = {0} AND M.is_delete = false AND RP.is_delete = false AND RP.use_yn = true " +
                "AND EXISTS(SELECT 1 FROM tb_user_role AS UR WHERE UR.user_id = {1} AND UR.role_id = RP.role_id)";


            if (isSuper == true)
            {
                //如果是超级管理员
                strSql = @"SELECT * FROM tb_menu AS M WHERE M.is_delete = false AND M.app_id = {0}";
            }

            IQueryable<TbMenu> allMenus = _dbContext.TbMenu.FromSql(strSql, appId, userId);

            allMenus = allMenus.Include(m => m.TbPermission).OrderBy(x => x.Level).ThenBy(x => x.MenuOrder);

            result = MenuItemHelper.LoadMenuManageTree(allMenus.ToList(), 0);

            return result;
        }

        public List<NavMenuTreeVM> GetNavMenuTree(int userId, int appId, bool isSuper)
        {
            List<NavMenuTreeVM> result = new List<NavMenuTreeVM>();
            string strSql = "SELECT DISTINCT M.* FROM tb_role_permission AS RP " +
                "LEFT JOIN tb_permission AS P ON P.permission_id = RP.permission_id " +
                "INNER JOIN tb_menu AS M ON M.menu_id = P.menu_id " +
                "WHERE P.is_delete = false AND M.app_id = {0} AND M.is_delete = false AND RP.is_delete = false AND RP.use_yn = true " +
                "AND EXISTS(SELECT 1 FROM tb_user_role AS UR WHERE UR.user_id = {1} AND UR.role_id = RP.role_id)";


            if (isSuper == true)
            {
                //如果是超级管理员
                strSql = @"SELECT * FROM tb_menu AS M WHERE M.is_delete = false AND M.app_id = {0}";
            }

            IQueryable<TbMenu> allMenus = _dbContext.TbMenu.FromSql(strSql, appId, userId);

            allMenus = allMenus.Include(m => m.TbPermission).OrderBy(x => x.Level).ThenBy(x => x.MenuOrder);

            result = MenuItemHelper.LoadMenuTree(allMenus.ToList(), 0);

            return result;
        }
    }

    public static class MenuItemHelper
    {
        public static List<NavMenuTreeVM> BuildTree(this List<NavMenuTreeVM> menus, int selectedId = 0)
        {
            var lookup = menus.ToLookup(x => x.ParentMenuId);

            List<NavMenuTreeVM> Build(int pid)
            {
                return lookup[pid].Select(x => new NavMenuTreeVM
                {
                    MenuId = x.MenuId,
                    PermissionId = x.PermissionId,
                    PermissionName = x.PermissionName,
                    MenuName = x.MenuName,
                    Url = x.Url,
                    Level = x.Level,
                    ParentMenuId = x.ParentMenuId,
                    Description = x.Description,
                    Icon = x.Icon,
                    MenuOrder = x.MenuOrder,
                    Children = Build(x.MenuId)
                })
                .ToList();
            }

            var result = Build(selectedId);
            return result;
        }

        public static List<NavMenuTreeVM> LoadMenuTree(List<TbMenu> menus, int selectedId = 0)
        {
            var menuItems = menus.Select(x => new NavMenuTreeVM
            {
                MenuId = x.MenuId,
                PermissionId = x.TbPermission.FirstOrDefault() != null ? x.TbPermission.FirstOrDefault().PermissionId : 0,
                PermissionName = x.TbPermission.FirstOrDefault() != null ? x.TbPermission.FirstOrDefault().PermissionName : "",
                MenuName = x.MenuName,
                Url = x.Url,
                Level = x.Level ?? 0,
                ParentMenuId = x.ParentMenuId ?? 0,
                Description = x.Description,
                Icon = x.Icon,
                MenuOrder = x.MenuOrder
            })
            .ToList();
            var tree = menuItems.BuildTree(selectedId);

            return tree;
        }

        public static List<MenuTreeVM> BuildTree(this List<MenuTreeVM> menus, int selectedId = 0)
        {
            var lookup = menus.ToLookup(x => x.ParentMenuId);

            List<MenuTreeVM> Build(int pid)
            {
                return lookup[pid].Select(x => new MenuTreeVM
                {
                    MenuId = x.MenuId,
                    PermissionId = x.PermissionId,
                    PermissionName = x.PermissionName,
                    MenuName = x.MenuName,
                    Url = x.Url,
                    Level = x.Level,
                    ParentMenuId = x.ParentMenuId,
                    Description = x.Description,
                    Icon = x.Icon,
                    MenuOrder = x.MenuOrder,
                    Children = Build(x.MenuId).Count() <= 0 ? x.Children : Build(x.MenuId),
                })
                .ToList();
            }

            var result = Build(selectedId);
            return result;
        }

        public static List<MenuTreeVM> LoadMenuManageTree(List<TbMenu> menus, int selectedId = 0)
        {
            var menuItems = menus.Select(x => new MenuTreeVM
            {
                MenuId = x.MenuId,
                PermissionId = x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false) != null ? x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false).PermissionId : 0,
                PermissionName = x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false) != null ? x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false).PermissionName : "",
                MenuName = x.MenuName,
                Url = x.Url,
                Level = x.Level ?? 0,
                ParentMenuId = x.ParentMenuId ?? 0,
                Description = x.Description,
                Icon = x.Icon,
                MenuOrder = x.MenuOrder,
                Children = x.TbPermission.Where(p => p.IsDelete == false).Select(p => new ChildrenButtons
                {
                    PermissionId = p.PermissionId,
                    PermissionName = p.PermissionName,
                    MenuId = p.MenuId ?? 0,
                    Description = p.Description,
                    Url = p.Url
                }).ToList()
            })
            .ToList();
            var tree = menuItems.BuildTree(selectedId);

            return tree;
        }

        public static List<RoleAuthorizationTreeVM> BuildTree(this List<RoleAuthorizationTreeVM> menus, int selectedId = 0)
        {
            var lookup = menus.ToLookup(x => x.ParentMenuId);

            List<RoleAuthorizationTreeVM> Build(int pid)
            {
                return lookup[pid].Select(x => new RoleAuthorizationTreeVM
                {
                    MenuId = x.MenuId,
                    MenuName = x.MenuName,
                    Level = x.Level,
                    PermissionId = x.PermissionId,
                    PermissionName = Build(x.MenuId).Count() <= 0 ? "" : x.PermissionName,
                    UseYn = x.UseYn,
                    ParentMenuId = x.ParentMenuId,
                    Children = Build(x.MenuId),
                    Permission = Build(x.MenuId).Count() <= 0 ? x.Permission : null
                })
                .ToList();
            }

            var result = Build(selectedId);
            return result;
        }

        public static List<RoleAuthorizationTreeVM> LoadRoleAuthorizationTree(List<TbMenu> menus, int selectedId = 0, int roleId = 0)
        {
            var menuItems = menus.Select(x => new RoleAuthorizationTreeVM
            {
                MenuId = x.MenuId,
                MenuName = x.MenuName,
                Level = x.Level ?? 0,
                PermissionId = x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false) != null ? x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false).PermissionId : 0,
                PermissionName = x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false) != null ? x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false).PermissionName : "",
                UseYn = x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false) != null ?
                    x.TbPermission.FirstOrDefault(p => p.PermissionType == "menu" && p.IsDelete == false).TbRolePermission
                    .Where(p => p.RoleId == roleId)
                    .Select(p => Convert.ToBoolean(p.UseYn))
                    .SingleOrDefault() : false,
                ParentMenuId = x.ParentMenuId ?? 0,
                Permission = x.TbPermission.Where(p => p.IsDelete == false).Select(p => new Buttons
                {
                    PermissionId = p.PermissionId,
                    PermissionName = p.PermissionName,
                    UseYn = p.TbRolePermission.SingleOrDefault(rp => rp.RoleId == roleId) != null ?
                        p.TbRolePermission.SingleOrDefault(rp => rp.RoleId == roleId).UseYn ?? false : false
                }).ToList()
            })
            .ToList();
            var tree = menuItems.BuildTree(selectedId);

            return tree;
        }
    }
}
