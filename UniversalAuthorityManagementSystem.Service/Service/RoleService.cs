using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.RoleVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class RoleService : BaseService<TbRoles>, IRoleService
    {
        public RoleService(UniversalAuthorityManagementContext context) : base(context)
        {

        }

        public PageResult GetResultList(QueryRoleParameters queryParameters)
        {
            PageResult result = new PageResult();

            IQueryable<TbRoles> data = _dbContext.TbRoles.Where(r => r.IsDelete == false && r.AppId == queryParameters.AppId)
                .OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                data = data.Where(d => d.RoleName.Contains(queryParameters.Name));
            }

            result.Total = data.Count();
            result.CurrentPage = queryParameters.Page;
            result.PageCount = (int)queryParameters.GetTotalPages(result.Total);
            result.Data = data.Skip(queryParameters.Rows * (queryParameters.Page - 1))
                .Take(queryParameters.Rows)
                .Select(d => new RoleResource
                {
                    RoleId = d.RoleId,
                    RoleName = d.RoleName,
                    CreateUserId = d.CreateUserId,
                    CreateTime = d.CreateTime,
                    Description = d.Description,
                    CreateUserName = _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId) != null ?
                                            _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId).SysUserName : string.Empty,
                    UseYn = d.UseYn,
                    StrUseYn = Convert.ToBoolean(d.UseYn) ? "是" : "否"
                })
                .ToList();

            return result;
        }

        public bool IsExistingRole(RoleCreateViewModel roleCreate)
        {
            var result = _dbContext.TbRoles.Where(r => r.RoleName == roleCreate.RoleName && r.AppId == roleCreate.AppId).ToList();

            if (result == null || result.Count() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public TbRoles GetSingleRole(int id)
        {
            var existingRole = _dbContext.TbRoles
               .Include(r => r.TbRolePermission)
               .AsNoTracking()
               .SingleOrDefault(r => r.RoleId == id && r.IsDelete == false);

            return existingRole;
        }

        public void AddRolePermission(TbRoles roleModel)
        {
            var permissions = _dbContext.TbPermission.Where(p => p.IsDelete == false).ToList();

            permissions.ForEach(p =>
            {
                roleModel.TbRolePermission.Add(new TbRolePermission
                {
                    PermissionId = p.PermissionId,
                    UseYn = false,
                    IsDelete = false
                });
            });
        }

        public List<RolePermissionTreeData> GetPermissionByRoleId(int roleId)
        {
            var role = _dbContext.TbRoles
                .Where(r => r.RoleId == roleId && r.IsDelete == false);

            if (role == null || role.Count() == 0)
            {
                return null;
            }

            var roleWithPermission = role.Include(r => r.TbRolePermission)
                                                   .ThenInclude(rolePermission => rolePermission.Permission)
                                                   .ThenInclude(permission => permission.Menu)
                                               .SingleOrDefault();

            var permissions = roleWithPermission.TbRolePermission
                .Where(r => r.Permission.IsDelete == false && r.IsDelete == false)
                .Select(r => r.Permission).ToList();

            var rolePermissions = roleWithPermission.TbRolePermission
                .Where(r => r.Permission.IsDelete == false && r.IsDelete == false)
                .ToList();

            //获取一级菜单
            var FirstMenu = permissions.Where(r => r.Menu.Level == 1)
                .Distinct(new DHSurvey.Common.Helper.ListCompare<TbPermission>((x, y) => x.MenuId == y.MenuId))
                .OrderBy(r => r.Menu.MenuOrder)
                .ToList();
            //获取二级菜单
            var SecondMenu = permissions.Where(r => r.Menu.Level == 2).ToList()
                .Distinct(new DHSurvey.Common.Helper.ListCompare<TbPermission>((x, y) => x.MenuId == y.MenuId))
                .OrderBy(r => r.Menu.MenuOrder)
                .ToList();
            //获取角色授权列表
            var result = FirstMenu.Select(f => new RolePermissionTreeData
            {
                MenuId = f.Menu.MenuId,
                MenuName = f.Menu.MenuName,
                Level = f.Menu.Level,
                PermissionId = f.PermissionId,
                PermissionName = f.PermissionName,
                UseYn = f.TbRolePermission
                    .Where(p => p.Permission.PermissionType == "menu")
                    .Select(p => Convert.ToBoolean(p.UseYn))
                    .SingleOrDefault(),
                Children = SecondMenu.Where(s => s.Menu.ParentMenuId == f.Menu.MenuId)
                    .Select(p => new Menus
                    {
                        MenuId = p.Menu.MenuId,
                        MenuName = p.Menu.MenuName,
                        Level = p.Menu.Level,
                        ParentMenuId = p.Menu.ParentMenuId,
                        Permission = rolePermissions.Where(g => g.RoleId == roleId && g.Permission.MenuId == p.MenuId)
                        .Select(m => new Buttons
                        {
                            PermissionId = Convert.ToInt32(m.PermissionId),
                            PermissionName = m.Permission.PermissionName,
                            UseYn = Convert.ToBoolean(m.UseYn)
                        }).ToList()
                    }).ToList()
            }).ToList();

            return result;
        }


        public void UpdateRolePermission(RolePermissionViewModel rolePermission, ref ResponseModel response)
        {
            var existingRole = _dbContext.TbRoles
                .Include(r => r.TbRolePermission)
                .AsNoTracking()
                .SingleOrDefaultAsync(r => r.RoleId == rolePermission.RoleId && r.IsDelete == false);

            if (existingRole == null)
            {
                response.SetNotFound("角色不存在");
                return;
            }

            try
            {
                UpdateRolePermission(rolePermission);

                if (_dbContext.SaveChanges() <= 0)
                {
                    response.SetError("未更新TbRolePermission表");
                    return;
                }
            }
            catch (Exception ex)
            {
                response.SetError($"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}");
                return;
            }

            response.SetSuccess("保存成功");
        }

        /// <summary>
        /// 更新TbRolePermission表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="buttonIds"></param>
        private void UpdateRolePermission(RolePermissionViewModel rolePermission)
        {
            var roleWithPermission = _dbContext.TbRolePermission
                .Include(p => p.Permission)
                    .ThenInclude(m => m.Menu)
                .AsNoTracking()
                .Where(r => r.RoleId == rolePermission.RoleId && r.IsDelete == false).ToList();

            roleWithPermission.ForEach(r =>
            {
                if (rolePermission.ButtonIds.Contains(r.Permission.PermissionId))
                {
                    r.UseYn = true;
                }
                else
                {
                    r.UseYn = false;
                }
            });

            _dbContext.TbRolePermission.UpdateRange(roleWithPermission);
        }
    }
}
