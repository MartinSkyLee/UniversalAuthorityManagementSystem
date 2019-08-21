using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.AppVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class AppService : BaseService<TbApplication>, IAppService
    {
        public AppService(UniversalAuthorityManagementContext context) : base(context)
        {
        }

        public PageResult GetResultList(QueryParameters queryParameters)
        {
            PageResult result = new PageResult();

            IQueryable<TbApplication> data = _dbContext.TbApplication.Where(a => a.IsDelete == false)
                .OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                data = data.Where(d => d.AppName.Contains(queryParameters.Name));
            }

            result.Total = data.Count();
            result.CurrentPage = queryParameters.Page;
            result.PageCount = (int)queryParameters.GetTotalPages(result.Total);
            result.Data = data.Skip(queryParameters.Rows * (queryParameters.Page - 1))
                    .Take(queryParameters.Rows)
                    .Select(d => new AppResource
                    {
                        AppId = d.AppId,
                        AppName = d.AppName,
                        Description = d.Description,
                        CreateUserId = d.CreateUserId,
                        CreateUserName = _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId) != null ?
                                            _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId).SysUserName : string.Empty,
                        CreateTime = d.CreateTime
                    })
                    .ToList();

            return result;
        }

        public PageResult GetResultList(QueryParameters queryParameters, int userId)
        {
            PageResult result = new PageResult();

            TbSysUser user = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(r => r.Role)
                .FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                return result;
            }

            List<int> appIds = new List<int>();
            if (user.TbUserRole != null)
            {
                appIds = user.TbUserRole.Select(u => u.Role.AppId ?? 0).ToList();
            }
            else
            {
                return result;
            }

            IQueryable<TbApplication> data = _dbContext.TbApplication.Where(a => appIds.Contains(a.AppId) && a.IsDelete == false)
                .OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                data = data.Where(d => d.AppName.Contains(queryParameters.Name));
            }

            result.Total = data.Count();
            result.CurrentPage = queryParameters.Page;
            result.PageCount = (int)queryParameters.GetTotalPages(result.Total);
            result.Data = data.Skip(queryParameters.Rows * (queryParameters.Page - 1))
                    .Take(queryParameters.Rows)
                    .Select(d => new AppResource
                    {
                        AppId = d.AppId,
                        AppName = d.AppName,
                        Description = d.Description,
                        CreateUserId = d.CreateUserId,
                        CreateUserName = _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId) != null ?
                                            _dbContext.TbSysUser.SingleOrDefault(u => u.UserId == d.CreateUserId).SysUserName : string.Empty,
                        CreateTime = d.CreateTime
                    })
                    .ToList();

            return result;
        }

        public List<AppWithRoleTreeViewModel> GetRolesWithAppTreeJson(LoginUserInfo userInfo)
        {
            List<AppWithRoleTreeViewModel> result = new List<AppWithRoleTreeViewModel>();

            TbSysUser user = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(r => r.Role)
                .FirstOrDefault(u => u.UserId == userInfo.UserId);

            if (user == null)
            {
                return result;
            }

            List<int> appIds = new List<int>();
            if (user.TbUserRole != null)
            {
                appIds = user.TbUserRole.Select(u => u.Role.AppId ?? 0).ToList();
            }
            else
            {
                return result;
            }

            var apps = _dbContext.TbApplication
                .Include(a => a.TbRoles)
                .Where(a => a.IsDelete == false);

            bool isSysAdmin = IsSystemAdmin(userInfo.UserId);

            //判断是否为超级管理员或者该系统管理员。
            if (!(userInfo.IsSuper || isSysAdmin))
            {
                return new List<AppWithRoleTreeViewModel>();
            }
            else if (userInfo.IsSuper == false && isSysAdmin == true)
            {
                apps = apps.Where(a => appIds.Contains(a.AppId) && a.TbRoles.Any(r => r.IsSystemAdmin == true));
            }

            result = apps.Select(a => new AppWithRoleTreeViewModel
            {
                Title = a.AppName,
                Value = a.AppId,
                Key = a.AppId,
                Children = a.TbRoles.Where(r => r.IsDelete == false).OrderBy(r => r.RoleId)
                        .Select(r => new ChildNode
                        {
                            Title = r.RoleName,
                            Value = r.RoleId,
                            Key = r.RoleId
                        }).ToList()
            })
            .ToList();

            return result;
        }

        public TbApplication GetSingleApp(int id)
        {
            TbApplication application = _dbContext.TbApplication
                .Include(a => a.TbRoles)
                    .ThenInclude(r => r.TbRolePermission)
                .Include(a => a.TbMenu)
                    .ThenInclude(m => m.TbPermission)
                    .ThenInclude(p => p.TbRolePermission)
                .FirstOrDefault(a => a.AppId == id && a.IsDelete == false);

            return application;
        }

        public void RemoveUserRole(TbRoles role)
        {
            List<TbUserRole> userRoles = _dbContext.TbUserRole.Where(ur => ur.Id == role.RoleId).ToList();

            if (userRoles != null && userRoles.Count > 0)
            {
                _dbContext.Remove(userRoles);
            }
        }
    }
}
