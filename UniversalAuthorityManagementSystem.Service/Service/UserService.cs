using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using UniversalAuthorityManagement.Models;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Models.Query;
using UniversalAuthorityManagement.Models.Response;
using UniversalAuthorityManagement.Models.ViewModels;
using UniversalAuthorityManagement.Models.ViewModels.UserVM;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class UserService : BaseService<TbSysUser>, IUserService
    {
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _settings;

        public UserService(UniversalAuthorityManagementContext context, IOptions<AppSettings> settings, IMapper mapper) : base(context)
        {
            _mapper = mapper;
            _settings = settings;
        }


        public PageResult GetResultList(QueryParameters queryParameters, LoginUserInfo userInfo)
        {
            PageResult result = new PageResult();

            IQueryable<TbSysUser> data = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(u => u.Role)
                .AsNoTracking()
                .Where(u => u.IsDelete == false)
                .OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            bool isSysAdmin = IsSystemAdmin(userInfo.UserId);

            //判断是否为超级管理员或者该系统管理员。
            if (!(userInfo.IsSuper || isSysAdmin))
            {
                return result;
            }
            else if (userInfo.IsSuper == false && isSysAdmin == true)
            {
                data = data.Where(d => d.CreateUserId == userInfo.UserId || d.UserId == userInfo.UserId);
            }

            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                data = data.Where(d => d.SysUserName.Contains(queryParameters.Name));
            }

            result.Total = data.Count();
            result.CurrentPage = queryParameters.Page;
            result.PageCount = (int)queryParameters.GetTotalPages(result.Total);
            result.Data = data.Skip(queryParameters.Rows * (queryParameters.Page - 1))
                    .Take(queryParameters.Rows)
                    .Select(d => new UserResource
                    {
                        UserId = d.UserId,
                        SysUserName = d.SysUserName,
                        Mobile = d.Mobile,
                        Email = d.Email,
                        Position = d.Position,
                        Telephone = d.Telephone,
                        RoleIds = d.TbUserRole.Where(r => r.Role.IsDelete == false)
                                        .Select(t => t.Role.RoleId).ToList()
                    })
                    .ToList();

            return result;
        }


        public bool IsExistingUser(string sysUserName)
        {
            var user = _dbContext.TbSysUser.Where(u => u.SysUserName == sysUserName && u.IsDelete == false).ToList();

            if (user == null || user.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UpdateUser(UserEditViewModel user, LoginUserInfo userInfo, bool isSysAdmin, ref ResponseModel response)
        {
            var existingUser = _dbContext.TbSysUser
               .Include(u => u.TbUserRole)
                   .ThenInclude(u => u.Role)
               .AsNoTracking()
               .SingleOrDefault(u => u.UserId == user.UserId && u.IsDelete == false);

            if (existingUser == null)
            {
                response.SetNotFound("用户不存在");
                return;
            }

            //判断是否为超级管理员或者该系统管理员
            if (!(userInfo.IsSuper || isSysAdmin))
            {
                response.SetNoPermission("编辑失败，无权限编辑用户信息。");
                return;
            }
            else if (userInfo.IsSuper == false && isSysAdmin == true)
            {
                if (userInfo.UserId != existingUser.CreateUserId)
                {
                    response.SetNoPermission("编辑失败，无权限编辑用户信息。");
                    return;
                }
            }

            _mapper.Map(user, existingUser);

            try
            {
                UpdateUserRole(user.RoleIds, existingUser);

                if (existingUser.TbUserRole.Count() <= 0)
                {
                    response.SetBadRequest("编辑失败！请选择该用户的角色。");
                    return;
                }

                existingUser.UpdateUserId = userInfo.UserId;
                existingUser.UpdateTime = DateTime.Now;

                Update(existingUser);
            }
            catch (Exception ex)
            {
                response.SetError();
                response.Exception = $"Msg: {ex.Message}.\r\n StackTrace: \r\n{ex.StackTrace}";
                return;
            }

            response.SetNoContent("编辑成功");
        }

        /// <summary>
        /// 更新TbUserRole表
        /// </summary>
        /// <param name="selectedRoleIds"></param>
        /// <param name="userToUpdate"></param>
        private void UpdateUserRole(List<int> selectedRoleIds, TbSysUser userToUpdate)
        {
            if (selectedRoleIds == null)
            {
                userToUpdate.TbUserRole = new List<TbUserRole>();
                return;
            }

            var selectedRoleHS = new HashSet<int>(selectedRoleIds);
            var roleHS = new HashSet<int>(userToUpdate.TbUserRole.Select(m => m.Role.RoleId));
            foreach (var role in _dbContext.TbRoles)
            {
                if (selectedRoleHS.Contains(role.RoleId))
                {
                    if (!roleHS.Contains(role.RoleId))
                    {
                        userToUpdate.TbUserRole.Add(new TbUserRole
                        {
                            RoleId = role.RoleId,
                            UserId = userToUpdate.UserId,
                        });
                    }
                }
                else
                {
                    if (roleHS.Contains(role.RoleId))
                    {
                        TbUserRole userToRemove = userToUpdate.TbUserRole
                            .SingleOrDefault(i => i.RoleId == role.RoleId);
                        _dbContext.Remove(userToRemove);
                    }
                }
            }
        }


        public void UpdatePassword(PasswordViewModel password, ref ResponseModel response)
        {
            var existingUser = _dbContext.TbSysUser
                .Where(u => u.UserId == password.UserId && u.IsDelete == false)
                .SingleOrDefault();

            if (existingUser == null)
            {
                response.SetNotFound("用户不存在");
                return;
            }

            if (password.NewPassword != password.CheckedNewPassword)
            {
                response.SetBadRequest("两次新密码输入不一致！请重新输入新密码。");
                return;
            }

            if (DHSurvey.Common.Helper.MD5Helper.MD5Encrypt32(password.OldPassword) != existingUser.Password)
            {
                response.SetBadRequest("旧密码输入错误！请重新输入旧密码。");
                return;
            }
            else
            {
                if (password.OldPassword == password.NewPassword)
                {
                    response.SetBadRequest("新密码与旧密码相同！请重新输入新密码。");
                    return;
                }
            }

            existingUser.Password = DHSurvey.Common.Helper.MD5Helper.MD5Encrypt32(password.NewPassword);


            if (!Update(existingUser))
            {
                response.SetError("密码修改失败");

                return;
            }

            response.SetNoContent("密码修改成功");
        }

        public void ResetPassword(int id, ref ResponseModel response)
        {
            var existingUser = _dbContext.TbSysUser
                .Where(u => u.UserId == id && u.IsDelete == false)
                .SingleOrDefault();

            if (existingUser == null)
            {
                response.SetNotFound("用户不存在！");
                return;
            }

            string NewPassword = _settings.Value.InitialValue;//读取配置文件中的初始密码

            existingUser.Password = DHSurvey.Common.Helper.MD5Helper.MD5Encrypt32(NewPassword);

            if (!Update(existingUser))
            {
                response.SetError("密码重置失败！");
                return;
            }

            response.SetNoContent("密码重置成功");
        }

        public void GetAllPermissionUrls(int? userId)
        {
            var sysUser = _dbContext.TbSysUser
              .Where(x => x.UserId == userId && x.IsDelete == false);

            if (sysUser == null || sysUser.Count() == 0)
            {
                return;
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

            List<string> urls = finalPermissions.Select(p => p.Url).ToList();

            if (!DHSurvey.Common.Helper.CommonManager.CacheObj.Exists<DHSurvey.Common.Helper.MemoryCacheHelper>(userId.ToString()))
            {
                DHSurvey.Common.Helper.CommonManager.CacheObj.Save<DHSurvey.Common.Helper.MemoryCacheHelper>(userId.ToString(), urls);
            }
            else
            {
                DHSurvey.Common.Helper.CommonManager.CacheObj.Delete<DHSurvey.Common.Helper.MemoryCacheHelper>(userId.ToString());
                DHSurvey.Common.Helper.CommonManager.CacheObj.Save<DHSurvey.Common.Helper.MemoryCacheHelper>(userId.ToString(), urls);
            }
        }
    }
}
