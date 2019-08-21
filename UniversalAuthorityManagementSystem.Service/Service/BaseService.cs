using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class BaseService<T> : IService<T> where T : class
    {
        protected UniversalAuthorityManagementContext _dbContext;
        public BaseService(UniversalAuthorityManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(T t)
        {
            _dbContext.Add(t);
            return SaveChange();
        }

        public bool Update(T t)
        {
            _dbContext.Update(t);
            return SaveChange();
        }

        public bool Delete(T t)
        {
            _dbContext.Remove(t);
            return SaveChange();
        }

        public bool SaveChange()
        {
            return (_dbContext.SaveChanges() >= 0);
        }

        public T GetSingle(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public bool IsSpuerAdministrator(int userId)
        {
            TbSysUser user = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(r => r.Role)
                .AsNoTracking()
                .FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                return false;
            }

            if (user.TbUserRole != null)
            {
                List<TbRoles> roles = user.TbUserRole.Select(u => u.Role).ToList();
                if (roles.Exists(r => r.IsSuperAdministrator == true && r.IsDelete == false))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool IsSystemAdmin(int userId, int appId)
        {
            TbSysUser user = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(r => r.Role)
                .AsNoTracking()
                .FirstOrDefault(u => u.UserId == userId && u.IsDelete == false);

            if (user == null)
            {
                return false;
            }

            if (user.TbUserRole != null)
            {
                TbRoles role = user.TbUserRole.Select(u => u.Role)
                    .FirstOrDefault(r => r.AppId == appId && r.IsSystemAdmin == true && r.IsDelete == false);

                if (role == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSystemAdmin(int userId)
        {
            TbSysUser user = _dbContext.TbSysUser
                .Include(u => u.TbUserRole)
                    .ThenInclude(r => r.Role)
                .AsNoTracking()
                .FirstOrDefault(u => u.UserId == userId && u.IsDelete == false);

            if (user == null)
            {
                return false;
            }

            if (user.TbUserRole != null)
            {
                TbRoles role = user.TbUserRole.Select(u => u.Role)
                    .FirstOrDefault(r => r.IsSystemAdmin == true && r.IsDelete == false);

                if (role == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
