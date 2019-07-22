using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.ViewModels.PermissionVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class PermissionService : BaseService<TbPermission>, IPermissionService
    {
        public PermissionService(UniversalAuthorityManagementContext context) : base(context)
        {

        }

        public void AddRolePermission(TbPermission permissionModel)
        {
            var menu = _dbContext.TbMenu.Where(m => m.IsDelete == false && m.MenuId == permissionModel.MenuId)
                .SingleOrDefault();

            var role = _dbContext.TbRoles
                .Include(r => r.TbUserRole)
                .Where(r => r.IsDelete == false && r.AppId == menu.AppId).ToList();

            role.ForEach(r =>
            {
                if (r.TbUserRole.Any(u => u.UserId == permissionModel.CreateUserId))
                {
                    permissionModel.TbRolePermission.Add(new TbRolePermission
                    {
                        RoleId = r.RoleId,
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        CreateUserId = permissionModel.CreateUserId,
                        UpdateUserId = permissionModel.UpdateUserId,
                        UseYn = true,
                        IsDelete = false
                    });
                }
                else
                {
                    permissionModel.TbRolePermission.Add(new TbRolePermission
                    {
                        RoleId = r.RoleId,
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        CreateUserId = permissionModel.CreateUserId,
                        UpdateUserId = permissionModel.UpdateUserId,
                        UseYn = false,
                        IsDelete = false
                    });
                }
            });
        }

        public TbPermission GetSinglePermission(int id)
        {
            var existingPermission = _dbContext.TbPermission.
                Include(p => p.TbRolePermission)
                .AsNoTracking()
                .SingleOrDefault(p => p.PermissionId == id && p.IsDelete == false);

            return existingPermission;
        }


        public List<PermissionResource> GetButtonsPermissionByMenuId(int menuId, int? userId)
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
                                             .SingleOrDefault();

            var permissions = userWithPermissions.TbUserRole
                .Select(p => p.Role.TbRolePermission
                    .Where(r => r.Permission.IsDelete == false && r.IsDelete == false && r.UseYn == true)
                    .Select(r => new PermissionResource
                    {
                        PermissionId = Convert.ToInt32(r.PermissionId),
                        PermissionName = r.Permission.PermissionName,
                        MenuId = r.Permission.MenuId,
                        Description = r.Permission.Description,
                        IsDelete = r.IsDelete
                    }).ToList()
                ).ToList();

            //获取所有的按钮权限
            List<PermissionResource> allPermissions = new List<PermissionResource>();
            permissions.ForEach(p =>
            {
                allPermissions.AddRange(p);
            });

            //对于所有的按钮权限去重
            List<PermissionResource> finalPermissions = new List<PermissionResource>();
            allPermissions.ForEach(p =>
            {
                if (finalPermissions.Find(per => per.MenuId == p.MenuId && per.PermissionName == p.PermissionName) == null)
                {
                    finalPermissions.Add(p);
                }
            });

            var result = finalPermissions.Where(p => p.MenuId == menuId && p.IsDelete == false).ToList();

            return result;
        }
    }
}
