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

        public List<AppWithRoleTreeViewModel> GetRolesWithAppTreeJson()
        {
            var apps = _dbContext.TbApplication
                .Include(a => a.TbRoles)
                .Where(a => a.IsDelete == false)
                .ToList();

            var result = apps.Select(a => new AppWithRoleTreeViewModel
            {
                Title = a.AppName,
                Value = a.AppId,
                Key = a.AppId,
                Children = a.TbRoles.Where(r => r.IsDelete == false)
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
    }
}
